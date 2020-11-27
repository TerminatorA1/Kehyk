using System;

namespace V1_T2_08
{
    class Program
    {
        static void myMethod()
        {
            Console.WriteLine("Pienempi luku on ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku1");
            int luku1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna luku2");
            int luku2 = Convert.ToInt32(Console.ReadLine());
            if (luku1 < luku2)
            {
                myMethod();
                Console.Write(luku1);
            }
            else
             
            Console.Write("Pienempi luku " + luku2);
        }

    }
}
