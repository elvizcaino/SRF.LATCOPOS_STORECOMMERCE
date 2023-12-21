using Microsoft.Dynamics.Commerce.Runtime.ComponentModel.DataAnnotations;
using Microsoft.Dynamics.Commerce.Runtime.DataModel;
using System.Runtime.Serialization;
using SystemAnnotations = System.ComponentModel.DataAnnotations;

namespace SRF.CommerceRuntime.Entities
{
    public class LATCOBasicDocumentTypeEntity : CommerceEntity
    {
        //private const string CheckDigitCalColumn = "CheckDigitCal";
        private const string DescriptionColumn = "Description";
       // private const string DocumentCodColumn = "DocumentCod";
        private const string DocumentIdColumn = "DocumentId";
       /* private const string PlainTextDocumentTypeColumn = "PlainTextDocumentType";
        private const string IsAlphanumericColumn = "IsAlphanumeric";
        private const string CampLongColumn = "CampLong";
        private const string ItauColumn = "Itau";
        private const string DaviviendaColumn = "Davivienda";
        private const string BancoBogotaColumn = "BancoBogota";
        private const string ForeignDocumentColumn = "ForeignDocument";
        private const string DocumentCodREColumn = "DocumentCodRE";*/
        //private const string DataAreaIdColumn = "DataAreaId";
        private const string RecIdColumn = "RecId";

        public LATCOBasicDocumentTypeEntity() : base("LATCOBasicDocumentType")
        {
        }

        /*[DataMember]
        [Column(CheckDigitCalColumn)]
        public int CheckDigitCal
        {
            get { return (int)this[CheckDigitCalColumn]; }
            set { this[CheckDigitCalColumn] = value; }
        }*/

        [DataMember]
        [Column(DescriptionColumn)]
        public string Description
        {
            get { return (string)this[DescriptionColumn]; }
            set { this[DescriptionColumn] = value; }
        }

        /*[DataMember]
        [Column(DocumentCodColumn)]
        public string DocumentCod
        {
            get { return (string)this[DocumentCodColumn]; }
            set { this[DocumentCodColumn] = value; }
        }*/

        [DataMember]
        [Column(DocumentIdColumn)]
        public string DocumentId
        {
            get { return (string)this[DocumentIdColumn]; }
            set { this[DocumentIdColumn] = value; }
        }

        /*[DataMember]
        [Column(PlainTextDocumentTypeColumn)]
        public string PlainTextDocumentType
        {
            get { return (string)this[PlainTextDocumentTypeColumn]; }
            set { this[PlainTextDocumentTypeColumn] = value; }
        }

        [DataMember]
        [Column(IsAlphanumericColumn)]
        public int IsAlphanumeric
        {
            get { return (int)this[IsAlphanumericColumn]; }
            set { this[IsAlphanumericColumn] = value; }
        }

        [DataMember]
        [Column(CampLongColumn)]
        public int CampLong
        {
            get { return (int)this[CampLongColumn]; }
            set { this[CampLongColumn] = value; }
        }

        [DataMember]
        [Column(ItauColumn)]
        public string Itau
        {
            get { return (string)this[ItauColumn]; }
            set { this[ItauColumn] = value; }
        }

        [DataMember]
        [Column(DaviviendaColumn)]
        public string Davivienda
        {
            get { return (string)this[DaviviendaColumn]; }
            set { this[DaviviendaColumn] = value; }
        }

        [DataMember]
        [Column(BancoBogotaColumn)]
        public string BancoBogota
        {
            get { return (string)this[BancoBogotaColumn]; }
            set { this[BancoBogotaColumn] = value; }
        }

        [DataMember]
        [Column(ForeignDocumentColumn)]
        public int ForeignDocument
        {
            get { return (int)this[ForeignDocumentColumn]; }
            set { this[ForeignDocumentColumn] = value; }
        }

        [DataMember]
        [Column(DocumentCodREColumn)]
        public string DocumentCodRE
        {
            get { return (string)this[DocumentCodREColumn]; }
            set { this[DocumentCodREColumn] = value; }
        }

        [DataMember]
        [Column(DataAreaIdColumn)]
        public string DataAreaId
        {
            get { return (string)this[DataAreaIdColumn]; }
            set { this[DataAreaIdColumn] = value; }
        }
        */

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
