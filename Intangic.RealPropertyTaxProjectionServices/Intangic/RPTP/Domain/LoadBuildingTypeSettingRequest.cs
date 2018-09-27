using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intangic.RPTP.Domain
{
    public class LoadBuildingTypeSettingRequest
    {
        public string SourceFilePath { get; set; }

        public LoadBuildingTypeSettingRequest()
        {
            this.SourceFilePath = string.Empty; 
        }
    }
}
