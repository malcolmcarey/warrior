using System;
namespace interface_scatch
{
    public class Vehicle : IDrivable
    {

        public string Brand { get; set; }
        public int Wheels { get; set; }
        public double Speed { get; set; }

		public Vehicle()
			: this("No Brand", 4, 0) { }

		public Vehicle(string brand = "No Brand")
			: this(brand, 4, 0) { }

        public Vehicle(string brand = "No Brand", int wheels = 4) :
            this(brand, wheels, 0)
		{ }

        public Vehicle(string brand = "No Brand", int wheels = 4, double speed = 0)
		{
			Brand = brand;
			Wheels = wheels;
			Speed = speed;
		}

        public void Move()
		{
			Speed++;
		}

        public void Stop()
		{
			Speed = 0;
		}
    }
}
