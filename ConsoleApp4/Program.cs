using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        /// <summary>
        /// расчитать значение У определив и используя статический метод
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double y = Func(7, 3) + Func(11, 3) + Func(15, 3);
            Out(y);
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
            return (Math.Sqrt(x) + x) / y;
        }
        /// <summary>
        /// вывод результата
        /// </summary>
        /// <param name="message">double</param>
        static void Out (double message)
        {
            Console.WriteLine($"{message :f2}");
        }
    }
}
