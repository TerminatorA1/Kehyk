using System;

namespace V1_T2_07
{
    class Program

    {
        static void myMethod()
        {
            Console.WriteLine("Joukkue on kerännyt pisteitä ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Anna jalkapallojoukkueen voittojen määrä");
            int voitot = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna jalkapallojoukkueen tasapelien määrä");
            int tasurit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna jalkapallojoukkueen tappioiden määrä");
            int tappiot = Convert.ToInt32(Console.ReadLine());
            int yhteensa = (3 * voitot + 1 * tasurit);
            {
                myMethod();
                Console.WriteLine(yhteensa);
            }
            
        }
    }
}
