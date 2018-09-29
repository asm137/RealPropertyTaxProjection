using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;


namespace Intangic.Utils
{
    public class DataSetHelper
    {
        public DataSetHelper()
        {

        }

        public DataSet Reload(DataSet dataSource, string dataFilePath) {
            //save the changes
            dataSource.WriteXml(dataFilePath, XmlWriteMode.WriteSchema);

            //load the datasource
            DataSet ds = new DataSet();
            ds.ReadXml(dataFilePath);
            return ds;
        }
    }
}
