using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intangic.RPTP.Domain
{
    public class BuildingAssessorTypeSetting
    {
        public string BuildingType { get; set; }
        public decimal UnitValueFrom { get; set; }
        public decimal UnitValueTo { get; set; }

        public BuildingAssessorTypeSetting()
        {
            this.BuildingType = string.Empty;
            this.UnitValueFrom = 0;
            this.UnitValueTo = 0;
        }
    }
}
