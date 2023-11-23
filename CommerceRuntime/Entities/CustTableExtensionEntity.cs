using Microsoft.Dynamics.Commerce.Runtime.ComponentModel.DataAnnotations;
using Microsoft.Dynamics.Commerce.Runtime.DataModel;
using System.Runtime.Serialization;
using SystemAnnotations = System.ComponentModel.DataAnnotations;

namespace SRF.CommerceRuntime.Entities
{
    public class CustTableExtensionEntity : CommerceEntity
    {
        private const string AccountNumColumn = "ACCOUNTNUM";
        private const string LATCODocumentTypeColumn = "LATCODOCUMENTTYPE";
        private const string IDENTIFICATIONNUMBERColumn = "IDENTIFICATIONNUMBER";
        private const string LATCOContributorTypeColumn = "LATCOCONTRIBUTORTYPE";
        private const string LATCOActivityCIIUIdColumn = "LATCOACTIVITYCIIUID";
        private const string LATCOIvaRegimeColumn = "LATCOIVAREGIME";
        private const string LATCOObligationCodeColumn = "LATCOOBLIGATIONCODE";
        private const string DataAreaIdColumn = "DATAAREAID";
        private const string RecIdColumn = "RECID";

        public CustTableExtensionEntity() : base("CustTableExtension") { }

        [DataMember]
        [Column(AccountNumColumn)]
        public string AccountNum
        {
            get { return (string)this[AccountNumColumn]; }
            set { this[AccountNumColumn] = value; }
        }

        [DataMember]
        [Column(LATCODocumentTypeColumn)]
        public string LATCODocumentType
        {
            get { return (string)this[LATCODocumentTypeColumn]; }
            set { this[LATCODocumentTypeColumn] = value; }
        }

        [DataMember]
        [Column(LATCOContributorTypeColumn)]
        public string LATCOContributorType
        {
            get { return (string)this[LATCOContributorTypeColumn]; }
            set { this[LATCOContributorTypeColumn] = value; }
        }

        [DataMember]
        [Column(LATCOActivityCIIUIdColumn)]
        public string LATCOActivityCIIUId
        {
            get { return (string)this[LATCOActivityCIIUIdColumn]; }
            set { this[LATCOActivityCIIUIdColumn] = value; }
        }

        [DataMember]
        [Column(LATCOIvaRegimeColumn)]
        public string LATCOIvaRegime
        {
            get { return (string)this[LATCOIvaRegimeColumn]; }
            set { this[LATCOIvaRegimeColumn] = value; }
        }

        [DataMember]
        [Column(LATCOObligationCodeColumn)]
        public string LATCOObligationCode
        {
            get { return (string)this[LATCOObligationCodeColumn]; }
            set { this[LATCOObligationCodeColumn] = value; }
        }

        [DataMember]
        [Column(IDENTIFICATIONNUMBERColumn)]
        public string IDENTIFICATIONNUMBER
        {
            get { return (string)this[IDENTIFICATIONNUMBERColumn]; }
            set { this[IDENTIFICATIONNUMBERColumn] = value; }
        }

        [DataMember]
        [Column(DataAreaIdColumn)]
        public string DataAreaId
        {
            get { return (string)this[DataAreaIdColumn]; }
            set { this[DataAreaIdColumn] = value; }
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <remarks>
        /// Fields named "Id" are automatically treated as the entity key.
        /// If a name other than Id is preferred, <see cref="SystemAnnotations.KeyAttribute"/>
        /// can be used like it is here to annotate a given field as the entity key.
        /// </remarks>
        [SystemAnnotations.Key]
        [DataMember]
        [Column(RecIdColumn)]
        public long UnusualEntityId
        {
            get { return (long)this[RecIdColumn]; }
            set { this[RecIdColumn] = value; }
        }
    }
}
