using System;
using System.Collections.Generic;

namespace LR11V
{
    class Program
    {
        static void Main(string[] args)
        {
            PARK client = new PARK();

            var gorki = new Vipolneno(client.Gorki);

            var tir = new Vipolneno(client.tir);

            var roomFear = new Vipolneno(client.RoomFear);

            var roomMirror = new Vipolneno(client.RoomMirror);

            var popkorn = new Vipolneno(client.Popkorn);

            var koleso = new Vipolneno(client.Koleso);

            var combineGorki_Tir = gorki + tir;
            combineGorki_Tir(true);

            var combineRoom_Fear_Mirror = roomFear + roomMirror;
            combineRoom_Fear_Mirror(true);

            popkorn(true);
            koleso(false);

            client.Display();

            Console.WriteLine("------------");

            PARK client2 = new PARK();

            var gorki2 = new Vipolneno(client2.Gorki);

            var tir2 = new Vipolneno(client2.tir);

            var roomFear2 = new Vipolneno(client2.RoomFear);

            var roomMirror2 = new Vipolneno(client2.RoomMirror);

            var popkorn2 = new Vipolneno(client2.Popkorn);

            var koleso2 = new Vipolneno(client2.Koleso);

            var combineGorki_Tir2 = gorki2 + tir2;
            combineGorki_Tir2(true);

            var combineRoom_Fear_Mirror2 = roomFear2 + roomMirror2;
            combineRoom_Fear_Mirror2(false);

            popkorn2(true);
            koleso2(true);

            client2.Display();


            List<Student> list = new List<Student>();

            list.Add(new Student("Петров", "Гудков", 13) );
            list.Add(new Student("Влад", "Гудков", 15));
            list.Add(new Student("Саша", "Гудков", 23));
            list.Add(new Student("Алексей", "Гудков", 18));
            list.Add(new Student("Андрей", "Гудков", 33));


            List<Student> student = new List<Student>();
            StudentPredicateDelegate spd;

            
            spd = Student.Adult;
            student = list.FindStudent(spd);
            student.DisplayList();

            
            spd = Student.FirstSymbol;
            student = list.FindStudent(spd);
            student.DisplayList();

           
            spd = Student.FirstThreeSymbol;
            student = list.FindStudent(spd);
            student.DisplayList();

            
            spd = student => student.age >= 18 ? true : false;
            student = list.FindStudent(spd);
            student.DisplayList();

            
            spd = student => student.FirstName[0] == 'A' ? true : false;
            student = list.FindStudent(spd);
            student.DisplayList();

            
            spd = student => student.LastName.Length > 3 ? true : false;
            student = list.FindStudent(spd);
            student.DisplayList();


           
            spd = student => student.age > 20 && student.age < 25 ? true : false;
            student = list.FindStudent(spd);
            student.DisplayList();

            
            spd = student => student.FirstName == "Andrew" ? true : false;
            student = list.FindStudent(spd);
            student.DisplayList();

            
            spd = student => student.LastName == "Troelsen" ? true : false;
            student = list.FindStudent(spd);
            student.DisplayList();

        }
    }
}
