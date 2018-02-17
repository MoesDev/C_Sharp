using System;
using System.Collections.Generic;
using System.Text;

namespace wizardNinjaSamurai
{
    class Samurai :Human
    {
        private static int _countSamurai = 0; 
        public Samurai(string samuName) : base(samuName)
        {
            Console.WriteLine($"{samuName} is a Samurai!");
            health = 200;
            _countSamurai++;
        }

        public void Death_Blow(object obj)
        {
            Human enemy = obj as Human;
            if (enemy.health < 50)
            {
                enemy.health = 0;
                Console.WriteLine($"{enemy.Name} has received a Death Blow! Health is {enemy.health}");
            }
        }

        public void Meditate()
        {
            health = 200;
            Console.WriteLine($"After mediation {Name} is back at {health} health.");
        }

        public void How_Many()
        {
            Console.WriteLine("{0} asked... This game contains: {1} Samurai", Name, _countSamurai);
        }
    }
}
