using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MasGlobal.BusinessLayer;
using MasGlobal.Model;

namespace MAsGlobal.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBU employeeBU = new EmployeeBU();
            List<Employee> Listemployees = new List<Employee>();
            //Listemployees = employeeBU.GetEmployees(new List<int> { 1 });
        }
    }
}
