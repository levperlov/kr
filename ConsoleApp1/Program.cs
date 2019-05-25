using ConsoleApp1.classes;
using System;
using System.Collections.Generic;

namespace ConsoleApp1

{
    internal class Program
    {
        private static readonly Random random = new Random();
        public static List<Zombi> zombis = new List<Zombi>();
        static List<player> players = new List<player>();
        static int v = random.Next(3);
        static double minuc = new double[4];

        private static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                if (v == 1)
                {
                    zombis.Add(new Zombi());
                    
                }
                if (v == 2)
                {
                    zombis.Add(new oxotnik());
                     
                }
                if (v == 3)
                {
                    zombis.Add(new plevalchik());
                     
                }
                 
                players.Add(new player());
                players.Add(new player());
                players.Add(new player());
                players.Add(new player());
                players.Add(new player());
                players.Add(new player());
                players.Add(new player());
                players.Add(new player());
                players.Add(new player());

            }
            foreach (Zombi item in zombis)
            {
                item.about();
            }
            foreach (var  item in players )
            {
                int i = 0;
                i++;
                if (i >=4)
                {
                    minuc[i] = item.Attac();

                }
                  
                
            }




        }
    }
}
