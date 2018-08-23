using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RealPropertyTaxProjection;
using Intangic.RPTP.Business.Interfaces;

namespace Intangic.RPTP.Business.Impl
{
    public class FormSwitcher : IFormSwitcher
    {
        public Form CurrentForm { get; set; }
        public Form PreviousForm { get; set; }
        public Stack<Form> FormStack { get; set; }

        public frmLogin MainForm { get; set; }
        
        public FormSwitcher() {
            FormStack = new Stack<Form>();
        }

        public void Next(Form currentForm = null, Form nextForm = null) {
            if (currentForm == null) {
                FormStack.Push(this.MainForm);
            }
            else {
                FormStack.Push((Form)nextForm);
                currentForm.Hide();

                if (nextForm.Name.Equals("frmImportFile")) {
                    nextForm.Show();
                    var newForm = (frmImportFile)nextForm;
                    newForm.realPropertyTaxProjectionManager = this.MainForm.realPropertyTaxProjectionManager;
                    //newForm.realPropertyTaxProjectionManager.FormSwitch.M
                    //newForm.realPropertyTaxProjectionManager.FormSwitch = this.MainForm.realPropertyTaxProjectionManager.FormSwitch;
                }
            }
        }

        public void Previous(Form currentForm, int returnAttempts = 1) {
            Form currentStackedForm = null;
            int counter = 1;
            do {
                currentStackedForm = FormStack.Pop();
                counter++;
            } while (counter <= returnAttempts);

            if (FormStack.Count.Equals(0)) {
                MainForm.Close();
            }

            if (currentForm.Name.Equals("frmImportFile")) {
                //currentForm.Show();
                MainForm.realPropertyTaxProjectionManager.FormSwitch = ((frmImportFile)currentForm).realPropertyTaxProjectionManager.FormSwitch;
            }
            
            currentForm.Dispose(); //close the current form
            currentStackedForm = FormStack.Peek();
            currentStackedForm.Show();
        }
    }
}
