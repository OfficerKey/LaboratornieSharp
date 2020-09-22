using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr5
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("LR 5 V-30");
            int m, n, i, j;
            Console.WriteLine("n=");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("m=");
            m = Convert.ToInt32(Console.ReadLine());

            int[,] a = new int[m, n];



            Console.WriteLine("m=");

            Random random = new Random();
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    a[i, j] = random.Next(1,20);
                    Console.Write("{0,4}", a[i, j]);
                }
                Console.WriteLine();
            }

            int max = 0, min = 0;
            for (i = 0; i < m; i++)
            {
                max = a[i, 0];
                min = int.MaxValue;

                for (j = 0; j < n; j++)
                {

                    if (a[i, j] > max)
                    {
                        max = a[i, j];

                    }
                     if (a[j, i] < min)
                    {
                        min = a[j, i];

                    }
                    

                }
                Console.WriteLine("max:{0}", max);
                Console.WriteLine("min:{0}", min);

            }


            Console.ReadKey();


        }
    }
}
