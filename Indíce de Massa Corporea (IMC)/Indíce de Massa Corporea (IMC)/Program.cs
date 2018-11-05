using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indíce_de_Massa_Corporea__IMC_
{
    class Program
    {
        static void Main(string[] args)
        {
            double pid = 0,
                   alt;
            string sx;

            Console.WriteLine("Digite o seu sexo <M> ou <F>");
            sx = (Console.ReadLine());

            Console.WriteLine("Digite sua altura");
            alt = double.Parse(Console.ReadLine());


            if ((sx == "m") || (sx == "M"))
            {
                pid = (72.5 * alt) - 59;
            }
            else
                if ((sx == "f") || (sx == "F"))
                {
                    pid = (62.1 * alt) - 44.7;
                }
                else
                    if ((sx != "m") || (sx != "f")||(sx != "M")||(sx != "F"))
            {
                Console.WriteLine("\tSexo inválido.");
            
            }

             if ((sx == "f") || (sx == "F")||(sx == "M")||(sx == "m"))
            Console.WriteLine("\t Seu peso ideal é : {0} kilos", string.Format("{0:0.##}", pid));
            Console.WriteLine("\t\tObrigado por usar nosso programa.");
            Console.ReadKey();
        }
    }
}
