using System;

namespace V1_T2_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kokonaisluku1");
            int luku1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna kokonaisluku2");
            int luku2 = Convert.ToInt32(Console.ReadLine());
            int jakoj = luku1 % luku2;

            Console.WriteLine(luku1);
            Console.WriteLine(luku2);


            

            Console.WriteLine("Jakojäännös on " + jakoj);
        }
    }
}
