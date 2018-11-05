using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sucessores_de_x
{
    class Program
    {
        static void Main(string[] args)
        {
            int x , cont, y;

            Console.WriteLine("Digite um Numero para saber seus 30 sucessores");
            x=int.Parse(Console.ReadLine());

            
            for (cont= 1; cont <= 30; cont++)
            {
                y = x + 1;
                Console.WriteLine("Sucessores deste número : ");
                Console.WriteLine("{0}",y);
                x = x + 1;
            }


            Console.ReadKey();
        }
    }
}
