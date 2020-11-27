using System;

namespace V1_T2_10
{
    class Program
    {
        static void myMethod()
        {
            Console.WriteLine("Summa on");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku1, josta lasketaan kertoma");
            int luku1 = Convert.ToInt32(Console.ReadLine());
            int summa = 1;
            int laskin = 1;
            do
            {
                summa = summa * laskin;
                Console.Write(summa);
                laskin++;
            }
            while (luku1 >= laskin);
            {
                Console.WriteLine("Summa on " + summa);
            }
            
        
          
        }
    }
}
