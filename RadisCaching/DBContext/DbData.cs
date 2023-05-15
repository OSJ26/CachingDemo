using RadisCaching.CommonMethods;
using RadisCaching.Models;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RadisCaching.DBContext
{
    public class DbData
    {
        CommonMethod objCommon = new CommonMethod();

        public dynamic Data()
        {
            using (var db = objCommon.openConnection())
            {
                var query = db.Select<CLID01>();
                return query;
            }
        }
    }
}