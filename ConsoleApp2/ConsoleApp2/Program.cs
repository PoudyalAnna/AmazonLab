using System;

namespace ConsoleApp2
{
    class Program
    {
      
        static void Main(string[] args)

        {
            Student myStudent = new Student();
            myStudent.fname = "John";
            myStudent.lname = "test";
            myStudent.enrolled = false;
            enrollStudent(myStudent);

            Console.WriteLine(myStudent.enrolled);
            Console.ReadLine();
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

