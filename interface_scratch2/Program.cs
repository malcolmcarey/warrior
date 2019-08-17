using System;

namespace interface_scratch2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

			IElectronicDevice TV = TVRemote.GetElectronicDevice();
			PowerButton p = new PowerButton(TV);

			p.Execute();
			p.Undo();

            
        }
    }
}
