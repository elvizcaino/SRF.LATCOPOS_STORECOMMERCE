using System.Runtime.Serialization;
using SRF.CommerceRuntime.Entities;
using Microsoft.Dynamics.Commerce.Runtime.Messages;

namespace SRF.CommerceRuntime.Messages.CustTableExtension
{
    public class UpdateCustTableExtensionDataRequest: Request
    {
        public UpdateCustTableExtensionDataRequest(long entityKey, CustTableExtensionEntity updatedEntity)
        {
            RecIdEntityKey = entityKey;
            UpdatedCustTableExtensionEntity = updatedEntity;
        }

        public long RecIdEntityKey { get; private set; }

        [DataMember]
        public CustTableExtensionEntity UpdatedCustTableExtensionEntity { get; private set; }
    }
}
