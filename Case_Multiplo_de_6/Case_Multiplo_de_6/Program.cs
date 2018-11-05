using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Case_Multiplo_de_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, calc;

          
            Console.WriteLine("Digite um número para verificar se é ou não múltiplo de 6.");
            n = int.Parse(Console.ReadLine());

            calc = n % 6;


            switch (calc)

            {
                case 0:

                    Console.WriteLine("O número é múltiplo de 6.");
                    
                    
                    break;
                    
                default:
                    Console.WriteLine("O número não é múltiplo de 6.");
                   
                    break;
            }


            Console.ReadKey();



        }
    }
}
