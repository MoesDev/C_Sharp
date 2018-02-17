using System;

namespace wizardNinjaSamurai
{

    public class Human{

        public string Name;
        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }

        public Human(string theName)
        {
            Name = theName;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
            Console.WriteLine($"Hello {Name}!");
        }
        public Human(string theName, int valS, int valI, int valD, int valH){
            Name = theName;
            strength = valS;
            intelligence = valI;
            dexterity = valD;
            health = valH;
        }
        /*public void Attack(Human theAttackedHuman){
            theAttackedHuman.health -= (strength*5);
        } */
        //Previously written as above - works, ... but assignment preferes it written as below...????
        public void Attack(object obj)
        {
            Human enemy = obj as Human;
            if (enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.health -= strength * 5;
            }
        }
    }
}
