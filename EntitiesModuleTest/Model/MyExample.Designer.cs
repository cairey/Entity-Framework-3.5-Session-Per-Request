﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4200
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]

// Original file name:
// Generation date: 14/10/2009 16:52:10
namespace EntitiesModuleWeb.Model
{
    
    /// <summary>
    /// There are no comments for MediaFreedomTestEntities in the schema.
    /// </summary>
    public partial class MediaFreedomTestEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new MediaFreedomTestEntities object using the connection string found in the 'MediaFreedomTestEntities' section of the application configuration file.
        /// </summary>
        public MediaFreedomTestEntities() : 
                base("name=MediaFreedomTestEntities", "MediaFreedomTestEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new MediaFreedomTestEntities object.
        /// </summary>
        public MediaFreedomTestEntities(string connectionString) : 
                base(connectionString, "MediaFreedomTestEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new MediaFreedomTestEntities object.
        /// </summary>
        public MediaFreedomTestEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "MediaFreedomTestEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
    }
}
