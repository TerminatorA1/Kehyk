using System;

namespace V1_T2_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kokonaisluku1");
            int luku1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna kokonaisluku2");
            int luku2 = Convert.ToInt32(Console.ReadLine());
            bool vastaus = true;

            Console.WriteLine(luku1);
            Console.WriteLine(luku2);

            
            {
                if (luku1 == luku2)
                {
                    Console.WriteLine(vastaus);
                    Console.WriteLine("Luvut ovat yhtä suuria");
                    
                }
                else
                {
                    vastaus = false;
                    Console.WriteLine(vastaus);
                    Console.WriteLine("Luvut ovat eri suuria");
                    
                }
            }

            
        }
    }
}
