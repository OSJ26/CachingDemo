using CachingDemo.DBContext;
using CachingDemo.Models;

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
                objResponse.Message = "Succussfully get data";
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