using System;

namespace V1_T1_03c
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 8;
            int y = 5;
            int z1 = x + y;
            int z2 = x - y;
            int z3 = x * y;
            float z4 = x / y;
            Console.WriteLine("Summa " + z1);
            Console.WriteLine("Vähennys " + z2);
            Console.WriteLine("Kerto " + z3);
            Console.WriteLine("Jako " + (z4));
        }
    }
}
