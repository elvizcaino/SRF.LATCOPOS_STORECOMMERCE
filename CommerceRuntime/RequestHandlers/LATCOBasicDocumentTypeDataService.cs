using Microsoft.Dynamics.Commerce.Runtime.Data;
using Microsoft.Dynamics.Commerce.Runtime.Messages;
using Microsoft.Dynamics.Commerce.Runtime;
using SRF.CommerceRuntime.Entities;
using SRF.CommerceRuntime.Messages.LATCOBasicDocumentType;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using System;

namespace SRF.CommerceRuntime.RequestHandlers
{
    public class LATCOBasicDocumentTypeDataService : IRequestHandlerAsync
    {
        public IEnumerable<Type> SupportedRequestTypes
        {
            get
            {
                return new[]
                {
                    typeof(LATCOBasicDocumentTypeDataRequest),
                };
            }
        }

        public async Task<Response> Execute(Request request)
        {
            ThrowIf.Null(request, nameof(request));

            Type reqType = request.GetType();

            if (reqType == typeof(LATCOBasicDocumentTypeDataRequest))
            {
                return await this.GetLATCOBasicDocumentTypeEntities((LATCOBasicDocumentTypeDataRequest)request).ConfigureAwait(false);
            }
            else
            {
                string message = string.Format(CultureInfo.InvariantCulture, "Request '{0}' is not supported.", reqType);
                Console.WriteLine(message);
                throw new NotSupportedException(message);
            }
        }

        private async Task<Response> GetLATCOBasicDocumentTypeEntities(LATCOBasicDocumentTypeDataRequest request)
        {
            ThrowIf.Null(request, "request");

            using (DatabaseContext databaseContext = new DatabaseContext(request.RequestContext))
            {
                var query = new SqlPagedQuery(request.QueryResultSettings)
                {
                    DatabaseSchema = "ext",
                    Select = new ColumnSet("DocumentId", "Description"),
                    From = "LATCOBasicDocumentTypeView",
                };
                var queryResults = await databaseContext.ReadEntityAsync<LATCOBasicDocumentTypeEntity>(query).ConfigureAwait(continueOnCapturedContext: false);
                


                return new LATCOBasicDocumentTypeDataResponse(queryResults);

                /*System.Collections.ObjectModel.ReadOnlyCollection<LATCOBasicDocumentTypeEntity> lATCOBasicDocumentTypeEntity =
                    new System.Collections.ObjectModel.ReadOnlyCollection<LATCOBasicDocumentTypeEntity>(new LATCOBasicDocumentTypeEntity[]
                    {
                        new LATCOBasicDocumentTypeEntity() { DocumentId = "CC", Description = "Test" }
                    });

                PagedResult<LATCOBasicDocumentTypeEntity> data = new PagedResult<LATCOBasicDocumentTypeEntity>(lATCOBasicDocumentTypeEntity);


                return new LATCOBasicDocumentTypeDataResponse(data);*/
            }
        }
    }
}
