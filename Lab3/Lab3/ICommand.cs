using System;

namespace Lab3
{
    internal interface ICommand
    {
        public void Execute(Receiver receiver);
    }
}
