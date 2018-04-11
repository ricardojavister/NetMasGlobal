using System;
using System.Collections.Generic;
using System.Text;

namespace MasGlobal.Model
{
    public abstract class EmployeeCreator
    {
        public abstract Employee CreateEmployee(Employee item);
    }
}
