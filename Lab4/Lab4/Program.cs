using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0;

            Console.WriteLine("Razmer masiva =");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            int[] c = new int[n];
            

            
            Console.WriteLine("A:\n");
            for (int k = 0; k < a.Length; ++k)
            {
                a[k] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine("B:\n");
            for (int k = 0; k < b.Length; ++k)
            {
                b[k] = Convert.ToInt32(Console.ReadLine());
                
            }

            int ka = 0, kb = 0;

            for (int k = 0; k < a.Length; ++k)
            {
                if ((ka >= 5) || ((a[ka] > b[kb]) && (kb < 5)))
                {
                    c[k] = b[kb];
                    ++kb;
                    Console.WriteLine("B:\n");
                    Console.WriteLine(b[k]);
                }
                else
                {
                    c[k] = a[ka];
                    ++ka;
                    Console.WriteLine("A:\n");
                    Console.WriteLine(a[k]);
                }
            }
            Console.WriteLine("C:\n");
            for (int k = 0; k < c.Length; ++k) { Console.WriteLine(c[k]); }

            Console.ReadKey();
        }
    }
}
