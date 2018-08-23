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
        IRealPropertyTaxProjectionService realPropertyTaxProjectionManager;

        public frmShowBuildingData()
        {
            InitializeComponent();
            realPropertyTaxProjectionManager = null;
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
    }
}
