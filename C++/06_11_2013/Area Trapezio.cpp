#include<stdio.h>
#include<stdlib.h>

main()
{
      //Variáveis
      float A,Bmn,Bm,At;
      
      //Inserção de Dados
      printf("Digite a altura do trapezio\n");
      scanf("%f",&At);
      printf("\n");
      printf("\n");
      
      printf("Digite o tamanho da base menor\n");
      scanf("%f",&Bmn);
      printf("\n");
      
      printf("Digite o tamanho da base maior\n");
      scanf("%f",&Bm);
      //Calculos
       A = (((Bmn+Bm)*At)/2);
       
       //Resultados
       printf("\nA area do trapezio e %2.2f",A);
       printf("\n");
       //Parada
       system("pause");
       
       //Criador
       //DanielGalhardi&RafaelZulzke
      }
