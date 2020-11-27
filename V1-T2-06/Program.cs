using System;

namespace V1_T2_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna nykyinen aika, ensin tunnit");
            int tunnit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna nykyinen aika, minuutit");
            int minuutit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Annetaanko tänään kulunut aika muodossa 1. tunti, 2. minuutti vai 3. sekuntti ?");
            int muutos = Convert.ToInt32(Console.ReadLine());
            int tuntim = 60;
            int minuuttis = 60;
            int sekunnit = (tunnit * tuntim) + (minuutit * minuuttis);
         switch (muutos)
            {
                case 1:
                    Console.WriteLine(tunnit + "," + minuutit/tuntim + " tuntia");
                    break;
                case 2:
                    Console.WriteLine((tunnit*tuntim + minuutit) + " minuuttia");
                    break;
                case 3:
                    Console.WriteLine((tunnit * tuntim * minuuttis + minuutit * minuuttis) + " sekuntia");
                    break;
            }
            
            
            
            
            
        }
    }
}
