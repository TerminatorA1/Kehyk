using System;

namespace V1_T1_07c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna Celsius asteet");
            double celsius = Convert.ToInt32(Console.ReadLine());
            double fah = (celsius * 1.8) + 32;
            Console.WriteLine("Fahrenheiteissa " + fah);
        }
    }
}
