using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intangic.RPTP.Domain
{
    public class Result
    {
        public bool? IsSuccess { get; set; }
        public string Message { get; set; }

        public Result()
        {
            this.IsSuccess = null;
            this.Message = string.Empty;
        }
    }
}
