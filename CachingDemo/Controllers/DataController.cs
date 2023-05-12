using CachingDemo.Bl;
using CachingDemo.CommonMethods;
using CachingDemo.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Runtime.Caching;
using System.Web.Http;

namespace CachingDemo.Controllers
{
    public class DataController : ApiController
    {
        BLgetData objData = new BLgetData();

        [HttpGet]
        [Route("getData")]
        public HttpResponseMessage getUserData()
        {
            var cache = MemoryCache.Default;
            var cacheKey = CacheKey.User;

            if (cache.Contains(cacheKey))
            {
                var user = cache.Get(cacheKey);
                CacheItemPolicy chaceitemPoilcy = new CacheItemPolicy();
                chaceitemPoilcy.AbsoluteExpiration = DateTime.Now.AddHours(1.0);
                cache.Add(cacheKey, cache, chaceitemPoilcy);
                return Request.CreateResponse(HttpStatusCode.OK, "Comming From Cache");
            }
            else
            {

                if (objData.getData().IsError == true)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, objData.getData().Message);
                }
                return Request.CreateResponse(HttpStatusCode.OK, objData.getData().DataModel);

            }
        }
    }
}
