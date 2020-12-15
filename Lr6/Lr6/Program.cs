using System;


namespace Lr6
{
    class Program
    {
        static void Main(string[] args)
        {
            Zav5 coll = new Zav5();
            Zav7 coll2 = new Zav7();
            //Zad1
            int a,b=0;
            Console.WriteLine("Задания 1");
            Console.WriteLine("Введите число = ");
            a = Convert.ToInt32(Console.ReadLine());
            string  str = Convert.ToString(a);

            char[] stri = str.ToCharArray();
            Array.Reverse(stri);

            str = new String(stri);
            b = Convert.ToInt32(str);
            coll.Reverse(a);
            Console.WriteLine(b);
            


            //Zad2
            Console.WriteLine("Задания 2");
            string str2;
            Console.WriteLine("Введите строку");
            str2 = Convert.ToString(Console.ReadLine());
            
            char[] stri2 = str2.ToCharArray();
            Array.Reverse(stri2);
            coll.Reverse(str2);

            str2 = new String(stri2);
      
            Console.WriteLine(str2);

            //Zad3
            Console.WriteLine("Задания 3");
            
            Console.WriteLine("Введите дробовое число с , ->");

            
            
            double chislo= Convert.ToDouble(Console.ReadLine());
            
            string str3=Convert.ToString(chislo);
            string[] text = str3.Split(',');

            string word1 = text[0];
            string word2 = text[1];
            char[] stri3 = word1.ToCharArray();
            char[] stri31 = word2.ToCharArray();
            Array.Reverse(stri3);
            Array.Reverse(stri31);
            word1 = new String(stri3);
            word2 = new string(stri31);
           
            string newChislo = word1 + ',' + word2;
            coll.Reverse(chislo);
            chislo =Convert.ToDouble(newChislo);
            Console.WriteLine(chislo);

            //Zad4
            Console.WriteLine("Задания 4");
            string str4;
            Console.WriteLine("Введите строку с , ->");
            str4 = Convert.ToString(Console.ReadLine());
            string[] text2 = str4.Split(',');
            

            string word3 = text2[0];
            string word4 = text2[1];
            char[] stri4 = word3.ToCharArray();
            char[] stri41 = word4.ToCharArray();
            Array.Reverse(stri4);
            Array.Reverse(stri41);
            word3 = new String(stri4);
            word4 = new string(stri41);
            coll.Reverse(text2);
            Console.WriteLine(word3 + ',' + word4);

            double[] mass = new double[] {3,2,1,4,5,6 };
            int[] massiv;
            Console.WriteLine("Завдання 7");
            Console.WriteLine("Начальний масив");
            for(int i=0;i<mass.Length;i++)
            {
                Console.Write(mass[i]);
            }
            
            coll2.Return(mass);
            coll2.Return(ref mass);
            coll2.Return(out massiv);




            Console.ReadKey();




        }
    }
}
