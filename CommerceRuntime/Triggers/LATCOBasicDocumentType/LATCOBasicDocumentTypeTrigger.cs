using Microsoft.Dynamics.Commerce.Runtime.Messages;
using Microsoft.Dynamics.Commerce.Runtime;
using SRF.CommerceRuntime.Messages.LATCOBasicDocumentType;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.Dynamics.Commerce.Runtime.Data;
using Microsoft.Dynamics.Commerce.Runtime.DataModel;
using SRF.CommerceRuntime.Entities;

namespace SRF.CommerceRuntime.Triggers.LATCOBasicDocumentType
{
    public class LATCOBasicDocumentTypeTrigger : IRequestTriggerAsync
    {
        private const string IncludeExtensionPropertiesInGetCustomerKey = "ExtensionPropertiesGetCustomer";
        //private const string CheckDigitCalPropName = "CheckDigitCal";
        private const string DescriptionPropName = "Description";
        //private const string DocumentCodPropName = "DocumentCod";
        private const string DocumentIdPropName = "DocumentId";
        //private const string PlainTextDocumentTypePropName = "PlainTextDocumentType";
        //private const string IsAlphanumericPropName = "IsAlphanumeric";
        //private const string CampLongPropName = "CampLong";
        //private const string ItauPropName = "Itau";
        //private const string DaviviendaPropName = "Davivienda";
        //private const string BancoBogotaPropName = "BancoBogota";
        //private const string ForeignDocumentPropName = "ForeignDocument";
        //private const string DocumentCodREPropName = "DocumentCodRE";

        public IEnumerable<Type> SupportedRequestTypes
        {
            get
            {
                return new[] { typeof(LATCOBasicDocumentTypeDataRequest) };
            }
        }

        public async Task OnExecuted(Request request, Response response)
        {
            ThrowIf.Null(request, "request");
            ThrowIf.Null(response, "response");

            if (request is LATCOBasicDocumentTypeDataRequest)
            {
                await HandleOnExecuted(request as LATCOBasicDocumentTypeDataRequest, response as LATCOBasicDocumentTypeDataResponse).ConfigureAwait(false);
            }
        }

        public async Task OnExecuting(Request request)
        {
            // It's only stub to handle async signature 
            await Task.CompletedTask.ConfigureAwait(false);
        }

        private static async Task HandleOnExecuted(LATCOBasicDocumentTypeDataRequest request, LATCOBasicDocumentTypeDataResponse response)
        {
            /*var query = new SqlPagedQuery(QueryResultSettings.SingleRecord)
            {
                DatabaseSchema = "ext",
                Select = new ColumnSet(new string[] { "DocumentId", "Description" }),
                From = "LATCOBasicDocumentType",
            };

            using (var databaseContext = new DatabaseContext(request.RequestContext))
            {
                var extensionsResponse = await databaseContext.ReadEntityAsync<LATCOBasicDocumentTypeEntity>(query).ConfigureAwait(false);


                var extensions = extensionsResponse.FirstOrDefault();
                var properties = extensions?.GetProperties();
                if (properties != null)
                {
                    var documentId = properties[DocumentIdPropName];
                    var description = properties[DescriptionPropName];

                }
            }*/
        }
    }
}
