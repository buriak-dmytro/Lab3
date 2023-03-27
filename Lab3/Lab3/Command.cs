using System;

namespace Lab3
{
    internal class Command : ICommand
    {
        private Receiver receiver;
        private string oper;
        private double value;

        public Command(Receiver receiver, string oper, double value)
        {
            this.receiver = receiver;
            this.oper = oper;
            this.value = value;
        }

        public void Execute(Receiver receiver)
        {
            receiver.Action(oper, value);
        }
    }
}
