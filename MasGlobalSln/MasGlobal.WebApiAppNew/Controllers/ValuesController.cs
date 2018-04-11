using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MasGlobal.Model;
using MasGlobal.BusinessLayer;

namespace MasGlobal.WebApiAppNew.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        //public IHttpActionResult Post(int id)
        //{
        //    List<Employee> l = new List<Employee>();
        //    EmployeeBU employeeBU = new EmployeeBU();
        //    l = employeeBU.GetEmployees(id);

        //    if (l == null)
        //    {
        //        return NotFound();
        //    }
        //    return Json<List<Employee>>(l);
        //}

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
