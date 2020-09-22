using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1and2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LR1");
            //Lr1
            double r = Convert.ToDouble(Console.ReadLine());
            double n = Convert.ToDouble(Console.ReadLine());
            double pi = 3.14;
            double a = 2 * r * Math.Tan(pi / n);
            double perimetr = a * n;
            Console.WriteLine(perimetr);
            
            Console.WriteLine("LR2");

            //Lr2
            int nn, nk;
            double ak;
            
            Console.WriteLine("nn=");
            nn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nk=");
            nk = Convert.ToInt32(Console.ReadLine());

            for (int i = nn; i < nk; i++)
            {
                ak = (Math.Pow(i, 2) + Math.Pow(-1, i) * i - 1) / (Math.Pow(i, 2) + 1);
                Console.WriteLine(Math.Round(ak, 2));
            }

            Console.ReadKey();
        }
    }
}
