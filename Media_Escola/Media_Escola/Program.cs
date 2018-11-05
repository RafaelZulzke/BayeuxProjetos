using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Media_Escola
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;
            float md;

            Console.WriteLine("Digite a primeira nota");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota");
            n4 = int.Parse(Console.ReadLine());

            md = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("Media igual = " + md);

            Console.ReadKey();
            
        }
    }
}
