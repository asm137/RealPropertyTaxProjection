using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intangic.RPTP.Domain
{
    public class BuildingDataAssessor
    {

        public string Owner { get; set; }
        public string BuildingLocation { get; set; }
        public double LandArea { get; set; }
        public string BuildingType { get; set; }
        public DateTime? DateContructed { get; set; }
        public double BuildingCost { get; set; }

        public string BuildingTypeAssessor { get; set; }
        public double BuildingTypeAssessorUnitValue { get; set; }

        public double MarketValue { get; set; }
        public double AssessmentValue { get; set; }
        public double EquivalentTax { get; set; }

        public BuildingDataAssessor() {
            this.Owner = string.Empty;
            this.BuildingLocation = string.Empty;
            this.LandArea = 0.0;
            this.BuildingType = string.Empty;
            this.DateContructed = null;
            this.BuildingCost = 0.0;

            this.BuildingTypeAssessor = string.Empty;
            this.BuildingTypeAssessorUnitValue = 0.0;

            this.MarketValue = 0.0;
            this.AssessmentValue = 0.0;
            this.EquivalentTax = 0.0;
        }
    }
}
