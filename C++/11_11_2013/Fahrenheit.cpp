#include <stdio.h>
#include <stdlib.h>

//Vari�veis
float Gc, Fh;

//Inicio
main()
{
printf("Digite a temperatura atual em graus celsius\n");
scanf("%f",&Gc);

//C�lculos
Fh = ((9*Gc+160)/5);

//Resultados
printf("\n");
printf("A temperatura inserida em Graus Fahrenheit e %2.2f\n",Fh);

//Parada
system("pause");

//Programadores
//DanielGalhardi&RafaelZulke      
      
      }
