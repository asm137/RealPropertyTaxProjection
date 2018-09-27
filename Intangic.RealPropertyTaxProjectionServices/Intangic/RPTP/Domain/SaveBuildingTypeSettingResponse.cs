using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;


namespace Intangic.RPTP.Domain
{
    public class SaveBuildingTypeSettingResponse
    {
        public Result Result { get; set; }
        public DataSet DataSource { get; set; }

        public SaveBuildingTypeSettingResponse()
        {
            this.Result = new Result();
            this.DataSource = null;
        }

    }
}
