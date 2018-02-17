using System;
using System.Collections.Generic;
using System.Text;

namespace wizardNinjaSamurai
{
    class Ninja : Human
    {
        public Ninja(string nijName) : base(nijName)
        {
            Console.WriteLine($"{nijName} is a Ninja!");
            dexterity = 175;
        }
        public void Steal(object obj)
        {
            Human enemy = obj as Human;
            health += 10;
            enemy.health -= 10;
            Console.WriteLine($"{Name} Steals Health!!! {enemy.Name} now only has {enemy.health} health!");
        }
        public void Get_Away()
        {
            Console.WriteLine($"{Name} Gets Away from Attack!!!");
            health -= 15;
        }

    }
}
