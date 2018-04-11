using System;
using System.Collections.Generic;
using System.Text;

namespace MasGlobal.Model
{
    public abstract class EmployeeFactory
    {
        public abstract IEmployee GetEmployee(Employee employee);
    }
}
