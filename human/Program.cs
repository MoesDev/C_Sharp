using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Human player1 = new Human("Doug");
            Human player2 = new Human("Terry");

            Console.WriteLine("New players are {0} and {1}", player1.name, player2.name);

            Console.WriteLine("{0} has {1} strength and {2} health", player1.name, player1.strength, player1.health);
            Console.WriteLine("{0} has {1} strength and {2} health", player2.name, player2.strength, player2.health);
            player1.Attack(player2);

            Console.WriteLine("{0} ATTACKS {1}!!!", player1.name, player2.name);
            Console.WriteLine("{0} has {1} strength and {2} health", player1.name, player1.strength, player1.health);
            Console.WriteLine("{0} has {1} strength and {2} health", player2.name, player2.strength, player2.health);

        }
    }
}
