using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TabuadaFor1a10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, r, n1;

            Console.WriteLine("Digite o número cuja tabuada seja exibida, do 1 até o 10.");
            n1 = int.Parse(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {

                //r = resultado da multiplicação; n1 = número digitado pelo user; i = multiplicador do multiplicando_
                r = (n1 * i);


                Console.WriteLine("{0} x {1} = {2}", n1, i, r);
            }

            Console.ReadKey();
        }
    }
}
