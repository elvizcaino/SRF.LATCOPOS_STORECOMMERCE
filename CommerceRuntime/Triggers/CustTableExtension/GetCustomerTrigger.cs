using Microsoft.Dynamics.Commerce.Runtime.Data;
using Microsoft.Dynamics.Commerce.Runtime.DataModel;
using Microsoft.Dynamics.Commerce.Runtime.Messages;
using Microsoft.Dynamics.Commerce.Runtime.Services.Messages;
using Microsoft.Dynamics.Commerce.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace SRF.CommerceRuntime.Triggers.CustTableExtension
{
    public class GetCustomerTrigger : IRequestTriggerAsync
    {
        private const string IncludeExtensionPropertiesInGetCustomerKey = "ExtensionPropertiesGetCustomer";
        private const string LATCODocumentTypePropertyName = "LATCODOCUMENTTYPE";
        private const string LATCOContributorTypePropertyName = "LATCOCONTRIBUTORTYPE";
        private const string LATCOActivityCIIUIdPropertyName = "LATCOACTIVITYCIIUID";
        private const string LATCOIvaRegimePropertyName = "LATCOIVAREGIME";
        private const string LATCOObligationCodePropertyName = "LATCOOBLIGATIONCODE";
        private const string IDENTIFICATIONNUMBERPropertyName = "IDENTIFICATIONNUMBER";

        public IEnumerable<Type> SupportedRequestTypes
        {
            get
            {
                return new[] { typeof(GetCustomersServiceRequest) };
            }
        }

        public async Task OnExecuted(Request request, Response response)
        {
            if (request is GetCustomersServiceRequest)
            {
                await HandleOnExecuted(request as GetCustomersServiceRequest, response as GetCustomersServiceResponse).ConfigureAwait(false);
            }
        }

        public async Task OnExecuting(Request request)
        {
            // It's only stub to handle async signature 
            await Task.CompletedTask.ConfigureAwait(false);
        }

        private static async Task HandleOnExecuted(GetCustomersServiceRequest request, GetCustomersServiceResponse response)
        {
            var context = request.RequestContext;
            Customer cust = response.Customers.FirstOrDefault();

            var query = new SqlPagedQuery(QueryResultSettings.AllRecords)
            {
                DatabaseSchema = "ext",
                Select = new ColumnSet("[ACCOUNTNUM], [LATCODOCUMENTTYPE], [LATCOCONTRIBUTORTYPE], [LATCOACTIVITYCIIUID], [LATCOIVAREGIME], [LATCOOBLIGATIONCODE], [IDENTIFICATIONNUMBER], [DATAAREAID]"),
                From = "[CustTableView]",
                Where = "ACCOUNTNUM = @AccountNum AND DATAAREAID = @DataAreaId"
            };

            string accountNum = cust.AccountNumber;
            string dataAreaId = request.RequestContext.GetChannelConfiguration().InventLocationDataAreaId;

            query.Parameters["@AccountNum"] = accountNum;
            query.Parameters["@DataAreaId"] = dataAreaId;

            using (var databaseContext = new DatabaseContext(request.RequestContext))
            {
                PagedResult<ExtensionsEntity> extensions = await databaseContext.ReadEntityAsync<ExtensionsEntity>(query).ConfigureAwait(false);
                ExtensionsEntity extension = extensions.Results.FirstOrDefault(r => string.Equals(r.GetProperty("ACCOUNTNUM").ToString(), cust.AccountNumber, StringComparison.OrdinalIgnoreCase));
                if (extension != null)
                {
                    var properties = extension?.GetProperties();
                    var IDENTIFICATIONNUMBER = properties[IDENTIFICATIONNUMBERPropertyName];
                    var LATCODocumentType = properties[LATCODocumentTypePropertyName];
                    var LATCOContributorType = properties[LATCOContributorTypePropertyName];
                    var LATCOActivityCIIUId = properties[LATCOActivityCIIUIdPropertyName];
                    var LATCOIvaRegime = properties[LATCOIvaRegimePropertyName];
                    var LATCOObligationCode = properties[LATCOObligationCodePropertyName];

                    if (LATCODocumentType != null)
                    {
                        cust.SetProperty(LATCODocumentTypePropertyName, LATCODocumentType);
                    }
                    if (LATCOContributorType != null)
                    {
                        cust.SetProperty(LATCOContributorTypePropertyName, LATCOContributorType);
                    }
                    if (LATCOActivityCIIUId != null)
                    {
                        cust.SetProperty(LATCOActivityCIIUIdPropertyName, LATCOActivityCIIUId);
                    }
                    if (LATCOIvaRegime != null)
                    {
                        cust.SetProperty(LATCOIvaRegimePropertyName, LATCOIvaRegime);
                    }
                    if (LATCOObligationCode != null)
                    {
                        cust.SetProperty(LATCOObligationCodePropertyName, LATCOObligationCode);
                    }
                    if (IDENTIFICATIONNUMBER != null)
                    {
                        cust.SetProperty(IDENTIFICATIONNUMBERPropertyName, IDENTIFICATIONNUMBER);
                    }
                }
            }
        }
    }
}
