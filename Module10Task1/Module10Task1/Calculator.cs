using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module10Task1
{
    internal class Calculator : IOperation
    {
        public ILogger Logger { get; }

        public Calculator(ILogger log)
        {
            Logger = log;
        }
        public double InputNumber(string? num)
        {
            if (double.TryParse(num, out var x))
            {
                Logger.Event("Число введено корректно.\n");
               
            }
            else throw new Exception("Ошибка ввода числа. Попробуйте снова.");

            return x;

        }
        double IOperation.Additional(double x, double y)
        {
            return x + y;
        }
    }
}
