using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Intangic.RPTP.Domain;

namespace Intangic.RPTP.Data.DAO.Interfaces
{
    public interface INetOfficeDAO
    {
        ImportBuildingDataFileDAOResponse ImportBuildingDataFile(ImportBuildingDataFileRequest request);

        //ExportBuildingDataAssessorFileResponse ExportBuildingDataAssessorFile(ExportBuildingDataAssessorFileRequest request);
    }
}
