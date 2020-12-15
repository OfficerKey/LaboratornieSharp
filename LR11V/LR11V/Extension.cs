using System;
using System.Collections.Generic;
using System.Text;

namespace LR11V
{
    static class Extension
    {
        public static List<Student> FindStudent(this List<Student> list, StudentPredicateDelegate spd)
        {
            List<Student> List = new List<Student>();
            foreach (Student i in list)
            {
                if (spd.Invoke(i))
                    List.Add(i);
            }
            return List;
        }

        public static void DisplayList(this List<Student> list)
        {
            

            foreach (Student i in list)
            {
                Console.WriteLine("First Name: {0}", i.FirstName);
                Console.WriteLine("Last Name: {0}", i.LastName);
                Console.WriteLine("Age: {0}", i.age);
            }
        }
    }
}
