using System;
namespace interface_scratch2
{
    public interface ICommand
    {
		void Execute();
		void Undo();
    }
}
