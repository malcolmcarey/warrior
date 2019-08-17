using System;

namespace warrior
{
    class Program
    {
        static void Main(string[] args)
		{
			Warrior m = new Warrior("Mac", 1000, 120, 40);

			Warrior g = new Warrior("Garrett", 1000, 120, 40);

			Battle.StartFight(m, g);

			Console.ReadLine();
        }
    }
}
