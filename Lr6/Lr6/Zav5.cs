using System;
using System.Collections.Generic;
using System.Text;

namespace Lr6
{
    class Zav5
    {
       public void Reverse(int a)
        {
            int b = 0;
            
            
            string str = Convert.ToString(a);

            char[] stri = str.ToCharArray();
            Array.Reverse(stri);

            str = new String(stri);
            b = Convert.ToInt32(str);
            Console.WriteLine("Результат из метода ->"+b);

        }
        public void Reverse(string str)
        {
            
            char[] stri = str.ToCharArray();
            Array.Reverse(stri);
            str = new String(stri);
            Console.WriteLine("Результат из метода ->" + str);
        }
        public void Reverse(double chislo )
        {
           
            string str3 = Convert.ToString(chislo);
            string[] text = str3.Split(',');

            string word1 = text[0];
            string word2 = text[1];
            char[] stri3 = word1.ToCharArray();
            char[] stri31 = word2.ToCharArray();
            Array.Reverse(stri3);
            Array.Reverse(stri31);
            word1 = new String(stri3);
            word2 = new string(stri31);
            //Console.WriteLine(word1 + ',' + word2);
            string newChislo = word1 + ',' + word2;
            chislo = Convert.ToDouble(newChislo);
            Console.WriteLine("Результат из метода ->" + chislo);
        }
        public void Reverse(string[] text2)
        {
            string word3 = text2[0];
            string word4 = text2[1];
            char[] stri4 = word3.ToCharArray();
            char[] stri41 = word4.ToCharArray();
            Array.Reverse(stri4);
            Array.Reverse(stri41);
            word3 = new String(stri4);
            word4 = new string(stri41);
            Console.WriteLine("Результат из метода ->" + word3 + ',' + word4);

        }
        
           


        
    }
}
