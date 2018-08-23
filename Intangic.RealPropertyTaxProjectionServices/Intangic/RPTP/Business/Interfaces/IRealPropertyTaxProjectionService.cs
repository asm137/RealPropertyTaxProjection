using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Intangic.RPTP.Domain;

namespace Intangic.RPTP.Business.Interfaces
{
    public interface IRealPropertyTaxProjectionService
    {
        LoginResponse Login(LoginRequest request);

        ImportBuildingDataFileResponse ImportBuildingDataFile(ImportBuildingDataFileRequest request);

        SelectBuildingDataRecordResponse SelectBuildingDataRecord(SelectBuildingDataRecordRequest request);

        ComputeEquivalentTaxResponse ComputeEquivalentTax(ComputeEquivalentTaxRequest request);
    }
}
