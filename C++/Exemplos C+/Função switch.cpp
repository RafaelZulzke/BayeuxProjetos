#include<stdio.h>
#include<stdlib.h>
#include<math.h>

main() {
       int op;
      printf("Calculadora\n");
      printf("\n");
       printf("\n");
       printf("Escolha uma das alternativas abaixo\n");
       printf("\n");
       printf("\n");
       printf("1 - Soma\n");
       printf("2 - Subtra��o\n");
       printf("3 - Divis�o\n");
       printf("4 - Multiplica��o\n");
       printf("Digite  o numero escolhido\n");
          scanf("%d",&op);
          
          switch(op)
          {
                    case 1:
                         printf("voce escolheu a op��o 01\n");
                      break;  
                     case 2:
                         printf("voce escolheu a op��o 02\n");
                            break;  
                     case 3:
                         printf("voce escolheu a op��o 03\n");
                        break;  
                      case 4:
                         printf("voce escolheu a op��o 04\n");
                           break;  
                    default:
                            printf("op��o fora do intervalo de 1 ate 4\n");
                            }            
                   
       
      

       
       system("pause");
       }
       
