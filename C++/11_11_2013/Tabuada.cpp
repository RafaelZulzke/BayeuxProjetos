#include <stdlib.h>
#include <stdio.h>
#include <math.h>

main()
{    
     //Variáveis
      int A,B,C,D;
      
    //Inserção de Dados e Descrição
    printf("Bem vindo ruim de conta, sou o robo Edy, nesse momento vou facilitar sua vida!");
    printf("\n");
    printf("Qual tabuada voce gostaria de conhecer?\n");
    scanf("%d",&A);
    printf("Voce quer ver a tabuada desse numero de 1 até quantas vezes? \n");
    scanf("%d",&B);
    printf("\n");
    printf("Eis sua tabuada, vossa majestade");
    printf("\n");
    printf("\n");
    
    //Calculos e Resultados
    for(C=1;C<(B+1);C++)
    {                       
    D=(A*C);
    printf("%2.2d\n",D);
    printf("\n");
                                   }
    
   
    //Encerramento
    printf("Robo Edy se desligando, fim da operacao, piiii, tsc..");
    system("pause");
                                                                                                     }
