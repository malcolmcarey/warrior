using System;
namespace interface_scatch
{
    public interface IDrivable
    {
        int Wheels { get; set; }
        double Speed { get; set; }
		void Move();
		void Stop();
    }
}
