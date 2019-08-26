using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPeactic
{
    class Employee
    {
        string fname;
         string lname;
         string empDepartment;

        public Employee(string fname)
        {
            this.fname = fname;
        }

        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   lname == employee.lname;
        }
    }
}
