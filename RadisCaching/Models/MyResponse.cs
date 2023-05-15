using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RadisCaching.Models
{
    public class MyResponse
    {
        public bool IsError { get; set; }

        public string Message { get; set; }

        public object DataModel { get; set; }
    }
}