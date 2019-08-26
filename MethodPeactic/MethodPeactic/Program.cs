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
      

}

