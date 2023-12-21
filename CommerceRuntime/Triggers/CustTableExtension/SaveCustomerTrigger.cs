using Microsoft.Dynamics.Commerce.Runtime.Messages;
using Microsoft.Dynamics.Commerce.Runtime.RealtimeServices.Messages;
using Microsoft.Dynamics.Commerce.Runtime.Services.Messages;
using Microsoft.Dynamics.Commerce.Runtime;
using SRF.CommerceRuntime.Entities;
using SRF.CommerceRuntime.Messages.CustTableExtension;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System;

namespace CommerceRuntime.Triggers.CustTable
{
    class SaveCustomerTrigger : IRequestTriggerAsync
    {
        private const string IncludeExtensionPropertiesInGetCustomerKey = "ExtensionPropertiesSaveCustomer";
        public IEnumerable<Type> SupportedRequestTypes
        {
            get
            {
                return new[] { typeof(SaveCustomerServiceRequest) };
            }
        }

        public async Task OnExecuted(Request request, Response response)
        {
            ThrowIf.Null(request, "request");
            ThrowIf.Null(response, "response");
            if (request is SaveCustomerServiceRequest)
            {
                await HandleOnExecuted(request as SaveCustomerServiceRequest, response as SaveCustomerServiceResponse).ConfigureAwait(false);
            }
            else
            {
                throw new NotSupportedException($"Request '{request.GetType()}' is not supported.");
            }
        }

        private async Task HandleOnExecuted(SaveCustomerServiceRequest saveCustomerServiceRequest, SaveCustomerServiceResponse response)
        {
            ThrowIf.Null(saveCustomerServiceRequest, "saveCustomerServiceRequest");
            ThrowIf.Null(response, "response");

            var context = saveCustomerServiceRequest.RequestContext;
            CustTableExtensionEntity custExt = GetCustExt(saveCustomerServiceRequest.CustomerToSave, context.GetChannelConfiguration().InventLocationDataAreaId);
            UpdateCustTableExtensionDataRequest insertRequest = new UpdateCustTableExtensionDataRequest(custExt.UnusualEntityId, custExt);

            await context.Runtime.ExecuteAsync<UpdateCustTableExtensionDataResponse>(insertRequest, context).ConfigureAwait(false);

            if (context.Runtime.Configuration.IsMasterDatabaseConnectionString)
            {
                InvokeExtensionMethodRealtimeRequest extensionRequest = new InvokeExtensionMethodRealtimeRequest("UpdateCustTableLATCOFields",
                                                                                                                    custExt.AccountNum,
                                                                                                                    custExt.LATCOActivityCIIUId,
                                                                                                                    custExt.LATCOContributorType,
                                                                                                                    custExt.LATCOObligationCode,
                                                                                                                    custExt.LATCODocumentType,
                                                                                                                    custExt.LATCOIvaRegime
                                                                                                                );
                InvokeExtensionMethodRealtimeResponse responseService = await saveCustomerServiceRequest.RequestContext.ExecuteAsync<InvokeExtensionMethodRealtimeResponse>(extensionRequest).ConfigureAwait(false);
                ReadOnlyCollection<object> results = responseService.Result;
                string resValue = (string)results[0];
            }
        }

        public async Task OnExecuting(Request request)
        {
            // It's only stub to handle async signature  
            //if (request is SaveCustomerServiceRequest)
            //{
            //    await this.OnExecuting(request as SaveCustomerServiceRequest).ConfigureAwait(false);
            //}
            await Task.CompletedTask.ConfigureAwait(false);
            //  return Task.CompletedTask;
        }

        private CustTableExtensionEntity GetCustExt(Microsoft.Dynamics.Commerce.Runtime.DataModel.Customer updatedCustomer, string inventLocationDataAreaId)
        {
            CustTableExtensionEntity custExt = new CustTableExtensionEntity();
            custExt.UnusualEntityId = 1;
            custExt.AccountNum = updatedCustomer.AccountNumber;
            custExt.LATCODocumentType = (string)updatedCustomer.GetProperty(nameof(custExt.LATCODocumentType));
            custExt.LATCOContributorType = (string)updatedCustomer.GetProperty(nameof(custExt.LATCOContributorType));
            custExt.LATCOActivityCIIUId = (string)updatedCustomer.GetProperty(nameof(custExt.LATCOActivityCIIUId));
            custExt.LATCOIvaRegime = (string)updatedCustomer.GetProperty(nameof(custExt.LATCOIvaRegime));
            custExt.LATCOObligationCode = (string)updatedCustomer.GetProperty(nameof(custExt.LATCOObligationCode));
            custExt.IDENTIFICATIONNUMBER = (string)updatedCustomer.GetProperty(nameof(custExt.IDENTIFICATIONNUMBER));
            custExt.DataAreaId = inventLocationDataAreaId;
            return custExt;
        }
    }
}
