using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intangic.RPTP.Domain
{
    public class ComputeEquivalentTaxRequest
    {
        //public List<BuildingDataAssessor> BuildingDataAssessors { get; set; }

        public decimal LandArea { get; set; }
        public decimal UnitValue { get; set; }
        public decimal AssessmentLevel { get; set; }
        public decimal TaxRate { get; set; }

        public ComputeEquivalentTaxRequest() {
            //this.BuildingDataAssessors = null;
            this.LandArea = 0;
            this.UnitValue = 0;
            this.AssessmentLevel = 0;
            this.TaxRate = 0;
        }
    }
}
