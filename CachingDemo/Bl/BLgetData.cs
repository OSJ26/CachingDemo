using CachingDemo.DBContext;
using CachingDemo.Models;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CachingDemo.Bl
{
    public class BLgetData
    {
        readonly DBUser objDbUser = new DBUser();
        readonly Response objResponse = new Response();

        public Response getData()
        {
            objResponse.DataModel = objDbUser.getUser();
            if (objResponse.DataModel != null)
            {
                objResponse.IsError = false;
                objResponse.Message = "Succussfullt get data";
                return objResponse;
            }
            else { 

                objResponse.IsError = true;
                objResponse.Message = "Check, something gonna wrong";
                return objResponse;
            }
        }


    }
}