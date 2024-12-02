using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        /// <summary>
        /// определить статическим методом int Centimeters (int m , int c), который принимает два целых аргумента (метры m , сантиметры c) и возвращает количество сантиметров 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int m = InputIntNumber("метры      : ");
            int c = InputIntNumber("сантиметры : ");
            Console.WriteLine("==========================");
            OutPutInt(Centimeters(m, c));
            Console.Read();
        }
        /// <summary>
        /// вычисление сантиметров из метров с добавлением сантиметров
        /// </summary>
        /// <param name="m">int</param>
        /// <param name="c">int</param>
        /// <returns>int</returns>
        static int Centimeters(int m,  int c)
        {
            return m * 100 + c;
        }
        /// <summary>
        /// ввод целого значения
        /// </summary>
        /// <param name="message">int</param>
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
        static void OutPutInt(int message) 
        { 
            Console.WriteLine($"всего      : {message} см");
        }
    }
}
