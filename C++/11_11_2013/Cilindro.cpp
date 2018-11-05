#include <stdio.h>
#include <stdlib.h>

main()
{
//Variáveis
float Vt, Qlt, Rlt, At, R, Or, Ac, Cf, Art, Aa, Ql, Ul;

//Início

//Inserção de Valores
printf("Digite o tamanho do Raio da parte circular do cilindro\n");
scanf("%f",&R);
printf("Digite a altura do cilindro.\n");
scanf("%f",&At);
printf("Digite o preco da tinta\n");
scanf("%f",&Vt);
printf("Digite Quantos litros de tinta ha em uma lata\n");
scanf("%f",&Qlt);
printf("Digite a relacao, Litro por Mq\n");
scanf("%f",&Rlt);

//Cálculos
Ac = (3.14*R*R);
Cf = (2*3.14*R);
Aa = (Cf*At);
Art = (Aa+Ac);
Ql = int((Art/Qlt/Rlt)+0.9);
Or = (Ql*Vt);

//Resultados
printf("Area total a ser pintada..................................%2.2f",Art," M²");
printf("\nQuantidade de latas a serem utilizadas...........................%2.2f",Ql);
printf("\nOrcamento........................................................R$%2.2f",Or);
printf("\n");

//Parada
system("pause");

//Programadores
//DanielGalhardi&RafaelZulzke

}
