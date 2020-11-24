using System;

namespace V1_T2_04
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("Anna mitta tuumissa");
            int mittat = Convert.ToInt32(Console.ReadLine());
            double kerroin = 2.54;
            double sentit = mittat * kerroin;

            Console.WriteLine(mittat + "\"" + " on " + sentit + "cm");
               
              

        }
    }
}
