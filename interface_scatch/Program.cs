using System;

namespace interface_scatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

			Vehicle v = new Vehicle("Buick", 4, 160);
			Vehicle x = new Vehicle("Chevy", 4, 100);

			Console.WriteLine("{0} is going {1} MPH", v.Brand, v.Speed);
			Console.WriteLine("{0} is going {1} MPH", x.Brand, x.Speed);

		}
	}
}
