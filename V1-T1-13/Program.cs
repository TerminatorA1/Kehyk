using System;

namespace V1_T1_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna jokin kokonaisluku 11-20");
            double luku1 = Convert.ToInt32(Console.ReadLine());

                int x = 0;
                int x2 = 1;
                int l = 0;
                do
                {
                    Console.Write(luku1 + " ");
                x++;
                }
                while (x < luku1) ;
            Console.WriteLine(" ");


                do

                {
                Console.Write(luku1);
                x2++;
                l++;
                }
                while (x2 < luku1);
                  
                    
            
            
        }
    }
}
