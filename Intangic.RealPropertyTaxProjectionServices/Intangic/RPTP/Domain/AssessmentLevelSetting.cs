using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intangic.RPTP.Domain
{
    public class AssessmentLevelSetting
    {
        public string AssessmentLevel { get; set; }
        public decimal MarketValueFrom { get; set; }
        public decimal MarketValueTo { get; set; }

        public AssessmentLevelSetting()
        {
            this.AssessmentLevel = string.Empty;
            this.MarketValueFrom = 0;
            this.MarketValueTo = 0;
        }
    }
}
