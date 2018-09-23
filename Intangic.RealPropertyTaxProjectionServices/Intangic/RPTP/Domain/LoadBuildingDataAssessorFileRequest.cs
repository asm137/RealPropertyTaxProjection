using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intangic.RPTP.Domain
{
    public class LoadBuildingDataAssessorFileRequest
    {
        public string SourceFilePath { get; set; }

        public LoadBuildingDataAssessorFileRequest()
        {
            this.SourceFilePath = string.Empty; 
        }
    }
}
