using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Intangic.RPTP.Business.Exceptions;
using Intangic.RPTP.Business.Impl;
using Intangic.RPTP.Business.Interfaces;
using Intangic.RPTP.Domain;
using Intangic.RPTP.Factory;
using Intangic.Utils;

namespace RealPropertyTaxProjection
{
    public partial class frmShowBuildingData : Form
    {
        private List<BuildingDataAssessor> DataSource;

        public frmShowBuildingData()
        {
            InitializeComponent();
            Program.realPropertyTaxProjectionManager = null;
            this.DataSource = null;
        }

        private void dtgBuildingData_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            using (var newForm = new frmImportFile()) {
                this.Hide();
                newForm.Show();
            }
        }

        private void frmShowBuildingData_Load(object sender, EventArgs e)
        {
            var login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK) {
                login.Close();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            ExportBuildingDataAssessorFileRequest request = null;
            ExportBuildingDataAssessorFileResponse response = null;

            

            try {
                if (!(sfdExportData.ShowDialog() == DialogResult.OK)) {
                    throw new RealPropertyTaxProjectionException(Program.SKIP_KEYWORD);
                }

                request = new ExportBuildingDataAssessorFileRequest() {
                    SourceFilePath = this.sfdExportData.FileName, 
                    BuildingDataAssessors = this.DataSource };

                Program.realPropertyTaxProjectionManager = BusinessDelegateFactory.GetInstance().GetRealPropertyTaxProjectionService();
                response = Program.realPropertyTaxProjectionManager.ExportBuildingDataAssessorFile(request);
                if (response.Result.IsSuccess == true) {
                    FormHelper.MessageShow(response.Result.Message);
                }
            }
            catch (RealPropertyTaxProjectionException ex) {
                if (!ex.Message.Equals(Program.SKIP_KEYWORD)) {
                    FormHelper.MessageShow(ex.Message);
                }    
            }
            finally {
                Program.realPropertyTaxProjectionManager = null;
            }           
        }
    }
}
