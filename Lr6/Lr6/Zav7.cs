using System;
using System.Collections.Generic;
using System.Text;

namespace Lr6
{
    class Zav7
    {
        public void Return(double[] mass)
        {
            Console.WriteLine("\nИсходный массив");
            
            for(int i=mass.Length-1;i>-1;i--)
            {
                mass[i] = mass[i];
                Console.Write(mass[i]);

            }
        }
        public void Return(ref double[] mass)
        {
            Console.WriteLine("\nЗавдання 8");
            Console.WriteLine("\nИсходный массив ref");

            for (int i = mass.Length - 1; i > -1; i--)
            {
                mass[i] = mass[i];
                Console.Write(mass[i]);

            }
        }
        public void Return(out int[] massiv)
        {
            massiv = new int[]{ 3, 2, 4, 5, 6 };
            Console.WriteLine("\nИсходный массив out");

            for (int i = massiv.Length - 1; i > -1; i--)
            {
                massiv[i] = massiv[i];
                Console.Write(massiv[i]);

            }
        }
    }
}
