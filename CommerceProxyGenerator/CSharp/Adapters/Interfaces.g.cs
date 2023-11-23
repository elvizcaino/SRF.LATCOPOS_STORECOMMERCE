// <auto-generated />
namespace Contoso.Commerce.RetailProxy.Extension.Adapters
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Threading.Tasks;

    
    /// <summary>
    /// Interface for Store Operations Manager.
    /// </summary>
    [GeneratedCodeAttribute("Contoso.Commerce.RetailProxy.Extension", "1.0")]
    public interface IStoreOperationsManager : Microsoft.Dynamics.Commerce.RetailProxy.IEntityManager
    {
        
        /// <summary>
        /// SimplePingPost method.
        /// </summary>
        /// <returns>bool object.</returns>
        Task<bool> SimplePingPost();
    
        /// <summary>
        /// SimplePingGet method.
        /// </summary>
        /// <returns>bool object.</returns>
        Task<bool> SimplePingGet();
    
    }
    
    /// <summary>
    /// Interface for ExampleEntity Manager.
    /// </summary>
    [GeneratedCodeAttribute("Contoso.Commerce.RetailProxy.Extension", "1.0")]
    public interface IExampleEntityManager : Microsoft.Dynamics.Commerce.RetailProxy.IEntityManager
    {
        
        /// <summary>
        /// CreateExampleEntity method.
        /// </summary>
        /// <param name="entityData">The entityData.</param>
        /// <returns>long object.</returns>
        Task<long> CreateExampleEntity(Contoso.CommerceRuntime.Entities.DataModel.ExampleEntity entityData);
    
        /// <summary>
        /// UpdateExampleEntity method.
        /// </summary>
        /// <param name="unusualEntityId">The unusualEntityId.</param>
        /// <param name="updatedEntity">The updatedEntity.</param>
        /// <returns>bool object.</returns>
        Task<bool> UpdateExampleEntity(long unusualEntityId, Contoso.CommerceRuntime.Entities.DataModel.ExampleEntity updatedEntity);
    
        /// <summary>
        /// DeleteExampleEntity method.
        /// </summary>
        /// <param name="unusualEntityId">The unusualEntityId.</param>
        /// <returns>bool object.</returns>
        Task<bool> DeleteExampleEntity(long unusualEntityId);
    
        /// <summary>
        /// GetAllExampleEntities method.
        /// </summary>
        /// <param name="queryResultSettings">The queryResultSettings.</param>
        /// <returns>Collection of Contoso.CommerceRuntime.Entities.DataModel.ExampleEntity.</returns>
        Task<Microsoft.Dynamics.Commerce.Runtime.PagedResult<Contoso.CommerceRuntime.Entities.DataModel.ExampleEntity>> GetAllExampleEntities(Microsoft.Dynamics.Commerce.Runtime.DataModel.QueryResultSettings queryResultSettings = null);
    
    }
    
    /// <summary>
    /// Interface for LATCOBasicDocumentTypeEntity Manager.
    /// </summary>
    [GeneratedCodeAttribute("Contoso.Commerce.RetailProxy.Extension", "1.0")]
    public interface ILATCOBasicDocumentTypeEntityManager : Microsoft.Dynamics.Commerce.RetailProxy.IEntityManager
    {
        
        /// <summary>
        /// GetAllLATCOBasicDocumentTypeEntities method.
        /// </summary>
        /// <param name="queryResultSettings">The queryResultSettings.</param>
        /// <returns>Collection of Contoso.CommerceRuntime.Entities.LATCOBasicDocumentTypeEntity.</returns>
        Task<Microsoft.Dynamics.Commerce.Runtime.PagedResult<Contoso.CommerceRuntime.Entities.LATCOBasicDocumentTypeEntity>> GetAllLATCOBasicDocumentTypeEntities(Microsoft.Dynamics.Commerce.Runtime.DataModel.QueryResultSettings queryResultSettings = null);
    
    }
    
 }
