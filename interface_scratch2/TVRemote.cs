using System;
namespace interface_scratch2
{
    class TVRemote
    {
        public static IElectronicDevice GetElectronicDevice()
		{
			return new TV();
		}
    }
}
