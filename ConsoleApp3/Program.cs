using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        /// <summary>
        /// расчитать значение z = Min( 2a , b + a) + Min(2a - b, b), определив и используя функцию Min(x,y) - минимальное из двух чисел
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = InputIntNumber("A = ");
            int b = InputIntNumber("B = ");
            int z = Min(a * 2, b + a) + Min(a * 2 - b, b);
            Out(z);
            Console.Read();
        }
        /// <summary>
        /// минимальное из 2 целых
        /// </summary>
        /// <param name="a">int</param>
        /// <param name="b">int</param>
        /// <returns>int</returns>
        static int Min(int x, int y)
        {
            return (y > x) ? x : y;
        }
        /// <summary>
        /// ввод челого числа
        /// </summary>
        /// <param name="mesage">int</param>
        /// <returns>int</returns>
        static int InputIntNumber(string mesage)
        {
            Console.Write(mesage);
            return int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// вывод значений
        /// </summary>
        /// <param name="message">int</param>
        static void Out(int message)
        {
            Console.WriteLine($"ответ : {message}");
        }
    }
}
