using System;

namespace V1_T1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku1 1-10");
            double luku1 = Convert.ToInt32(Console.ReadLine());

            for (int x = 1; x < 11; x++)
            {
            
            double kerto = luku1 * x;
            Console.WriteLine("Kertolasku " + luku1 + "*" + x + "=" + kerto);
            }
        }
    }
}
