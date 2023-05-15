using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace RadisCaching.CommonMethods
{
    public class CommonMethod
    {
        /// <summary>
        /// Connection string 
        /// </summary>
        #region private members
        private readonly static string connectionString = ConfigurationManager.ConnectionStrings["sql_invoicing"].ConnectionString;
        #endregion

        /// <summary>
        /// openconnection method for create
        /// connection to the database
        /// </summary>
        /// <returns>DbFactory object</returns>
        #region public methods
        public IDbConnection openConnection()
        {
            var dbFactory = new OrmLiteConnectionFactory(connectionString, MySqlDialect.Provider);
            return dbFactory.Open();
        }
        #endregion public methods
    }
}