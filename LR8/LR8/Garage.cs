using System;
using System.Collections.Generic;
using System.Text;

namespace LR8
{
    class Garage:Car
    {
        
        public void Delete()
        {
            Console.WriteLine("Какую машину вы хотите удалить?");
            int count = Convert.ToInt32(Console.ReadLine());
            spisok.RemoveAt(count);
            foreach (Car i in spisok)
            {
                if (spisok.Count == 0)
                {
                    Console.WriteLine("Список пуст");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
        
    }
}
