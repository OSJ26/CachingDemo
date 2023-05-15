using RadisCaching.BL;
using RadisCaching.CommonMethods;
using ServiceStack.OrmLite;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RadisCaching.Controllers
{
    public class DataController : ApiController
    {        
        [HttpGet]
        public IHttpActionResult getData()
        {
            BLData objBl = new BLData();
            CommonMethod objCommon = new CommonMethod();
            string objKey = "osj";
            var redis = ConnectionMultiplexer.Connect("localhost");
            var objData = redis.GetDatabase();
            var redisData = objData.StringGet(objKey);
            if (redisData.HasValue)
            {
                return Ok("Data Come From cache");
            }
            else
            {
                
                    var allData = objBl.getData();
                    objData.StringSet(objKey,allData.DataModel.ToString());
                    return Ok("First time data came" + allData.DataModel);
 
            }


        }
    }
}
