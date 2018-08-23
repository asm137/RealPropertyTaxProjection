using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Excel = NetOffice.ExcelApi;
using System.Data.SQLite;

using Intangic.RPTP.Domain;
using Intangic.RPTP.Business.Interfaces;

namespace Intangic.RPTP.Business.Impl
{
    public class RealPropertyTaxProjectionManager : IRealPropertyTaxProjectionService
    {
        public ComputeEquivalentTaxResponse ComputeEquivalentTax(ComputeEquivalentTaxRequest request) {
            ComputeEquivalentTaxResponse response = null;

            try {
                response = new ComputeEquivalentTaxResponse();
                response.MarketValue = request.LandArea * request.UnitValue;
                response.AssessmentLevel = response.MarketValue * (request.AssessmentLevel * 100);
                response.EquivalentTax = response.AssessmentLevel * (request.TaxRate * 100);

                //save to database

                response.IsSuccess = true;

                return response;
            }
            finally {
                response = null;
            }
        }

        public ImportBuildingDataFileResponse ImportBuildingDataFile(ImportBuildingDataFileRequest request) {
            ImportBuildingDataFileResponse response = null;

            try {
                response = new ImportBuildingDataFileResponse();

                //read file from excel, using NPOI
                Excel.Application excelApplication = null;

                
                using (excelApplication = new Excel.Application()) {
                    Excel.Workbook workBook = excelApplication.Workbooks.Open(request.SourceFilePath,
                        0, true, 5, "", "", true, null, "\t", false, false, 0, true, 1, 0);
                    Excel.Worksheet workSheet = (Excel.Worksheet)workBook.Sheets[1];
                    Excel.Range excelRange = workSheet.UsedRange;
                    int rowCount = excelRange.Rows.Count;
                    int colCount = excelRange.Columns.Count;

                    System.Data.SQLite.SQLiteConnection cn = new SQLiteConnection(@"Data Source=C:\sqlite\test.db;Version=3;New=True;Compress=True;");
                    SQLiteCommand sqlite_cmd;
                    SQLiteDataReader sqlite_datareader;

                    // open the connection:
                    cn.Open();

                    // create a new SQL command:
                    sqlite_cmd = cn.CreateCommand();

                    // Let the SQLiteCommand object know our SQL-Query:
                    sqlite_cmd.CommandText = "CREATE TABLE hello (id integer primary key, text varchar(100));";

                    // Now lets execute the SQL ;D
                    sqlite_cmd.ExecuteNonQuery();


                    for (int i = 1; i <= rowCount; i++) {
                        for (int j = 1; j <= colCount; j++) {
                            //MessageBox.Show(workSheet.Cells[i, j].Value.ToString());

                        }

                        // Lets insert something into our new table:
                        sqlite_cmd.CommandText = "INSERT INTO test (id, text) VALUES (1, 'Test Text 1');";                  

                        // And execute this again ;D
                        sqlite_cmd.ExecuteNonQuery();
                    }


                    // We are ready, now lets cleanup and close our connection:
                    cn.Close();

                    workBook.DisposeChildInstances();
                    workBook = null;
                    excelApplication.Quit();
                    excelApplication.Dispose();
                    excelApplication = null;
                }

                    //save to database

                    return response;
            }
            finally {
                response = null;
            }
        }

        public LoginResponse Login(LoginRequest request) {
            LoginResponse response = null;

            try {
                response = new LoginResponse();

                if (request.UserName == "sysad") {  
                    response.IsLoginValid = true;
                    response.IsAdmin = true;
                    response.AccessLevel = 0;
                }

                return response;
            }
            finally {
                response = null;
            }
        }

        public SelectBuildingDataRecordResponse SelectBuildingDataRecord(SelectBuildingDataRecordRequest request) {
            SelectBuildingDataRecordResponse response = null;

            try {
                response = new SelectBuildingDataRecordResponse();

                return response;
            }
            finally {
                response = null;
            }
        }
    }
}
