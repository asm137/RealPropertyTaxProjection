﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Intangic.RPTP.Domain
{
    public class ImportBuildingDataFileResponse
    {
        public DataSet DataSource { get; set; }
        public Result Result { get; set; }

        public ImportBuildingDataFileResponse()
        {
            this.Result = null;
        }
    }
}
