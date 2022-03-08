using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Player
    {
        public int ID { get; set; }//0 is player
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxDamage { get; set; }

        public Player()
        {

        }

        public Player(int iD, string name, int health, int maxDamage)
        {
            ID = iD;
            Name = name;
            Health = health;
            MaxDamage = maxDamage;
        }
    }
}
