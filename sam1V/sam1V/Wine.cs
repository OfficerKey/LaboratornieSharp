using System;
using System.Collections.Generic;
using System.Text;

namespace sam1V
{
    class Wine
    {
        private string name { get; set; }
        private int cena { get; set; }
        private int vidergka { get; set; }
        private string country { get; set; }
        private string creater { get; set; }
        public List<Wine> listOfWhisky { get; set; } = new List<Wine>();
        public int Cenas { get { return this.cena; } set { this.cena = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }

        public int Vidergka { get { return this.vidergka; } set { this.vidergka = value; } }

        public string Country { get { return this.country; } set { this.country = value; } }

        public string Creater { get { return this.creater; } set { this.creater = value; } }



        public Wine()
        {

        }
        public Wine(string name, int Cena, int vidergka, string country, string creater)
        {
            this.Name = name;
            this.Cenas = Cena;
            this.Vidergka = vidergka;
            this.Country = country;
            this.Creater = creater;
        }

        public void Add()
        {

            listOfWhisky.Add(new Wine() { Name = Name, Cenas = Cenas, Vidergka = Vidergka, Country = Country, Creater = Creater });
        }

        public void Display()
        {
            foreach (var item in listOfWhisky)
            {
                Console.WriteLine("Названия - " + item.name + " Цена - " + item.cena + " Год выдержки - " + item.vidergka + " Страна производитель - " + item.country + " Создатель - " + item.creater);
            }
        }
        public void Choose(string name)
        {





            Console.WriteLine("Найдено =>\n{0}", listOfWhisky.Find(x => x.name.Contains(name)));




        }
        public override string ToString()
        {
            return "Названия - " + name + " Цена - " + cena + " Год выдержки - " + vidergka + " Страна производитель - " + country + " Создатель - " + creater;
        }

    }
}

