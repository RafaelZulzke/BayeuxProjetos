using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tabuada1ao10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0, nm=0, r=0;


            Console.WriteLine("Digite o número a ser exibida sua respectiva tabuada.");
            n = int.Parse(Console.ReadLine());

           

            while (nm <= 9)
            {

                nm += 1;

                r = n *nm;

                Console.WriteLine(" {0} x {1} = {2} ",n, nm, r);
            }

            Console.ReadKey();




        }
    }
}
