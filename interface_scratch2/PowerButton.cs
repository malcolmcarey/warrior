using System;
namespace interface_scratch2
{
    public class PowerButton : ICommand
    {
		IElectronicDevice device;

        public PowerButton(IElectronicDevice ed)
        {
            this.device = ed;
        }

        public void Execute()
		{
			device.On();
		}

        public void Undo()
		{
			device.Off();
		}
    }
}
