algoritmo "Galhardi & Zulzke, Company: CalculeDelta"
// Fun��o : A fun��o � descobrir o Delta da equa��o de 2� Grau utilizando a f�rmula de Baskara
// Autor : Daniel Galhardi & Rafael Zulzke
// Data : 16/09/2013
// Se��o de Declara��es
var
A,B,C:Inteiro
D,X1,X2:Real
inicio
// Se��o de Comandos
Escreval("  Bem vindo ao 'Galhardi & Zulzke, Company: CalculeDelta'")
Escreval("  ")
Escreval("  A fun��o desse Software � calcular uma equa��o de 2�Grau")
Escreval("  Obrigado por escolher nossos produtos")
Escreval("  Bom uso :) ")
Escreval("                                                ")
Escreval("  In�cio:")
Escreval("                                                ")

Escreval("  Qual � o valor de 'A'?")
Leia(A)
Escreval("  Qual � o valor de 'B'?")
Leia(B)
Escreval("  Qual � o valor de 'C'?")
Leia(C)

D:=(B*B)-4*A*C

 SE D<0 ENTAO
   Escreval("Delta � igual a ,",D," Como ele � Negativo � imposs�vel continuar opera��o")
   Escreval("Fim dos C�lculos")

 Senao
  SE D=0 ENTAO
   X1:=(-b+Raizq(D))/(2*A)
   Escreval("Delta � igual a 0, por isso s� existe um resultado poss�vel para 'esta' opera��o")
   Escreval("O Resultado � , ",X1)
  SENAO

   SE D>0 ENTAO
    X1:=(-b+Raizq(DT))/(2*A)
    X2:=(-b-Raizq(DT))/(2*A)
    Escreval("Delta � igual a ,"D," por isso existem dois resultados poss�veis, denominados X1 e X2")
    Escreval(" os quais equivalem 'nesta' opera��o")
    Escreval("X1 � igual a, "X1," e X2 � igual a, "X2)
   fimse
  fimse
 Fimse
   fimalgoritmo
