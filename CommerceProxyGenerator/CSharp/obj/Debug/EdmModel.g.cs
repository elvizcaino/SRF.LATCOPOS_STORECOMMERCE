// <auto-generated />
  namespace Contoso.Commerce.RetailProxy.Extension
  {
  using System.CodeDom.Compiler;
  using System.IO;
  using System.Xml;

    /// <summary>
    /// Represents the EDM model.
    /// </summary>
    [GeneratedCodeAttribute("Contoso.Commerce.RetailProxy.Extension", "1.0")]
    public class EdmModel: Microsoft.Dynamics.Commerce.RetailProxy.IEdmModelExtension
    {
        private static string edmx = "<edmx:Edmx Version=\"4.0\" xmlns:edmx=\"http://docs.oasis-open.org/odata/ns/edmx\">\r\n" +
    "  <edmx:DataServices>\r\n    <Schema Namespace=\"Microsoft.Dynamics.Retail.RetailSe" +
    "rverLibrary\" xmlns=\"http://docs.oasis-open.org/odata/ns/edm\">\r\n      <Action Nam" +
    "e=\"CreateExampleEntity\" IsBound=\"true\">\r\n        <Parameter Name=\"bindingParamet" +
    "er\" Type=\"Collection(Contoso.CommerceRuntime.Entities.DataModel.ExampleEntity)\" " +
    "/>\r\n        <Parameter Name=\"entityData\" Type=\"Contoso.CommerceRuntime.Entities." +
    "DataModel.ExampleEntity\" />\r\n        <ReturnType Type=\"Edm.Int64\" Nullable=\"fals" +
    "e\" />\r\n      </Action>\r\n      <Action Name=\"UpdateExampleEntity\" IsBound=\"true\">" +
    "\r\n        <Parameter Name=\"bindingParameter\" Type=\"Contoso.CommerceRuntime.Entit" +
    "ies.DataModel.ExampleEntity\" />\r\n        <Parameter Name=\"updatedEntity\" Type=\"C" +
    "ontoso.CommerceRuntime.Entities.DataModel.ExampleEntity\" />\r\n        <ReturnType" +
    " Type=\"Edm.Boolean\" Nullable=\"false\" />\r\n      </Action>\r\n      <Action Name=\"De" +
    "leteExampleEntity\" IsBound=\"true\">\r\n        <Parameter Name=\"bindingParameter\" T" +
    "ype=\"Contoso.CommerceRuntime.Entities.DataModel.ExampleEntity\" />\r\n        <Retu" +
    "rnType Type=\"Edm.Boolean\" Nullable=\"false\" />\r\n      </Action>\r\n      <Function " +
    "Name=\"GetAllExampleEntities\" IsBound=\"true\">\r\n        <Parameter Name=\"bindingPa" +
    "rameter\" Type=\"Collection(Contoso.CommerceRuntime.Entities.DataModel.ExampleEnti" +
    "ty)\" />\r\n        <ReturnType Type=\"Collection(Contoso.CommerceRuntime.Entities.D" +
    "ataModel.ExampleEntity)\" />\r\n      </Function>\r\n      <Function Name=\"GetAllLATC" +
    "OBasicDocumentTypeEntities\" IsBound=\"true\">\r\n        <Parameter Name=\"bindingPar" +
    "ameter\" Type=\"Collection(Contoso.CommerceRuntime.Entities.LATCOBasicDocumentType" +
    "Entity)\" />\r\n        <ReturnType Type=\"Collection(Contoso.CommerceRuntime.Entiti" +
    "es.LATCOBasicDocumentTypeEntity)\" />\r\n      </Function>\r\n      <Action Name=\"Sim" +
    "plePingPost\">\r\n        <ReturnType Type=\"Edm.Boolean\" Nullable=\"false\" />\r\n     " +
    " </Action>\r\n      <Function Name=\"SimplePingGet\">\r\n        <ReturnType Type=\"Edm" +
    ".Boolean\" Nullable=\"false\" />\r\n      </Function>\r\n      <EntityContainer Name=\"C" +
    "ommerceContext\">\r\n        <EntitySet Name=\"BoundController\" EntityType=\"Contoso." +
    "CommerceRuntime.Entities.DataModel.ExampleEntity\" />\r\n        <EntitySet Name=\"L" +
    "ATCOBasicDocumentTypeBoundController\" EntityType=\"Contoso.CommerceRuntime.Entiti" +
    "es.LATCOBasicDocumentTypeEntity\" />\r\n        <ActionImport Name=\"SimplePingPost\"" +
    " Action=\"Microsoft.Dynamics.Retail.RetailServerLibrary.SimplePingPost\" />\r\n     " +
    "   <FunctionImport Name=\"SimplePingGet\" Function=\"Microsoft.Dynamics.Retail.Reta" +
    "ilServerLibrary.SimplePingGet\" IncludeInServiceDocument=\"true\" />\r\n      </Entit" +
    "yContainer>\r\n    </Schema>\r\n    <Schema Namespace=\"Contoso.CommerceRuntime.Entit" +
    "ies.DataModel\" xmlns=\"http://docs.oasis-open.org/odata/ns/edm\">\r\n      <EntityTy" +
    "pe Name=\"ExampleEntity\">\r\n        <Key>\r\n          <PropertyRef Name=\"UnusualEnt" +
    "ityId\" />\r\n        </Key>\r\n        <Property Name=\"IntData\" Type=\"Edm.Int32\" Nul" +
    "lable=\"false\" />\r\n        <Property Name=\"StringData\" Type=\"Edm.String\" />\r\n    " +
    "    <Property Name=\"UnusualEntityId\" Type=\"Edm.Int64\" Nullable=\"false\" />\r\n     " +
    "   <Property Name=\"ExtensionProperties\" Type=\"Collection(Microsoft.Dynamics.Comm" +
    "erce.Runtime.DataModel.CommerceProperty)\" />\r\n      </EntityType>\r\n    </Schema>" +
    "\r\n    <Schema Namespace=\"Contoso.CommerceRuntime.Entities\" xmlns=\"http://docs.oa" +
    "sis-open.org/odata/ns/edm\">\r\n      <EntityType Name=\"LATCOBasicDocumentTypeEntit" +
    "y\">\r\n        <Key>\r\n          <PropertyRef Name=\"UnusualEntityId\" />\r\n        </" +
    "Key>\r\n        <Property Name=\"CheckDigitCal\" Type=\"Edm.Int32\" Nullable=\"false\" /" +
    ">\r\n        <Property Name=\"Description\" Type=\"Edm.String\" />\r\n        <Property " +
    "Name=\"DocumentCod\" Type=\"Edm.String\" />\r\n        <Property Name=\"DocumentId\" Typ" +
    "e=\"Edm.String\" />\r\n        <Property Name=\"PlainTextDocumentType\" Type=\"Edm.Stri" +
    "ng\" />\r\n        <Property Name=\"IsAlphanumeric\" Type=\"Edm.Int32\" Nullable=\"false" +
    "\" />\r\n        <Property Name=\"CampLong\" Type=\"Edm.Int32\" Nullable=\"false\" />\r\n  " +
    "      <Property Name=\"Itau\" Type=\"Edm.String\" />\r\n        <Property Name=\"Davivi" +
    "enda\" Type=\"Edm.String\" />\r\n        <Property Name=\"BancoBogota\" Type=\"Edm.Strin" +
    "g\" />\r\n        <Property Name=\"ForeignDocument\" Type=\"Edm.Int32\" Nullable=\"false" +
    "\" />\r\n        <Property Name=\"DocumentCodRE\" Type=\"Edm.String\" />\r\n        <Prop" +
    "erty Name=\"DataAreaId\" Type=\"Edm.String\" />\r\n        <Property Name=\"UnusualEnti" +
    "tyId\" Type=\"Edm.Int64\" Nullable=\"false\" />\r\n        <Property Name=\"ExtensionPro" +
    "perties\" Type=\"Collection(Microsoft.Dynamics.Commerce.Runtime.DataModel.Commerce" +
    "Property)\" />\r\n      </EntityType>\r\n    </Schema>\r\n  </edmx:DataServices>\r\n</edm" +
    "x:Edmx>";
        private static string apiVersion = "7.3";
        private static System.Collections.Generic.Dictionary<System.Type, string> proxyTypeToRuntimeTypeNameMap = new System.Collections.Generic.Dictionary<System.Type, string>()
        {
        
            { typeof(Contoso.Commerce.RetailProxy.Extension.ExampleEntity), "Contoso.CommerceRuntime.Entities.DataModel.ExampleEntity" },
            { typeof(Contoso.Commerce.RetailProxy.Extension.LATCOBasicDocumentTypeEntity), "Contoso.CommerceRuntime.Entities.LATCOBasicDocumentTypeEntity" }
        };
        private static System.Collections.Generic.Dictionary<string, System.Type> runtimeTypeNameToProxyTypeMap = new System.Collections.Generic.Dictionary<string, System.Type>()
        {
        
            { "Contoso.CommerceRuntime.Entities.DataModel.ExampleEntity", typeof(Contoso.Commerce.RetailProxy.Extension.ExampleEntity) },
            { "Contoso.CommerceRuntime.Entities.LATCOBasicDocumentTypeEntity", typeof(Contoso.Commerce.RetailProxy.Extension.LATCOBasicDocumentTypeEntity) }
        };
        
        /// <summary>
        /// Gets the EDMX string.
        /// </summary>
        public string Edmx
        {
            get
            {
                return edmx;
            }
        }

        /// <summary>
        /// Gets the matched Retail Server API version.
        /// </summary>
        public string ApiVersion
        {
            get
            {
                return apiVersion;
            }
        }
        
        /// <summary>
        /// Gets the map from retail proxy type to commerce runtime type names.
        /// </summary>
        public System.Collections.Generic.Dictionary<System.Type, string> ProxyTypeToRuntimeTypeNameMap
        {
            get { return proxyTypeToRuntimeTypeNameMap; }
        }

        /// <summary>
        /// Gets the map from commerce runtime type names to retail proxy type.
        /// </summary>
        public System.Collections.Generic.Dictionary<string, System.Type> RuntimeTypeNameToProxyTypeMap
        {
            get { return runtimeTypeNameToProxyTypeMap; }
        }
    }
}