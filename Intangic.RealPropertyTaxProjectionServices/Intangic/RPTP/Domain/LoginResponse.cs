using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intangic.RPTP.Domain
{
    public class LoginResponse
    {
        public bool IsLoginValid { get; set; }
        public bool IsAdmin { get; set; }
        public int AccessLevel { get; set; }
        public Result Result { get; set; }

        public LoginResponse()
        {
            this.IsLoginValid = false;
            this.IsAdmin = false;
            this.AccessLevel = -1;
            this.Result = null;
        }
    }
}
