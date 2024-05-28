using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIBasics.Models;
using System.Net.Http.Headers;
using System.Data;
namespace APIBasics.Controllers
{
    public class DepartmentController : ApiController
    {
        public HttpResponseMessage Get()
        {
            string s;
            s = "hello";
            DataTable dt = new DataTable();
            dt.Columns.Add("DeptID");
            dt.Columns.Add("DeptName");
            dt.Rows.Add(1, "IT");
            return Request.CreateResponse(HttpStatusCode.OK, dt);
        }

        public string Post(Department dep)
        {
            try
            {

                return "Added Success";
            }
            catch(Exception ex)
            {
                return "Failed to add";
            }
        }
        public string Put(Department dep)
        {
            try
            {

                return "updatded Success";
            }
            catch (Exception ex)
            {
                return "Failed to add";
            }
        }
    }
}
