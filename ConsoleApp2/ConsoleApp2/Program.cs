using System;

namespace ConsoleApp2
{
    class Program
    {
      
        static void Main(string[] args)

        {

        }
        static void enrollStudent(Student stu)
        {
            if (stu.enrolled) {// false block
               
            }
            else
            {
                stu.enrolled = true;
                //  true block
            }
        }
            class Student
        {
         public    string fname;
          public  string lname;
          public  bool enrolled;
        }
        }
    }

