using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace Intangic.Utils
{
    public class ConfigurationHelper
    {
        public static string GetString(string key) {
            string value = string.Empty;
            try {
                value = ConfigurationManager.AppSettings[key];
            }
            catch (Exception) {
                //do nothing
            }
            return value;
        }
    }
}
