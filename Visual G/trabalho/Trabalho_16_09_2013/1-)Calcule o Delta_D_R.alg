algoritmo "Galhardi & Zulzke, Company: CalculeDelta"
// Função : A função é descobrir o Delta da equação de 2º Grau utilizando a fórmula de Baskara
// Autor : Daniel Galhardi & Rafael Zulzke
// Data : 16/09/2013
// Seção de Declarações
var
A,B,C:Inteiro
D,X1,X2:Real
inicio
// Seção de Comandos
Escreval("  Bem vindo ao 'Galhardi & Zulzke, Company: CalculeDelta'")
Escreval("  ")
Escreval("  A função desse Software é calcular uma equação de 2ºGrau")
Escreval("  Obrigado por escolher nossos produtos")
Escreval("  Bom uso :) ")
Escreval("                                                ")
Escreval("  Início:")
Escreval("                                                ")

Escreval("  Qual é o valor de 'A'?")
Leia(A)
Escreval("  Qual é o valor de 'B'?")
Leia(B)
Escreval("  Qual é o valor de 'C'?")
Leia(C)

D:=(B*B)-4*A*C

 SE D<0 ENTAO
   Escreval("Delta é igual a ,",D," Como ele é Negativo é impossível continuar operação")
   Escreval("Fim dos Cálculos")

 Senao
  SE D=0 ENTAO
   X1:=(-b+Raizq(D))/(2*A)
   Escreval("Delta é igual a 0, por isso só existe um resultado possível para 'esta' operação")
   Escreval("O Resultado é , ",X1)
  SENAO

   SE D>0 ENTAO
    X1:=(-b+Raizq(DT))/(2*A)
    X2:=(-b-Raizq(DT))/(2*A)
    Escreval("Delta é igual a ,"D," por isso existem dois resultados possíveis, denominados X1 e X2")
    Escreval(" os quais equivalem 'nesta' operação")
    Escreval("X1 é igual a, "X1," e X2 é igual a, "X2)
   fimse
  fimse
 Fimse
   fimalgoritmo
