using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Correção
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, pesoI = 0;
            string sexo;

            Console.WriteLine("Digite a altura");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o sexo");
            sexo=Console.ReadLine();

            if ((sexo=="m")||(sexo=="M"))
            {
            pesoI=(72.5*altura)-59;
            }
            else
            {
            if ((sexo=="f")|| (sexo=="F"))
            {
                pesoI=(62.1*altura)-44.7;
            }
            }
            Console.WriteLine("\t Seu peso ideal é : {0} kilos", string.Format("{0:0.##}", pesoI));
            Console.ReadLine();
        }
    }
}
