using System;

namespace V1_T1_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tulostaa parittomat luvut 1-99");


            for (int x = 1; x < 100; x++)
            {

                double pariton = (x % 2);

                if (pariton > 0)
                {
                    Console.WriteLine("Pariton " + x);
                }
            }

        }
    }
}
