using System;

namespace V1_T1_14
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Anna sana");
            string sana = Console.ReadLine();
            int pituus = (sana.Length - 1);

            char eka = sana[pituus];
            Console.Write(eka);

            for (int x = 1; x < pituus; x++)
            {


            Console.Write(sana[x]);
            }


            char vika = sana[0];
            
            Console.Write(vika);

        }
    }
}
