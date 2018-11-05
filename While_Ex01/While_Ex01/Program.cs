using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace While_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
             int nums=1, soma2=0;

            while (nums<=12)
            {
               

                if (nums % 2 == 0)
                {
                 soma2 = soma2 + nums;
                }
                 nums += 1;
            }
            Console.WriteLine("A soma dos números pares de 1 a 50 é igual a " +soma2); 
            
            Console.ReadKey();
        }
    }
}
