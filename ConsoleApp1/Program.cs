using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = InputIntNumber("метры      : ");
            int c = InputIntNumber("сантиметры : ");
            Console.WriteLine("==========================");
            OutPutInt(Centimeters(m, c));
            Console.Read();
        }
        static int Centimeters(int m,  int c)
        {
            return m * 100 + c;
        }
        static int InputIntNumber(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void OutPutInt(int message) { Console.WriteLine($"всего      : {message} см"); }
    }
}
