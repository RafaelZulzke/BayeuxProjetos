
#include<stdio.h> 
#include <stdlib.h>

main()
{
int numero;      
 printf ("Digite um numero \n");
 scanf("%d",&numero);
if (numero < 10 )
 {
  printf("o numero digitado e menor que 10\n");
  printf("a divisao do numero por 2 resulta %d\n",numero/2);
 }
 else
 if (numero < 20 )
 {printf("o numero digitado e menor que 20\n");
   printf("a divisao do numero por 4 resulta %d\n",numero/4);
   }
  else 
   if ((numero > 30 ) and (numero <40))
 {printf("o numero digitado e maior que 30 e menor que 40\n");
   printf("a multiplicacao do numero por 2 resulta %d\n",numero*2);
   }
   else
     printf("numero digitado fora do padrao\n");
   
system("pause"); 
}
