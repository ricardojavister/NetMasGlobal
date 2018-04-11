using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using MasGlobal.Model;
using MasGlobal.BusinessLayer;
using System.Collections;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MasGlobal.WebApiAppNew.Controllers
{
    public  class EmployeeController : ApiController
    {
        public  IHttpActionResult Post(List<Employee> list)
        {
            List<Employee> l = new List<Employee>();
            EmployeeBU employeeBU = new EmployeeBU();
            l = employeeBU.GetEmployees(GetIds(list));
            if (l == null)
            {
                return  NotFound();
            }
            return Json<List<Employee>>(l);
        }

        private List<int> GetIds(List<Employee> ids) {
            List<int> listInt = new List<int>();
            foreach (Employee i in ids) {
                listInt.Add(i.id);
            }
            return listInt;
        }
    }
}
