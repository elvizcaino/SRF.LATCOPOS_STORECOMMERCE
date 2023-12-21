using Microsoft.Dynamics.Commerce.Runtime.DataModel;
using Microsoft.Dynamics.Commerce.Runtime.Hosting.Contracts;
using Microsoft.Dynamics.Commerce.Runtime;
using SRF.CommerceRuntime.Messages.LATCOBasicDocumentType;
using System.Threading.Tasks;

namespace SRF.CommerceRuntime.Controllers.LATCOBasicDocumentType
{
    [RoutePrefix("LATCOBasicDocumentTypeController")]
    [BindEntity(typeof(Entities.LATCOBasicDocumentTypeEntity))]
    public class LATCOBasicDocumentTypeController : IController
    {
        [HttpGet]
        [Authorization(CommerceRoles.Anonymous, CommerceRoles.Application, CommerceRoles.Customer, CommerceRoles.Device, CommerceRoles.Employee, CommerceRoles.Storefront)]
        public async Task<PagedResult<Entities.LATCOBasicDocumentTypeEntity>> GetAllLATCOBasicDocumentType(IEndpointContext context)
        {
            var queryResultSettings = QueryResultSettings.SingleRecord;
            queryResultSettings.Paging = new PagingInfo(10);



            var request = new LATCOBasicDocumentTypeDataRequest() { QueryResultSettings = queryResultSettings };
            var response = await context.ExecuteAsync<LATCOBasicDocumentTypeDataResponse>(request).ConfigureAwait(false);
            return response.LATCOBasicDocumentTypeEntity;
           

            /*try
            {
                var queryResultSettings = QueryResultSettings.AllRecords;
                queryResultSettings.Paging = new PagingInfo(10);



                var request = new LATCOBasicDocumentTypeDataRequest() { QueryResultSettings = queryResultSettings };
                var response = await context.ExecuteAsync<LATCOBasicDocumentTypeDataResponse>(request).ConfigureAwait(false);
                return response.LATCOBasicDocumentTypeEntity;
            }
            catch (System.Exception ex)
            {
                System.Collections.ObjectModel.ReadOnlyCollection<Entities.LATCOBasicDocumentTypeEntity> lATCOBasicDocumentTypeEntity = 
                    new System.Collections.ObjectModel.ReadOnlyCollection<Entities.LATCOBasicDocumentTypeEntity>(new Entities.LATCOBasicDocumentTypeEntity[] 
                    { 
                        new Entities.LATCOBasicDocumentTypeEntity() { DocumentId = "CC", Description = ex.Message } 
                    });

                PagedResult<Entities.LATCOBasicDocumentTypeEntity> data = new PagedResult<Entities.LATCOBasicDocumentTypeEntity>(lATCOBasicDocumentTypeEntity);

                return data;
            }*/
        }
    }
}
