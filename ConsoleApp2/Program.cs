using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        /// <summary>
        /// найти минимальное из 3х целых чисел, исползуя вспомогательные методы
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = InputIntNumber("А = ");
            int b = InputIntNumber("B = ");
            int c = InputIntNumber("C = ");
            OutInt(Min(Min(a, b) ,c));
            Console.Read();
        }
        /// <summary>
        /// расчет минимального из 2х чисел
        /// </summary>
        /// <param name="a">int</param>
        /// <param name="b">int</param>
        /// <returns>int</returns>
        static int Min(int a, int b) 
        {
            return (a < b) ? a : b;
        }
        /// <summary>
        /// ввод значений целого типа
        /// </summary>
        /// <param name="message">string</param>
        /// <returns>int</returns>
        static int InputIntNumber(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// вывод значений 
        /// </summary>
        /// <param name="message">int</param>
        static void OutInt(int message)
        {
            Console.WriteLine($"минимальное : {message}");
        }
    }
}
