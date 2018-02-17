using System;
using System.Collections.Generic;
using System.Text;

namespace wizardNinjaSamurai
{
    public class Wizard : Human
    {
        public Wizard(string wizName) : base(wizName)
        {
            Console.WriteLine($"{wizName} is a Wizard!");
            health = 50;
            intelligence = 25;
        }        
        public void Heal()
        {
            health += (10 * intelligence);
        }

        public void Fireball(object obj)
        {
            Human enemy = obj as Human;
            Random fireballNum = new Random();
            enemy.health -= fireballNum.Next(20, 51);
            Console.WriteLine($"{enemy.Name} was hit by a fireball and their health is now {enemy.health}");
        }


    }
}
