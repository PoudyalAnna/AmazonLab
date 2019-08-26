using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningconstructor
{
    class Employee
    {
        string fName;
        string lname;
        string dept;

        public Employee(string fName, string lname, string dept)
        {
            this.fName = fName;
            this.lname = lname;
            this.dept = dept;

            if (string.IsNullOrEmpty(dept))
            {
                dept = "IT";
            }
            Console.WriteLine("Firstname: " + fName   + "\n" + "LastName: " + lname +  "\n" + "Department: " + dept)  ;
            Console.ReadLine();
        }
    }
}
