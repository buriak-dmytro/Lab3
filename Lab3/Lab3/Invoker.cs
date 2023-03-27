using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Invoker
    {
        private Receiver receiver;

        public void Execute(string oper, double value)
        {
            ICommand command = new Command(receiver, oper, value);
            command.Execute(receiver);
        }
    }
}
