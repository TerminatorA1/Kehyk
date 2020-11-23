using System;

namespace V1_T1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku1");
            double luku1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna luku2");
            double luku2 = Convert.ToInt32(Console.ReadLine());

            double jakoj = luku1 % luku2;
            Console.WriteLine("Jakojäännös " + jakoj);
            
        }
    }
}
