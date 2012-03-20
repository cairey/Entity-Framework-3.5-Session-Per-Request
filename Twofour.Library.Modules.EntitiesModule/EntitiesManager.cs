using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data.Objects;

namespace Library.Modules
{
    public static class EntitiesManager
    {
        internal const string DB = "ASP_EDMX_DB_CONTEXT";

        /// <summary>
        /// Get an instance that lives for the life time of the request per user and automatically disposes.
        /// </summary>
        /// <returns>Model</returns>  
        public static T AsSingleton<T>() where T : ObjectContext, new()
        {
            HttpContext.Current.Items[DB] = (T)HttpContext.Current.Items[DB] ?? new T();
            return (T)HttpContext.Current.Items[DB];
        }

        /// <summary>
        /// Get an instance that lives for the life time of the Session.
        /// </summary>
        /// <returns>Model</returns>  
        public static T AsSession<T>() where T : ObjectContext, new()
        {
            HttpContext.Current.Session[DB] = (T)HttpContext.Current.Session[DB] ?? new T();
            return (T)HttpContext.Current.Session[DB];
        }

        /// <summary>
        /// Get a new instance of the Model. Object must be disposed of.
        /// </summary>
        /// <returns>Model</returns>  
        public static T AsNewInstance<T>() where T : ObjectContext, new()
        {
            return (T)new T();
        }
    }
}
