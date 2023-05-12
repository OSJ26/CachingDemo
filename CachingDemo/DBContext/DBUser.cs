using CachingDemo.CommonMethods;
using CachingDemo.Models;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

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