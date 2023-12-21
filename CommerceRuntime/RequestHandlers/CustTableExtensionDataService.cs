using Microsoft.Dynamics.Commerce.Runtime.DataAccess.SqlServer;
using Microsoft.Dynamics.Commerce.Runtime.Messages;
using Microsoft.Dynamics.Commerce.Runtime;
using SRF.CommerceRuntime.Messages.CustTableExtension;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace SRF.CommerceRuntime.RequestHandlers
{
    public class CustTableExtensionDataService : IRequestHandlerAsync
    {
        public IEnumerable<Type> SupportedRequestTypes
        {
            get
            {
                return new[]
                {
                    typeof(UpdateCustTableExtensionDataRequest),
                };
            }
        }

        public Task<Response> Execute(Request request)
        {
            ThrowIf.Null(request, nameof(request));

            switch (request)
            {
                case UpdateCustTableExtensionDataRequest updateCustTableExtensionEntityDataRequest:
                    return UpdateCustTableExtensionEntity(updateCustTableExtensionEntityDataRequest);
                default:
                    throw new NotSupportedException($"Request '{request.GetType()}' is not supported.");
            }
        }

        private static async Task<Response> UpdateCustTableExtensionEntity(UpdateCustTableExtensionDataRequest request)
        {
            ThrowIf.Null(request, nameof(request));
            ThrowIf.Null(request.UpdatedCustTableExtensionEntity, nameof(request.UpdatedCustTableExtensionEntity));

            if (request.RecIdEntityKey == 0)
            {
                throw new DataValidationException(DataValidationErrors.Microsoft_Dynamics_Commerce_Runtime_ValueOutOfRange, $"{nameof(request.RecIdEntityKey)} cannot be 0");
            }

            bool updateSuccess = false;

            using (var databaseContext = new SqlServerDatabaseContext(request.RequestContext))
            {
                ParameterSet parameters = new ParameterSet();

                //parameters["@RecId"] = request.RecIdEntityKey;
                parameters["@ACCOUNTNUM"] = request.UpdatedCustTableExtensionEntity.AccountNum;
                parameters["@LATCODOCUMENTTYPE"] = request.UpdatedCustTableExtensionEntity.LATCODocumentType;
                parameters["@LATCOCONTRIBUTORTYPE"] = request.UpdatedCustTableExtensionEntity.LATCOContributorType;
                parameters["@LATCOACTIVITYCIIUID"] = request.UpdatedCustTableExtensionEntity.LATCOActivityCIIUId;
                parameters["@LATCOIVAREGIME"] = request.UpdatedCustTableExtensionEntity.LATCOIvaRegime;
                parameters["@LATCOOBLIGATIONCODE"] = request.UpdatedCustTableExtensionEntity.LATCOObligationCode;
                parameters["@IDENTIFICATIONNUMBER"] = request.UpdatedCustTableExtensionEntity.IDENTIFICATIONNUMBER;
                parameters["@DATAAREAID"] = request.UpdatedCustTableExtensionEntity.DataAreaId;

                int sprocErrorCode = await databaseContext
                    .ExecuteStoredProcedureNonQueryAsync("[ext].[CustTableUpdate]", parameters, request.QueryResultSettings)
                    .ConfigureAwait(continueOnCapturedContext: false);

                updateSuccess = (sprocErrorCode == 0);
            }

            return new UpdateCustTableExtensionDataResponse(updateSuccess);
        }
    }
}
