using System;

namespace sam1V
{
    class Program
    {
        static void Main(string[] args)
        {
            Wine wine = new Wine("Крестное", 200, 39, "Italic", "Perpav");
            Wine wine2 = new Wine("Krestr", 300, 40, "Italic", "Perv");
            wine.Add();
            wine.Display();
            wine2.Add();
            wine2.Display();
            wine.Choose("Крестное");
        }
    }
}
