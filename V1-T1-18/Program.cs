using System;

namespace V1_T1_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tulostaa kolmella jaolliset luvut 1-99");


            for (int x = 1; x < 100; x++)
            {

                double pariton = (x % 3);

                if (pariton == 0)
                {
                    Console.WriteLine(x);
                }
            }
            
        }
    }
}
