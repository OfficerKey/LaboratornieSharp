using System;

namespace Lr10V
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[] { -3, 2, 5, 1 ,4};
            int[] massiv = new int[mass.Length];
            Console.WriteLine("\nИсходный массив");



            for (int i = mass.Length - 1; i > -1; i--)
            {
                mass[i] = mass[i];
                massiv[i] = mass[i];



                Console.WriteLine(mass[i]);
                



            }
            Console.WriteLine("---------");
            massiv.Sorting();
            Console.ReadKey();
        }
    }
    public static class Sortin
    {
        public static int [] Sorting(this int[] mass)
        {
            for(int i=0;i<mass.Length-1;i++)
            {
                for (int j = i + 1; j < mass.Length; j++)
                {
                    if (mass[i] < mass[j])
                    {
                        int temp = mass[i];
                        mass[i] = mass[j];
                        mass[j] = temp;
                    }
                    
                }
                Console.WriteLine(mass[i]);
            }
           
            return mass;
        }
    }
}
