using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delta
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            
            
            
            
            //Variáveis
            double a, b, c, delta, baskara, baskara1, baskara2; 
             
            //Inserção de Dados
            Console.WriteLine("Insira o valor de a                                ");
            a= double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de b"                                );
            b= double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de c"                                );
            c= double.Parse(Console.ReadLine());

            //Se os valores a serem lidos serem iguais a zero, não será possível fazer o cálculo.
            if (a == 0 && b == 0 && c == 0)

            {
                //Som intuitivo caso os valores das variáveis A, B e C sejam i
                Console.WriteLine("A, B e C devem ser diferentes de zero!");
                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("o o        . .");
                Console.WriteLine(" )          ) ");
                Console.WriteLine("___        ###");
                for (int i = 0; i < 20; i++)
                {
                Console.MoveBufferArea(i + 11, i, 13, 13, i + 12, i +'x', ConsoleColor.Red, ConsoleColor.DarkBlue);
                    Console.MoveBufferArea(i, i, 13, 13, i + 11, i + 11);
                    Console.Beep((i + 10) * 100, 100);
                }
                Console.SetCursorPosition(0, 30);
            }
            else
            {
                delta = (Math.Pow(b,2)-4*a*c);

            if (delta < 0)
            {
                Console.WriteLine("Delta não pode ser menor que 0!");
            }
            else if (delta ==0 )
            {
                baskara = -b/(2*a);
           
            }
            else
            {
                baskara1 = (-b + Math.Sqrt(delta))/(2*a);
                baskara2 = (-b - Math.Sqrt(delta))/(2*a);
                Console.WriteLine(String.Format("Os valores {0} e {1} são raízes:", baskara1, baskara2));
                Console.WriteLine(" ");
                //{0},{1},{2}", R1,R2,R3); --> Caso queira informar os valores em um único Console.WriteLine - Em vez de vírgulas, pode ser "e"
                //COnsole.WriteLine("As raízes da equação são: {0},{1}", baskara1, baskara2);
            }
            
            

            //Resultados
            Console.WriteLine("O valor do delta é :"+delta);
            Console.WriteLine("Obrigado por usar nosso Programa");
           

            //Parada
            
           
                Console.ResetColor();
                Console.ReadKey();
            
            //Programadores Diego & RafaelZulzke


        }
    }
    }
}