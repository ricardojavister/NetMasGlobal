using System;
using System.Collections.Generic;
using System.Text;

namespace MasGlobal.Model
{
    public class EmployeeHourly : Employee
    {
        public EmployeeHourly(Employee item) {
            this.contractTypeName = item.contractTypeName;
            this.hourlySalary = item.hourlySalary;
            this.id = item.id;
            this.monthlySalary = item.monthlySalary;
            this.name = item.name;
            this.roleDescription = item.roleDescription;
            this.roleId = item.roleId;
            this.roleName = item.roleName;
        }

        public override void CalculateAnnualSalary()
        {
            this.AnnualSalary = 120 * hourlySalary * 12;
        }
    }

    public class EmployeeHourlyCreator : EmployeeCreator
    {
        public override Employee CreateEmployee(Employee item)
        {
            return new EmployeeHourly(item);
        }
    }
}
