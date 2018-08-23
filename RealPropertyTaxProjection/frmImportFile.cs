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
    public partial class frmImportFile : Form
    {
        //public Form MainForm { get; set; }
        public IRealPropertyTaxProjectionService realPropertyTaxProjectionManager;

        public frmImportFile()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            //openFileDialog1
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                this.txtSourceFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnExtractFile_Click(object sender, EventArgs e)
        {
            ImportBuildingDataFileRequest request = null;
            ImportBuildingDataFileResponse response = null;

            request = new ImportBuildingDataFileRequest() {
                SourceFilePath = this.txtSourceFilePath.Text };

            try {
                realPropertyTaxProjectionManager = BusinessDelegateFactory.GetInstance().GetRealPropertyTaxProjectionService();
                response = realPropertyTaxProjectionManager.ImportBuildingDataFile(request);

                response = null;
            }
            catch (Exception ex) {
                FormHelper.MessageShow(ex.Message);
            }
            finally {
                response = null;
                request = null;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmImportFile_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.MainForm.Switch
            //realPropertyTaxProjectionManager.FormSwitch.Previous(this);

            using (var newForm = new frmShowBuildingData()) {
                newForm.Show();
                this.Dispose();
            }
            
        }
    }
}
