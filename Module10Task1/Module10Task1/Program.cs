using Module10Task1;
using System;

namespace Module10_Task1
{

    public class Program
    {
        static ILogger? Logger { get; set; }

        public static void Main(string[] args)
        {
            Logger = new Logger();

            Calculator calculator = new Calculator(Logger);

            while (true)
            {
                try
                {
                    Console.Clear();

                    Console.WriteLine("Введите первое число: ");

                    var x = calculator.InputNumber(Console.ReadLine());

                    Console.WriteLine("Введите второе число: ");

                    var y = calculator.InputNumber(Console.ReadLine());

                    Console.WriteLine("Результат сложения: " + ((IOperation)calculator).Additional(x, y));

                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.Clear();

                    Console.WriteLine();

                    Logger.Error(ex.Message);

                    Console.ReadKey();

                }
              
            }
          
        }

    }

}

