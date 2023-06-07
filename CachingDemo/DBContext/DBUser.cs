using CachingDemo.CommonMethods;
using CachingDemo.Models;
using ServiceStack.OrmLite;

namespace CachingDemo.DBContext
{
    public class DBUser
    {
        CommonMethod objCommon = new CommonMethod();

        public dynamic getUser()
        {
            using (var db = objCommon.openConnection())
            {
                var query = db.Select<User>();
                return query;
            }
        }
    }
}