using ServiceStack.OrmLite;
using System.Configuration;
using System.Data;

namespace CachingDemo.CommonMethods
{
    public class CommonMethod
    {
        /// <summary>
        /// Connection string 
        /// </summary>
        #region private members
        private readonly static string connectionString = ConfigurationManager.ConnectionStrings["TntConnection"].ConnectionString;
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