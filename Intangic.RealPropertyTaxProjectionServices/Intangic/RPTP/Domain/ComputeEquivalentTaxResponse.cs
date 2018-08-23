using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intangic.RPTP.Domain
{
    public class ComputeEquivalentTaxResponse
    {
        //public List<BuildingDataAssessor> BuildingDataAssessors { get; set; }

        public decimal MarketValue { get; set; }
        public decimal AssessmentLevel { get; set; }
        public decimal EquivalentTax { get; set; }

        public bool IsSuccess { get; set; }

        public ComputeEquivalentTaxResponse()
        {
            // this.BuildingDataAssessors = null;
            this.MarketValue = 0;
            this.AssessmentLevel = 0;
            this.EquivalentTax = 0;

            this.IsSuccess = false;
        }
    }
}
