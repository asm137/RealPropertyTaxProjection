using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intangic.RPTP.Domain
{
    public class ImportBuildingDataFileRequest
    {
        public string SourceFilePath { get; set; }
        public string SourceDataPath { get; set; }

        public ImportBuildingDataFileRequest()
        {
            this.SourceFilePath = string.Empty;
            this.SourceDataPath = string.Empty;
        }
    }
}
