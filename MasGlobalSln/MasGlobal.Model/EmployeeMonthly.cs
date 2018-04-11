using System;
using System.Collections.Generic;
using System.Text;

namespace MasGlobal.Model
{
    public class EmployeeMonthly : Employee
    {
        public EmployeeMonthly(Employee item)
        {
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
           this.AnnualSalary =  monthlySalary * 12;
        }
    }

    public class EmployeeMonthlyCreator : EmployeeCreator
    {
        public override Employee CreateEmployee(Employee item)
        {
            return new EmployeeMonthly(item);
        }
    }
}
