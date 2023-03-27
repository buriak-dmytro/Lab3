using System;
using System.Windows.Controls;

namespace Lab3
{
    internal class Receiver
    {
        private double result = 0;

        public void Action(string oper, double value)
        {
            switch (oper)
            {
                case "+":
                    result += value;
                    break;
                case "-":
                    result -= value;
                    break;
                case "*":
                    result *= value;
                    break;
                case "/":
                    result /= value;
                    break;
                default:
                    break;
            }
        }
    }
}
