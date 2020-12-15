using System;


namespace LR8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Garage garage = new Garage();
            garage.Buy();
            garage.Delete();
            garage.Drive();
            Console.ReadKey();
        }
    }
}
