using System;

namespace V1_T1_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna Fahrenheim asteet");
            double fah = Convert.ToInt32(Console.ReadLine());
            double celsius = (fah - 32) /1.8;
            Console.WriteLine("Celsius " + celsius);
            
        }
    }
}
