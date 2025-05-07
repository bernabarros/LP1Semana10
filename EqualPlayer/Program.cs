using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace EqualPlayer
{
    public class Program
    {
        private static void Main(string[] args)
        {
            HashSet<Player> setofPlayers = new HashSet<Player>(){new Player
            (PlayerClass.Tank, "Ana"), 
            new Player(PlayerClass.Slayer,"Paulo"),
            new Player(PlayerClass.Tank,"Ana")};

            foreach(Player p in setofPlayers)
            {
                Console.WriteLine($"{p.Name} is a {p.PClass}");
            }

            Player p1 = new Player(PlayerClass.Fighter, "Berna");
            Player p2 = new Player(PlayerClass.Fighter, "Berna");

            Console.WriteLine($"({p1.GetHashCode() == p2.GetHashCode()})");
            Console.WriteLine($"{p1.Equals(p2)}");
        }
    }
}
