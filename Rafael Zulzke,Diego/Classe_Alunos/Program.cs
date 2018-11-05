using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classe_Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade=0, contf=0,contm=0,numaMpmaior80=0, numaFpmenor59=0, cont=0, contALmasc80, contALfem59;
            string sx="";
            double pesomedio=0, porcSF,p;

            for (cont = 1; cont <= 6; cont++)
            {
                               
                Console.WriteLine("Digite o sexo do usuário. <<M>> ou <<F>>");
                sx = Console.ReadLine();
               

                Console.WriteLine("Digite o Peso do Aluno.");
                p = double.Parse(Console.ReadLine());
                
                
                    porcSF=(100*contf)/6;

                   /*if (pf<59)
                {
                    contALfem59=contf;

                    numaFpmenor59=contALfem59;
                }
                       
                    }  */         

            
               pesomedio = p/ 6;
                 if ((sx=="M")||(sx=="m"))
                {
                contm=contm++;   

                if (p>80)
                {

                    contALmasc80 = contm + p;
                        numaMpmaior80=contALmasc80;
                }
                    }
            }
 
            Console.WriteLine("Porcentagem de Mulheres :" +porcSF);
            Console.WriteLine("Peso Medio :"+pesomedio);


                Console.ReadKey();

            }
        }
    }

