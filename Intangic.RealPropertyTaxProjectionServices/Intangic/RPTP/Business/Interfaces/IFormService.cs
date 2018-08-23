using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intangic.RPTP.Business.Interfaces
{
    public interface IFormSevice
    {
        //Form CurrentForm { get; set; }
        //Form PreviousForm { get; set; }
        //Stack<Form> FormStack { get; set; }
        Form MainForm { get; set; }
    }
}
