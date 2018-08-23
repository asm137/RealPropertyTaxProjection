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
    public partial class frmLogin : Form
    {
        public IRealPropertyTaxProjectionService realPropertyTaxProjectionManager;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginRequest request = null;
            LoginResponse response = null;

            request = new LoginRequest() {
                UserName = this.userName.Text,
                Password = this.password.Text };

            try {
                realPropertyTaxProjectionManager = BusinessDelegateFactory.GetInstance().GetRealPropertyTaxProjectionService();
                
                response = new LoginResponse();
                response = realPropertyTaxProjectionManager.Login(request); 
                if (response.IsLoginValid) {
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (RealPropertyTaxProjectionException ex) {
                FormHelper.MessageShow(ex.Message);
                this.userName.Focus();
            }
            catch (Exception ex) {
                FormHelper.MessageShow(ex.Message);
                this.userName.Focus();
            }
            finally {
                realPropertyTaxProjectionManager = null;
                response = null;
                request = null;
            }
        }
    }
}
