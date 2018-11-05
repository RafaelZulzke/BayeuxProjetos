using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Correção_Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, cm=0, cf=0, cfp=0;
            string sexo;
            float peso, acmp=0, pm, pf;

            for (i=1;i<=6;i++)
            {
                Console.WriteLine("Informe os sexo do aluno.");
                sexo = Console.ReadLine();
                Console.WriteLine("Informe o peso do aluno.");
                peso = float.Parse(Console.ReadLine());

                acmp=acmp+peso; // soma de todos os pesos

                if ((sexo == "M") || (sexo == "m")) // SE O SEXO FOR MA
                {
                    if (peso>80) // se o peso digitado for maior que 80. NESTE CASO, INCLUÍMOS UM IF DENTRO DE OUTRO IF ( PESO MAIOR QUE 80 DENTRO DO IF PARA DEFINIR SE É MASCULINO)
                    {
                        cm = cm+1; // contador do nº de homens com peso maior que 80Kg
                    }
                }
//_______________________________________________________________________________________________________________________________________________________________________________
               
                else
                    if ((sexo == "f") || (sexo == "F"))
                {
                    cf = cf+1; // Contador de mulheres (sexo feminino)

                    if(peso<59)
                    {
                        cfp=cfp+1; // Contador do nº de mulheres com peso menor que 59 Kg
                    }
                }
            }

            pm = (acmp / 6); // Cálculo de Peso Médio
                pf = cf*100/6; // Cálculo de da Porcentagem de Mulheres. Utiliza-se o cont de mulheres * 100 / 6 (TOTAL DE ALUNOS)

            Console.WriteLine("Peso médio da sala" + pm);
            Console.WriteLine("Nº de homens com peso >80 Kg" + cm);
            Console.WriteLine("% de mulheres " + pf);
            Console.WriteLine("Nº de mulheres com peso <59 Kg" + cfp);
        }
    }
}
