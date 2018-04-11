using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MasGlobal.Model;
using MasGlobal.DataLayer;
using Newtonsoft.Json;


namespace MasGlobal.BusinessLayer
{
    public class EmployeeBU
    {
        public List<Employee> GetEmployees(List<int> ids)
        {
            EmployeeDA employeeDA = new EmployeeDA();
            List<Employee> listEmployee = new List<Employee>();
            if (ids.Count > 0)
            {
                return GroupEmployees(JsonConvert.DeserializeObject<List<Employee>>(ApiHelper.HttpGet("http://masglobaltestapi.azurewebsites.net/api/Employees"))).ToList().FindAll(x => ids.Contains(x.id)).ToList();
            }
            else {
                return GroupEmployees(JsonConvert.DeserializeObject<List<Employee>>(ApiHelper.HttpGet("http://masglobaltestapi.azurewebsites.net/api/Employees"))).ToList();
            }
        }

        private List<Employee> GroupEmployees(List<Employee> listEmployees)
        {
            List<Employee> listEmployeesGrouped = new List<Employee>();
            ConcreteEmployeeFactory employeeFactory = new ConcreteEmployeeFactory();
            if (listEmployees != null)
            {
                foreach (Employee item in listEmployees)
                {
                    IEmployee employee = employeeFactory.GetEmployee(item); employee.CalculateAnnualSalary();
                    listEmployeesGrouped.Add((Employee)employee);
                }
            }
            return listEmployeesGrouped;
        }
    }
}
