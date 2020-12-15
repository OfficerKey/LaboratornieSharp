using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LR8
{
    class Car
    {
        private string name { get; set; }
        private string color { get; set; }
        private int speed { get; set; }
        private int year { get; set; }
        protected List<Car> spisok { get; set; } = new List<Car>();

        public void Buy()
        {
            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine("Введите названия машины ->");
                name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите цвет машины ->");
                color = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите скорость машины ->");
                speed = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите год випуска машины ->");
                year = Convert.ToInt32(Console.ReadLine());
                spisok.Add(new Garage() { name = name, color = color, speed = speed, year = year });
            }


        }
        public void Drive()
        {
            Console.WriteLine("За каким параметром будете искать авто ->");
            Console.WriteLine("1-Названия");
            Console.WriteLine("2-Цвет");
            Console.WriteLine("3-Скорость");
            Console.WriteLine("4-Год");
            int number = Convert.ToInt32(Console.ReadLine());
            string Name, Color;
            int Year, Speed;
            if (number==1)
            {
                Console.WriteLine("Введите имя->");
                Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Найденно ->{0}", spisok.Find(x => x.name.Contains(Name)));


            }
            else if(number ==2)
            {
                Console.WriteLine("Введите Цвет->");
                Color = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Найденно ->{0}", spisok.Find(x => x.color.Contains(Color)));
            }
            else if(number==3)
            {
                Console.WriteLine("Введите скорость->");
                Speed = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Найденно ->{0}", spisok.Find(x => x.speed==Speed));
            }
            else if(number ==4)
            {
                Console.WriteLine("Введите год->");
                Year = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Найденно ->{0}", spisok.Find(x => x.year == Year));
            }
           

        }


        public override string ToString()
        {
            return "Имя: " + name + " Цвет: " + color + " Скорость: " + speed + " Год випуска: " + year;
        }
    }
}
