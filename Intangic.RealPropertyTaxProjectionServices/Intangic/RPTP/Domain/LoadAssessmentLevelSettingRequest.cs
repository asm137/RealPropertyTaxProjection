using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intangic.RPTP.Domain
{
    public class LoadAssessmentLevelSettingRequest
    {
        public string SourceFilePath { get; set; }

        public LoadAssessmentLevelSettingRequest()
        {
            this.SourceFilePath = string.Empty; 
        }
    }
}
