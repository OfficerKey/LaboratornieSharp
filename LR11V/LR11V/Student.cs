using System;
using System.Collections.Generic;
using System.Text;

namespace LR11V
{
    delegate bool StudentPredicateDelegate(Student student);
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
         public int age { get; set; }

        public Student( string fistName,string lastName,int Age)
        {
            this.FirstName = fistName;
            this.LastName = lastName;
            this.age = Age;
        }

        public static bool Adult(Student student)
        {
            if (student.age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool FirstSymbol(Student student)
        {
            if (student.FirstName[0]=='A') return true;
            else
            {
                return false;
            }
        }

        public static bool FirstThreeSymbol(Student student)
        {
            if (student.LastName.Length > 3) { return true; }
            else
            {
                return false;
            }
        }
    }
}
