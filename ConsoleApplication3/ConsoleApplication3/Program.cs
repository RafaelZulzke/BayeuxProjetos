using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbois = 0, pesobmg = 0, pesobmm = 9999;
            double mediapb = 0;
            int pesob = 0, somapb = 0;
            string bid;

            // LER AS ID's e os PESOS 
            for (nbois = 1; nbois <= 6; nbois++)
            {
                Console.WriteLine("Entre com a ID do boi.");
                bid = Console.ReadLine();

                Console.WriteLine("Entre com o peso o boi.");
                pesob = int.Parse(Console.ReadLine());


                //determinação maior e menor

                somapb = somapb + pesob;

                if (pesob >= pesobmg)
                {
                    pesobmg = pesob;
                }
                if (pesob <= pesobmm)
                {
                    pesobmm = pesob;
                }
            }


            // media dos pesos, soma de todos os pesos e a escrita dos peso do boi mais leve e do mais pesado
            mediapb = somapb / 6;


            Console.WriteLine("A média dos pesos de todos os bois é : {0} ", mediapb);
            Console.WriteLine("A soma total dos pesos de todos os bois é  {0}: ", somapb);
            Console.WriteLine("O peso do boi mais leve é : {0} Kg", pesobmm);
            Console.WriteLine("O peso do boi mais pesado é : {0} Kg", pesobmg);

            Console.ReadKey();
        }
    }
}
