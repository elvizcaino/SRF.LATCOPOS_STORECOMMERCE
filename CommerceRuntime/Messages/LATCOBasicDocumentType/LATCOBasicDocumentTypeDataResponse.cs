using Microsoft.Dynamics.Commerce.Runtime.Messages;
using Microsoft.Dynamics.Commerce.Runtime;
using SRF.CommerceRuntime.Entities;
using System.Runtime.Serialization;

namespace SRF.CommerceRuntime.Messages.LATCOBasicDocumentType
{
    [DataContract]
    public sealed class LATCOBasicDocumentTypeDataResponse : Response
    {
        public LATCOBasicDocumentTypeDataResponse(PagedResult<LATCOBasicDocumentTypeEntity> entity)
        {
            this.LATCOBasicDocumentTypeEntity = entity;
        }

        [DataMember]
        public PagedResult<LATCOBasicDocumentTypeEntity> LATCOBasicDocumentTypeEntity { get; private set; }
    }
}
