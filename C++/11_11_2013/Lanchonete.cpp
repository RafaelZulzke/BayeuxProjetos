#include<stdio.h>
#include<stdlib.h>
#include<math.h>
main()
{
      //Variáveis:
       float TG,QL,VU,TC,T,DF,D;
       int NL,L,TL,Log;
     
     //Apresentaçao:
      printf("Bem Vindo ao 'Xavier Lanches'");
      printf("\n");
      
     // Cardápio:
      printf("Abaixo segue nosso cardápio:\n");
      printf("\n");
      printf("1- X.Xavier................R$20,00\n");
      printf("2- X.Wolverine.............R$15,00\n");
      printf("3- X.Jean..................R$12,00\n");
      printf("4- X.Ciclop................R$08,00\n");
      printf("5- Gambit Hamburguer.......R$12,00\n");
      printf("6- X.Salada de Magneto.....R$09,00\n");
      printf("7- X.Noturno...............R$07,00\n");
      
     //Escolha do Lanche:
     
      printf("Para encerrar opcao digite 0\n");
      printf("Digite numero do lanche\n");
      scanf("%d",&NL);
      
      while(NL!=0)
      {

      switch (NL)
      {
         case 1:
          L = (20);
          break;
          
          case 2:
          L = (15);
          break;

         case 3:
          L = (12);
          break;

         case 4:
          L = (8);
          break;

         case 5:
          L = (12);
          break;

         case 6:
          L = (9);
          break;
          
         case 7:
          L = (7);
          break;
         }
         printf("Quantos lanches desse deseja?\n");
         scanf("%d",&QL);      
         TL = (QL*L);
         TC = (TC+TL);  
         printf("digite numero do lanche\n");
         scanf("%d",&NL);          
         
         }
     //Pagamento
      printf("Coloque quanto dinheiro voce tem\n");
      scanf("%f",&D);
      printf("\n");

      if (D>TC)
      {        
       printf("Obrigado Pela Compra\n");
       T = (D-TC);
       printf("Seu troco é %d",T);
       }
      
      else
      { 
      DF = (TC-D);
      printf("Não foi possivel finalizar a compra\n");
      printf("Faltam R$ %2.2f",DF,"\n");
      printf("Adicione o Dinheiro restante\n");
      }

      //Parada   
      system("pause");
      
      //Programadores
      //DanielGalhard&RafaelZulzke
                                                          }
        
