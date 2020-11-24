using System;

namespace V1_T2_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kokonaisluku1");
            int luku1 = Convert.ToInt32(Console.ReadLine());
            int pluku = 3;
            int yluku = 9;
            bool vastaus = true;

            {
                if (luku1 > 3 && luku1 < 9)
                {
                    
                    Console.WriteLine(pluku + "<" + luku1 + "<" + yluku);
                    Console.WriteLine(vastaus);
                }
                else
                {
                    vastaus = false;
                    Console.WriteLine(vastaus);
                    Console.WriteLine(luku1 + " ei ole välillä 3-9");

                }
            }
            
        }
    }
}
