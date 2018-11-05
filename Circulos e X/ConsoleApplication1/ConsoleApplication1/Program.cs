using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            float raio;
              double  comp, area, volume;

            Console.WriteLine("Digite o raio.");
        raio = float.Parse(Console.ReadLine());

        comp = (2*3.14)*raio;
        area = 3.14*(raio*raio);
        volume = (4*3.14* Math.Pow(raio, 3)/3);

        Console.WriteLine("O comprimento da circunferência é : " +comp);
        Console.WriteLine("A área da circunferência é : " +area);
        Console.WriteLine("O volume da esfera é : " + Math.Round(volume, 2));

      

        Console.ReadKey();
    
      
        }
    }
}
