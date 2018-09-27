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
        LoadBuildingDataAssessorFileResponse LoadBuildingDataAssessorFile(LoadBuildingDataAssessorFileRequest request);

        LoginResponse Login(LoginRequest request);

        ImportBuildingDataFileResponse ImportBuildingDataFile(ImportBuildingDataFileRequest request);

        SelectBuildingDataRecordResponse SelectBuildingDataRecord(SelectBuildingDataRecordRequest request);

        ComputeEquivalentTaxResponse ComputeEquivalentTax(ComputeEquivalentTaxRequest request);

        ExportBuildingDataAssessorFileResponse ExportBuildingDataAssessorFile(ExportBuildingDataAssessorFileRequest request);

        SaveBuildingTypeSettingResponse SaveBuildingTypeSetting(SaveBuildingTypeSettingRequest request);

        LoadBuildingTypeSettingResponse LoadBuildingTypeSetting(LoadBuildingTypeSettingRequest request);
    }
}
