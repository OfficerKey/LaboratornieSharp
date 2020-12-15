using System;
using System.Collections.Generic;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Spisok = new List<string>();
            
            Console.WriteLine("Сколько будет слов");
            int count = Convert.ToInt32(Console.ReadLine());
            int count2=0;
            int[] arrofList = new int[count];

            for(int i=0;i<count;i++)
            {
                Console.WriteLine("Слово -> ");
                string str = Convert.ToString(Console.ReadLine());
                Spisok.Add(str);
                arrofList[i] += Spisok[i].Length;


            }
            
            for(int i=1;i<arrofList.Length;i++)
            {
                if(arrofList[i]==arrofList[i-1])
                {
                    count2++;
                }
            }
            Console.WriteLine("Количество слов одинаковой длинны ->" + count2);
            Console.ReadKey();

        }
    }
}
