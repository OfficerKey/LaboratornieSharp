using System;
using System.Collections.Generic;
using System.Text;

namespace LR11V
{
    delegate void Vipolneno(bool be);
    class Client
    {
        public bool gorki { get; set; }
        public bool Tir { get; set; }
        public bool RoomFear { get; set; }
        public bool RoomMirror { get; set; }
        public bool Popkorn { get; set; }
        public bool Koleso { get; set; }
    }
    class PARK
    {
        private Client client { get; set; } = new Client();
        public void Gorki(bool be)
        {
            client.gorki = be;

        }
        public void tir(bool be)
        {
            client.Tir = be;

        }
        public void RoomFear(bool be)
        {
            client.RoomFear = be;

        }
        public void RoomMirror(bool be)
        {
            client.RoomMirror = be;

        }
        public void Popkorn(bool be)
        {
            client.Popkorn = be;

        }
        public void Koleso(bool be)
        {
            client.Koleso = be;

        }
        public void Display()
        {
            Console.WriteLine("Горки - " + client.gorki + "\nТир- " + client.Tir + "\nКомната страха - " + client.RoomFear + "\nКомната зеркал - " + client.RoomMirror + "\nПопкорн - " + client.Popkorn + "\nЧертово колесо - " + client.Koleso);
        }
    }
}
