using System;

namespace V1_T1_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kokonaisluku1");
            int luku1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna kokonaisluku2");
            int luku2 = Convert.ToInt32(Console.ReadLine());

            while (luku1 > 0)
            {
                if (luku2 > 0)
                {
                    Console.WriteLine("Molemmat ovat positiisia");
                    break;
                }
                if (luku2 < 0)
                {
                    Console.WriteLine("Toinen on positiivinen ja toinen negatiivinen");
                    break;
                }
                else
                {
                    Console.WriteLine("Molemmat ovat negatiivisia");
                    break;
                }
            }
               


            

           
        }
    }
}
