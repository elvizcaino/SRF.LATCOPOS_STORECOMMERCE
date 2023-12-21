using Microsoft.Dynamics.Commerce.Runtime.Messages;
using System.Runtime.Serialization;

namespace SRF.CommerceRuntime.Messages.CustTableExtension
{
    [DataContract]
    public class UpdateCustTableExtensionDataResponse : Response
    {
        public UpdateCustTableExtensionDataResponse(bool success)
        {
            Success = success;
        }

        public bool Success { get; private set; }
    }
}
