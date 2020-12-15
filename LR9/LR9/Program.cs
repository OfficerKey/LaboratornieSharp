using System;
using System.Collections;
using System.Collections.Generic;

namespace LR9
{
    interface IDraw
    {
        void Draw();
    }
    abstract class Shape
    {
        public abstract string color { get; set; }
        public abstract int collVershin { get; }
        public abstract string Name { get; }

        public abstract double Ploshcha();
        public abstract double Perimetr();

        public static explicit operator Shape(string v)
        {
            throw new NotImplementedException();
        }
    }

    class Squer : Shape,IDraw
    {
        private string name { get; set; }
        public override string color { get; set; }

        public override int collVershin { get {return 4; } }

        public override string Name { get {return name; } }
        
        private int dovzinaStorony { get; set; }
        private int plosha { get; set; }
        private int preimetr { get; set; }

        public Squer(string name,string Color, int DovzinaStorony)
        {
            this.color = Color;
            this.dovzinaStorony = DovzinaStorony;
            this.name = name;
        }

        public Squer()
        {
        }

        

        public override double Perimetr()
        {
           return preimetr = 4 * dovzinaStorony;
            
            
        }

        public override double Ploshcha()
        {
           return plosha = dovzinaStorony * dovzinaStorony;
           
        }

        

        public void Draw()
        {
            Console.WriteLine($"Цвет - {color}, Количество вершин - {collVershin}, Имя - {Name}, Площа -{plosha}, Периметр- {preimetr}");
        }
    }


    class Circle : Shape, IDraw
    {
        private string name { get; set; }
        public override string color { get; set; }

        public override int collVershin { get { return 0; } }

        public override string Name { get { return name; } }

        private int radius { get; set; }
        private int plosha { get; set; }
        private int preimetr { get; set; }
        public Circle(string name,string Color,int Radius)
        {
            this.color = Color;
            this.radius = Radius;
            this.name = name;
        }

        public Circle()
        {
        }

        

        public override double Perimetr( )
        {
           return preimetr=(int)(2*Math.PI*radius);
            
        }

        public override double Ploshcha( )
        {
            return plosha = (int)(Math.PI * radius);
            

        }

        public void Draw()
        {
            Console.WriteLine($"Цвет - {color}, Количество вершин - {collVershin}, Имя - {Name}, Площа -{plosha}, Периметр- {preimetr}");
        }
    }
    class Triangle : Shape, IDraw
    {
        private string name { get; set; }
        public override string color { get; set; }

        public override int collVershin { get {return 3; } }

        public override string Name { get {return name; } }

        private int dovzinaStorony { get; set; }
        private int dovzinaStorony2 { get; set; }
        private int plosha { get; set; }
        private int preimetr { get; set; }
        public Triangle(string name,string Color,int DovzinaStorony,int  DovzinaStorony2)
        {
            this.color = Color;
            this.dovzinaStorony = DovzinaStorony;
            this.dovzinaStorony2 = DovzinaStorony2;
            this.name = name;
           
        }

        public Triangle()
        {
        }

        

        public override double Perimetr()
        {
            return preimetr = 2*dovzinaStorony+dovzinaStorony2;
            

        }

        public override double Ploshcha()
        {
            int h;
            h = dovzinaStorony - dovzinaStorony2 / 2;
            return plosha = 1/2*(dovzinaStorony2*h);
            
        }

        public void Draw()
        {
            Console.WriteLine($"Цвет - {color}, Количество вершин - {collVershin}, Имя - {Name}, Площа -{plosha}, Периметр- {preimetr}");
        }
    }

    class Picture : IDraw
{
        private List<Shape> list;

        private int NumberOfShapes { get { return list.Count; } set { } }

        //my indexer
        public Shape[] shapes;

        public Shape this[int index]
        {
            get
            {
                return shapes[index];
            }
            set
            {
                shapes[index] = value;
            }
        }

        public Picture()
        {
            list = new List<Shape>();
        }
        public Picture(int collectionLength)
        {
            list = new List<Shape>(collectionLength);

            NumberOfShapes = collectionLength;
        }

        //methods 
        //add a new shape method
        public void Add(Shape figura)
        {
            list.Add(figura);
        }

        //remove by name
        public void RemoveByName(string nameFigura)
        {
            if (NumberOfShapes == 0)
            {
                Console.WriteLine("There are nothing to remove  - list is empty!");
            }
            else
            {
                for (int i = 0; i < NumberOfShapes; i++)
                {
                    if (list[i].Name == nameFigura)
                    {
                        list.Remove(list[i]);
                    }
                }
            }
        }

        //remove by area limitation
        public void RemoveByArea(double areaLimit)
        {
            if (NumberOfShapes == 0)
            {
                Console.WriteLine("There are nothing to remove  - list is empty!");
            }
            else
            {
                for (int i = 0; i < NumberOfShapes; i++)
                {
                    if (list[i].Ploshcha() > areaLimit)
                    {
                        list.Remove(list[i]);
                    }
                }
            }
        }

        //remove by type
        public void RemoveByType(Type figure)
        {
            if (NumberOfShapes == 0)
            {
                Console.WriteLine("There are nothing to remove  - list is empty!");
            }
            else
            {
                for (int i = 0; i < NumberOfShapes; i++)
                {
                    if (list[i].GetType() == figure)
                    {
                        list.Remove(list[i]);
                    }
                }
            }
        }

        public void Draw()
        {
            if (NumberOfShapes == 0)
            {
                Console.WriteLine("~The list is empty!~");
            }
            else
            {
                int i = 1;
                foreach (Shape el in list)
                {
                    Circle circle;
                    Squer squer;
                    Triangle triangle;
                    if (el is Circle)
                    {
                        circle = (Circle)el;
                        Console.WriteLine("Фигура # {0}", i++);
                        circle.Draw();
                    }
                    else if (el is Squer)
                    {
                        squer = (Squer)el;
                        Console.WriteLine("Фигура # {0}", i++);
                        squer.Draw();
                    }
                    else
                    {
                        triangle = (Triangle)el;
                        Console.WriteLine("Фигура # {0}", i++);
                        triangle.Draw();
                    }
                }
            }
        }
    }
    static class  Painter
    {
        public static void Draw (IDraw drawPicture)
        {
            drawPicture.Draw();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Squer squer = new Squer("Квадрат1","Красный", 4);
            Circle circle = new Circle("Круг1","Синий", 5);
            Triangle triangle = new Triangle("Треуголник1","Белый",3,4);
            Picture picture = new Picture();
            

            squer.Perimetr();
            squer.Ploshcha();
            ((IDraw)squer).Draw();
            Console.WriteLine("---------------");
            circle.Perimetr();
            circle.Ploshcha();
            ((IDraw)circle).Draw();
            Console.WriteLine("---------------");
            triangle.Perimetr();
            triangle.Ploshcha();
            ((IDraw)triangle).Draw();
            Console.WriteLine("---------------");
            picture.Add(squer);

            picture.Add(new Triangle("ТРеуголник2","Чорный",5,3));

            picture.RemoveByName("Круг2");
            picture.RemoveByType(typeof(Circle));

            picture.Draw();
            Console.WriteLine("--------------");
            Painter.Draw(triangle);
            



            Console.ReadKey();



        }
    }
}
