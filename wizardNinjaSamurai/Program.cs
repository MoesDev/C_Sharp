using System;

namespace wizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Human todd = new Human("Todd");

            // Wizards

            Wizard will = new Wizard("Will");

            Wizard rich = new Wizard("Richard");
            Console.WriteLine($"{rich.Name} has {rich.strength} strength, {rich.health} health, {rich.intelligence} intelligence and {rich.dexterity} dexterity.");

            Console.WriteLine("After being healed....");
            rich.Heal();
            Console.WriteLine($"{rich.Name} has {rich.strength} strength, {rich.health} health and {rich.dexterity} dexterity.");

            //Ninjas

            Ninja lee = new Ninja("Lee");
            Console.WriteLine($"{lee.Name} has {lee.health} health and {lee.dexterity} dexterity.");

            lee.Steal(will);
            Console.WriteLine($"{lee.Name} has {lee.health} health.");
            lee.Get_Away();
            Console.WriteLine($"{lee.Name} is now at {lee.health} health.");

            // Samurai
            Samurai sam = new Samurai("Sam");
            sam.How_Many();
            sam.Death_Blow(will);
            Samurai ry = new Samurai("Ryan");
            lee.Steal(ry);
            ry.Meditate();
            ry.How_Many();
            


        }        
    }
}
