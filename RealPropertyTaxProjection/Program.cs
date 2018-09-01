using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Intangic.RPTP.Business.Interfaces;

namespace RealPropertyTaxProjection
{
    static class Program
    {
        public const string SKIP_KEYWORD = "[skip]";

        public static IRealPropertyTaxProjectionService realPropertyTaxProjectionManager;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmShowBuildingData());
        }
    }
}
