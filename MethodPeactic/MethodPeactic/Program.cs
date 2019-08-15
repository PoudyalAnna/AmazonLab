using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPeactic
{
    class Program
    {
        static void Main(string[] args)

        {
           Employee myEmployee = new Employee();
           myEmployee.fname = "John";
            myEmployee.lname = "test";
            myEmployee.empDepartment = null  ;
            department(myEmployee);

            Console.WriteLine( myEmployee.fname + " " +  myEmployee.lname +  " " + myEmployee.empDepartment);
            Console.ReadLine();


        }
        static void department(Employee dept )
        {
            if (string.IsNullOrEmpty(dept.empDepartment))
            {// false block
                dept.empDepartment ="sales";
            }
            else
            {
               
                
                //  true block
            }
        }
        class Employee
        {
            public string fname;
            public string lname;
            public string  empDepartment;
        }
        public void setname()
        {

        }
    }

}

