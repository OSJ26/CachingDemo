using RadisCaching.DBContext;
using RadisCaching.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RadisCaching.BL
{
    public class BLData
    {
        readonly DbData objData = new DbData();
        readonly MyResponse objResponse = new MyResponse();

        public MyResponse getData()
        {
            if (objData.Data() == null)
            {
                objResponse.IsError = true;
                objResponse.Message = "Check, something gonna wrong";
                return objResponse;
            }
            else
            {
                objResponse.IsError = false;
                objResponse.Message = "Succussfullt get data";
                objResponse.DataModel = objData.Data();
                return objResponse;
            }
        }
    }
}