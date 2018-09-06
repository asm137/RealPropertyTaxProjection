using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intangic.RPTP.Domain
{
    public class ImportBuildingDataFileResponse
    {
        public Result Result { get; set; }

        public ImportBuildingDataFileResponse()
        {
            this.Result = null;
        }
    }
}
