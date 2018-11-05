using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            int b, a;
            float area;

            //Entrada de Dados
            Console.WriteLine("Insira o valor da base:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor da altura:");
            a = int.Parse(Console.ReadLine());

            //Cálculos
            area = (b + a) / 2;

            //Resultados
            Console.WriteLine("Área do Triângulo: " + area);

            //Parar Sistema 
            Console.ReadKey();
        }
    }
}
