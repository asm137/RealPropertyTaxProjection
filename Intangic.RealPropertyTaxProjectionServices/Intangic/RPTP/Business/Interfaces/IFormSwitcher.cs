using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Intangic.RPTP.Business.Interfaces
{
    public interface IFormSwitcher
    {
        void Next(Form currentForm = null, Form nextForm = null);

        void Previous(Form currentForm, int returnAttempts = 1);
    }
}
