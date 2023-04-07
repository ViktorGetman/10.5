using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _10._5
{
    public class Calculator : IСalculator
    {
        ILogger Logger { get; }
        public Calculator(ILogger logger)
        {
            Logger = logger;
        }

        public void Calc()
        {
            while (true)
            {
                try
                {
                    Logger.Event("Введите первое число.");
                    int a = Int32.Parse(Console.ReadLine());
                    Logger.Event("Введите второе число.");
                    int b = Int32.Parse(Console.ReadLine());

                    int c = a + b;
                    Logger.Event($"Результат сложения чисел равен: \n{c}");
                    return;
                }
                catch (FormatException ex)
                {
                    Logger.Eror("Введено неверное значение.");
                }
            }
        }
    }
}
