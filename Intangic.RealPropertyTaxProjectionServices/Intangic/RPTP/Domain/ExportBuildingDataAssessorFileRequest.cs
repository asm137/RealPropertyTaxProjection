using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intangic.RPTP.Domain
{
    public class ExportBuildingDataAssessorFileRequest
    {
        public string SourceFilePath { get; set; }
        public List<BuildingDataAssessor> BuildingDataAssessors { get; set; }

        public ExportBuildingDataAssessorFileRequest()
        {
            this.SourceFilePath = string.Empty;
            this.BuildingDataAssessors = null;
        }
    }
}
