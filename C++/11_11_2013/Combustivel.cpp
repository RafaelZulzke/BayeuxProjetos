#include<stdio.h>
#include<stdlib.h>

main()
{
//Vari�veis:
            float Vc, Qc, D, Cm, Qf, Vf, Qg;
                        
//In�cio:
//Inser��o de Dados:
printf("O preco do combustivel e:\n");
scanf("%f",&Vc);
         
printf("O consumo medio do combustivel �:\n");
scanf("%f",&Cm);
         
printf("A distancia a ser percorrida e:\n");
scanf("%f",&D);
         
printf("A quantidade de combustivel no veiculo �:\n");
scanf("%f",&Qc);
         
//C�lculos:
Qf = ((D/Cm)*2);
Qg = (Qc-Qf);
Vf = (Vc*Qf);
         
//Respostas:
printf("\n A quantidade final para ida e volta e %2.2f",Qf);
printf("\nForam gastos %2.2f",Qg," litros\n");
printf("\nVoce gastou R$%2.2f",Vf);
         
//Parada:
system("pause");
         
         //Programadores
         //DanielGalhardi&RafaelZulzke
}        
         
