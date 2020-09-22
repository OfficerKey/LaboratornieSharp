using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lr3 V-8");
            int a, b, c;
            Console.WriteLine("a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c=");
            c = Convert.ToInt32(Console.ReadLine());
           
            if (a == -b || a == -c || b == -c) Console.WriteLine("Есть хотя бы одна противоположная пара");
            else Console.WriteLine("Противоположных чисел нет");
            Console.ReadKey();
        }
    }
}
