using System;
using System.Collections.Generic;
using System.Text;

namespace MasGlobal.Model
{
    public class ConcreteEmployeeFactory : EmployeeFactory
    {
        public override IEmployee GetEmployee(Employee item)
        {
            switch (item.contractTypeName)
            {
                case "HourlySalaryEmployee":
                    return new EmployeeHourly(item);
                case "MonthlySalaryEmployee":
                    return new EmployeeMonthly(item);
                default:
                    throw new ApplicationException(string.Format("AnnualSalary '{0}' cannot be created", item.contractTypeName));
            }
        }
    }
}
