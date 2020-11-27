using System;

namespace V1_T2_09
{
    class Program
    {
        static void myMethod()
        {
            Console.WriteLine("Summa on");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku1");
            int luku1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna luku2, luku1 potenssiin luku2");
            int luku2 = Convert.ToInt32(Console.ReadLine());
            int valisumma = luku1;
            int laskin = 1;
            if (luku2 == 1)
            {
                myMethod();
                Console.Write(luku1);
            }
            else if (laskin < luku2)
                {
                laskin++;
                valisumma = valisumma * luku1;
                Console.Write(valisumma);
                }
            else 
            {
                Console.Write("Summa on " + valisumma);
            }
        }
        
    }
}
