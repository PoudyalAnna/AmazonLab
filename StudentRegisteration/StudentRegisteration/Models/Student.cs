using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegisteration.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }     
       
        public string StudentCellPhone { get; set; }
        public string StudentAge { get; set; }
    }
}
