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
        /// Определить статическим методом int Kop(int r, int k ) ,который принимает 2 целых аргумента (рубли r , копейки k ) и
        /// возвращает количество копеек .
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int r = InputIntNumber("рубли  :");
            int k = InputIntNumber("копейки:");
            Console.WriteLine("====================");
            OutInt(Kop(r, k));
            Console.Read();
        }
        /// <summary>
        /// вычисление монет из рублей с добавлением монет 
        /// </summary>
        /// <param name="r">int</param>
        /// <param name="k">int</param>
        /// <returns>int</returns>
        static int Kop(int r, int k) 
        {
            return r * 100 + k;
        }
        /// <summary>
        /// ввод челого числа 
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
        static void OutInt(int message)
        {
            Console.WriteLine($"копеек : {message}");
        }
    }
}
