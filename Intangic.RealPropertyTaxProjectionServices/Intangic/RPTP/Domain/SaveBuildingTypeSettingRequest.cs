using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;


namespace Intangic.RPTP.Domain
{
    public class SaveBuildingTypeSettingRequest
    {
        public BuildingAssessorTypeSetting BuildingAssessorTypeSetting { get; set; }
        public DataSet DataSource { get; set; }
        public string DataFilePath { get; set; }

        public bool IsAddRecord { get; set; }
        public bool IsDeleteRecord { get; set; }
        public int RowIndex { get; set; }

        public SaveBuildingTypeSettingRequest()
        {
            this.BuildingAssessorTypeSetting = null;
            this.DataSource = null;
            this.DataFilePath = string.Empty;

            this.IsAddRecord = false;
            this.IsDeleteRecord = false;
            this.RowIndex = 0;
        }
    }
}
