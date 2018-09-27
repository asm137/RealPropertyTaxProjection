using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data;

using Excel = NetOffice.ExcelApi;
using System.Data.SQLite;

using Intangic.RPTP.Domain;
using Intangic.RPTP.Business.Interfaces;

namespace Intangic.RPTP.Business.Impl
{
    public class RealPropertyTaxProjectionManager : IRealPropertyTaxProjectionService
    {

        public LoadBuildingDataAssessorFileResponse LoadBuildingDataAssessorFile(LoadBuildingDataAssessorFileRequest request) {
            LoadBuildingDataAssessorFileResponse response = null;

            try {
                response = new LoadBuildingDataAssessorFileResponse();
                if (File.Exists(request.SourceFilePath)) {
                    DataTable dt = new DataTable();
                    dt.TableName = Path.GetFileNameWithoutExtension(request.SourceFilePath);
                    dt.ReadXml(request.SourceFilePath);

                    response.DataSource = new DataSet();
                    response.DataSource.Tables.Add(dt);
                    response.DataSource.AcceptChanges();
                }

                return response;
            }
            finally {
                response = null;
            }
        }
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
            DataSet ds = null;

            try {
                response = new ImportBuildingDataFileResponse();

                //read file from excel, using NetOffice
                Excel.Application excelApplication = null;

                
                using (excelApplication = new Excel.Application()) {
                    Excel.Workbook workBook = excelApplication.Workbooks.Open(request.SourceFilePath,
                        0, true, 5, "", "", true, null, "\t", false, false, 0, true, 1, 0);
                    Excel.Worksheet workSheet = (Excel.Worksheet)workBook.Sheets[1];
                    Excel.Range excelRange = workSheet.UsedRange;
                    int rowCount = excelRange.Rows.Count;
                    int colCount = excelRange.Columns.Count;

                    //System.Data.SQLite.SQLiteConnection cn = new SQLiteConnection(@"Data Source=C:\sqlite\test.db;Version=3;New=True;Compress=True;");
                    //SQLiteCommand sqlite_cmd;
                    //SQLiteDataReader sqlite_datareader;

                    //// open the connection:
                    //cn.Open();

                    //// create a new SQL command:
                    //sqlite_cmd = cn.CreateCommand();

                    //// Let the SQLiteCommand object know our SQL-Query:
                    //sqlite_cmd.CommandText = "CREATE TABLE hello (id integer primary key, text varchar(100));";

                    //// Now lets execute the SQL ;D
                    //sqlite_cmd.ExecuteNonQuery();

                    ds = new DataSet();
                    ds.Tables.Add("Source");
                    ds.AcceptChanges();

                    BuildingDataAssessor record = null;
                    for (int i = 1; i <= rowCount; i++) {
                        record = new BuildingDataAssessor();
                        for (int j = 1; j <= colCount; j++) {
                            //MessageBox.Show(workSheet.Cells[i, j].Value.ToString());
                            switch (j) {
                                case 1:
                                    record.Owner = workSheet.Cells[i, j].Value.ToString();
                                    break;
                                case 2:
                                    record.BuildingLocation = workSheet.Cells[i, j].Value.ToString();
                                    break;
                                case 3:
                                    record.LandArea = Convert.ToDouble(workSheet.Cells[i, j].Value.ToString());
                                    break;
                                case 4:
                                    record.BuildingType = workSheet.Cells[i, j].Value.ToString();
                                    break;
                                case 5:
                                    record.DateContructed = Convert.ToDateTime(workSheet.Cells[i, j].Value.ToString());
                                    break;
                                case 6:
                                    record.BuildingCost = Convert.ToDouble(workSheet.Cells[i, j].Value.ToString());
                                    break;
                            }
                        }

                        //DataRow newRow = ds.Tables[0].NewRow();
                        ds.Tables[0].Rows.Add(new object[] {
                            record.Owner,
                            record.BuildingLocation,
                            record.LandArea,
                            record.BuildingType,
                            record.DateContructed, 
                            record.BuildingCost
                        });
                        //newRow[0] = record.Owner;

                        ds.AcceptChanges();
                        


                    //    // Lets insert something into our new table:
                    //    sqlite_cmd.CommandText = "INSERT INTO test (id, text) VALUES (1, 'Test Text 1');";                  

                    //    // And execute this again ;D
                    //    sqlite_cmd.ExecuteNonQuery();
                    }


                    //// We are ready, now lets cleanup and close our connection:
                    //cn.Close();
                    //ds.
                    ds.WriteXml(request.SourceDataPath);


                    workBook.DisposeChildInstances();
                    workBook = null;
                    excelApplication.Quit();
                    //excelApplication.Dispose();
                    //excelApplication = null;
                }

                //save to database


                return response;
            }
            finally {
                response = null;
                ds = null;
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

        public ExportBuildingDataAssessorFileResponse ExportBuildingDataAssessorFile(ExportBuildingDataAssessorFileRequest request) {
            ExportBuildingDataAssessorFileResponse response = null;
            Excel.Application excelApplication = null;

            try {
                //Directory.CreateDirectory(Path.GetDirectoryName(request.DataFilePath));
                response = new ExportBuildingDataAssessorFileResponse();
                
                //write to excel
                using (excelApplication = new Excel.Application()) {
                    excelApplication.DisplayAlerts = false;
                    Excel.Workbook workBook = excelApplication.Workbooks.Add(); 
                    Excel.Worksheet workSheet = (Excel.Worksheet)workBook.Sheets[1];

                    workSheet.Name = string.Format("{0} {1}","BldgData Assessor", DateTime.Now.ToString("yyyyMMdd"));

                    int counter = 0;
                    foreach (BuildingDataAssessor buildingDataAssessor in request.BuildingDataAssessors) {
                        counter++;
                        if (counter.Equals(1)) {
                            //add headers
                            continue;
                        }

                        //TODO: add column fields from incoming file
                        //add details
                        workSheet.Cells[counter, 1].Value = "hello 33";
                        workSheet.Cells[counter, 2].Value = "world";
                    }
                    
                    //save excel
                    workBook.SaveAs(request.SourceFilePath);

                    //quit excel
                    excelApplication.Quit();
                }

                //set result
                if (File.Exists(request.SourceFilePath)) {
                    response.Result = new Result() {
                        IsSuccess = true,
                        Message = string.Format("{0}\n{1}", 
                            "The data is exported successfully at the following path:",
                            request.SourceFilePath) };
                }
                else {
                    response.Result = new Result() {
                        IsSuccess = false,
                        Message = string.Format("{0}\n{1}", 
                            "Fail in exporting data to:",
                            request.SourceFilePath) };
                }

                return response;
            }
            finally {
                response = null;

                if (excelApplication != null)
                    excelApplication.Dispose();
                excelApplication = null;
            }
        }

        
        public LoadBuildingTypeSettingResponse LoadBuildingTypeSetting(LoadBuildingTypeSettingRequest request) {
            LoadBuildingTypeSettingResponse response = null;

            try {
                response = new LoadBuildingTypeSettingResponse();
                DataTable dt = new DataTable();
                dt.TableName = Path.GetFileNameWithoutExtension(request.SourceFilePath);

                if (File.Exists(request.SourceFilePath)) {    
                    dt.ReadXml(request.SourceFilePath);
                }
                else {
                    dt.Columns.Add("BuildingType", typeof(System.String));
                    dt.Columns.Add("UnitValueFrom", typeof(System.Decimal));
                    dt.Columns.Add("UnitValueTo", typeof(System.Decimal));
                    dt.AcceptChanges();
                }

                response.DataSource = new DataSet();
                response.DataSource.Tables.Add(dt);
                response.DataSource.AcceptChanges();
                response.Result.IsSuccess = true;

                return response;
            }
            finally {
                response = null;
            }
        }

        public SaveBuildingTypeSettingResponse SaveBuildingTypeSetting(SaveBuildingTypeSettingRequest request) {
            SaveBuildingTypeSettingResponse response = null;

            try {
                Directory.CreateDirectory(Path.GetDirectoryName(request.DataFilePath));
                response = new SaveBuildingTypeSettingResponse();

                if (request.IsAddRecord) {
                    DataRow newrow = request.DataSource.Tables[0].NewRow();
                    newrow[0] = request.BuildingAssessorTypeSetting.BuildingType;
                    newrow[1] = request.BuildingAssessorTypeSetting.UnitValueFrom;
                    newrow[2] = request.BuildingAssessorTypeSetting.UnitValueTo;
                    request.DataSource.Tables[0].Rows.Add(newrow);
                    request.DataSource.AcceptChanges();
                }
                else if (request.IsDeleteRecord.Equals(false) && request.IsAddRecord.Equals(false)) {
                    request.DataSource.Tables[0].Rows[request.RowIndex][0] = request.BuildingAssessorTypeSetting.BuildingType;
                    request.DataSource.Tables[0].Rows[request.RowIndex][1] = request.BuildingAssessorTypeSetting.UnitValueFrom;
                    request.DataSource.Tables[0].Rows[request.RowIndex][2] = request.BuildingAssessorTypeSetting.UnitValueTo;
                    request.DataSource.AcceptChanges();
                }
                else if (request.IsDeleteRecord) {
                    request.DataSource.Tables[0].Rows.RemoveAt(request.RowIndex);
                    request.DataSource.AcceptChanges();
                }

                //save the changes
                request.DataSource.WriteXml(request.DataFilePath, XmlWriteMode.WriteSchema);

                //load the datasource
                DataSet ds = new DataSet();
                ds.ReadXml(request.DataFilePath);
                response.DataSource = ds;
                response.Result.IsSuccess = true;
                response.Result.Message = "Record list modification success.";
                return response;
            }
            finally {
                response = null;
            }
        }
    }
}
