using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        /// <summary>
        /// расчитать значение x определив и используя статический метод
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double x = Func(15, 8) + Func(6, 12) + Func(7, 21);
            Out(x);
            Console.ReadLine();
        }
        /// <summary>
        /// основная функция
        /// </summary>
        /// <param name="x">double</param>
        /// <param name="y">double</param>
        /// <returns>double</returns>
        static double Func(double x, double y)
        {
            return (x + Math.Sqrt(y)) / (y + Math.Sqrt(x));
        }
        /// <summary>
        /// вывод результата
        /// </summary>
        /// <param name="message">double</param>
        static void Out(double message)
        {
            Console.WriteLine($"{message:f2}");
        }
    }
}
