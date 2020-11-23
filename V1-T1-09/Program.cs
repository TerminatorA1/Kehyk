using System;

namespace V1_T1_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku1");
            double luku1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna luku2");
            double luku2 = Convert.ToInt32(Console.ReadLine());

            double summa = luku1 + luku2;
            double miinus = luku1 - luku2;
            double kerto = luku1 * luku2;
            double jako= luku1 / luku2;
            Console.WriteLine("Summa " + summa);
            Console.WriteLine("Miinus " + miinus);
            Console.WriteLine("Kerto " + kerto);
            Console.WriteLine("Jako " + jako);
        }
    }
}
