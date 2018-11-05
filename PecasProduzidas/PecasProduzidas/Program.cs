using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PecasProduzidas
{
    class Program
    {
        static void Main(string[] args)
        {
            int ppd=0, pd=0, tpds =0, contd=0, pb=0,tpbs=0;
            double mpd=0, porcdps=0, porcbps=0;

            // CONTADOR PARA OS DIAS (5)
             for (contd = 1; contd <= 5; contd++)
            {
                    //SOLICITAÇÃO DE DO Nº DE PECAS PRODUZIDAS NO DIA
                    Console.WriteLine("Quantas peças foram produzidas no dia?");
                        ppd = int.Parse(Console.ReadLine());

                 //SOLICITAÇÃO DE PEÇAS DEFEITUOSAS EM MEIO AS PRODUZIDAS
                    Console.WriteLine("Quantas dessas peças são defeituosas?");
                        pd = int.Parse(Console.ReadLine());

                /*CALCULO DE TOTAL DE PECAS BOAS NA SEMANA, SENDO QUE PPD É O Nº DE PEÇAS PRODUZIDAS EM UM DIA (QUE SE REPETE 5 VEZES, ACUMULANDO). 
                ESTE ACUMULADOR DEFINE O TOTAL DE PECAS BOAS NA SEMANA COMO SENDO O PRÓPRIO MAIS O NUMERO DE PECAS PRODUZIDAS EM UM DIA.*/
                             tpbs = tpbs + ppd;

                 /*CALCULO DE TOTAL DE PECAS DEFEITUOSAS, SENDO QUE PD É O Nº DE PEÇAS DEFEITUOSAS PRODUZIDAS EM UM DIA (QUE SE REPETE 5 VEZES, ACUMULANDO). 
                  ESTE ACUMULADOR DEFINE O TOTAL DE PECAS DEFEITUOSAS NA SEMANA COMO SENDO O PRÓPRIO MAIS O NUMERO DE PECAS DEFEITUOSAS PRODUZIDAS EM UM DIA. */
                             tpds = tpds + pd;             
             }

                // CALCULO DE MEDIA DE PECAS DIARIA, QUE É O TOTAL DE PEÇAS BOAS NA SEMANA / 5 (QUE É O NUMERO DE DIAS DA SEMANA) 
                mpd = tpbs / 5;

                // CALCULO DE PORCENTAGEM DE PEÇAS DEFEITUOSAS, QUE É NUMERO DE PECAS PRODUZIDAS EM UM DIA*100 / NUMERO DE PECAS PRODUZIDAS EM UM DIA (QUE SERÃO 5 DIAS)
                porcdps = pd*100 / (ppd);

                // CALCULO DO NUMERO DE PECAS BOAS, QUE É O TOTAL DE PECAS  PRODUZIDAS EM UM DIA ( QUE SERÃO 5)- PEÇAS DEFEITUOSAS
                pb = ppd - pd;

                //
                porcbps = (pb *100) / ppd;

                    Console.WriteLine("Foram produzidas {0} peças na semana", tpbs);
                    Console.WriteLine("A Média  de Produçaõ Diaria foi de {0} na semana", mpd);
                    Console.WriteLine("A Porcentagem de Peças Defeituosas é {0} % na semana",porcdps);
                    Console.WriteLine("A Porcentagem de Peças Boas é {0} % na semana",porcbps);

                        Console.ReadKey();


            }



















        }
    }

