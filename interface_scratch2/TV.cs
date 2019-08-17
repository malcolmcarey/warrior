using System;
namespace interface_scratch2
{
    public class TV : IElectronicDevice
    {
		public int Volume { get; set; }
		public PowerStatus Power { get; set; }

        public TV()
        {
			Volume = 0;
			Power = PowerStatus.Off;
        }

        public void On()
		{
			Power = PowerStatus.On;
			Console.WriteLine("The TV is On");
		}

        public void Off()
		{
			Power = PowerStatus.Off;
			Console.WriteLine("The TV is Off");
			//Volume = 0;
		}

        public void VolumeUp()
		{
			Volume++;
			Console.WriteLine($"Volume is increased to {Volume}");
		}

        public void VolumeDown()
		{
			Volume--;
			Console.WriteLine($"Volume is reduced to {Volume}");
		}
    }

	public enum PowerStatus
	{
		Off = 0,
		On = 1
	}
}
