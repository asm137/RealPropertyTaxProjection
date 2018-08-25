using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Intangic.RPTP.Enumerations;

namespace Intangic.RPTP.Domain
{
    public class Result
    {
        public ResultResponse Code { get; set; }
        public string Description { get; set; }

        public Result()
        {
            this.Code = ResultResponse.UnSet;
            this.Description = string.Empty;
        }
    }
}
