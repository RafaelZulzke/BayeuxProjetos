algoritmo "Galhardi & Zulzke, Company: CalculePesoIdeal"
// Fun��o : Calcular o Peso ideal de uma pessoa
// Autor : Daniel Galhardi & Rafael Zulzke
// Data : 18/09/2013
// Se��o de Declara��es 
var
S,H,M:Literal
A,Ps:Real
inicio
// Se��o de Comandos
Escreval("Bem Vindo ao Galhardi & Zulzke, Company: CalculePesoIdeal")
Escreval("    ")
Escreval("  A fun��o desse Software � calcular o peso ideal de uma pessoa")
Escreval("  Obrigado por escolher nossos produtos")
Escreval("  Bom uso :) ")
Escreval("                                                ")
Escreval("  In�cio:")
Escreval("                                                ")

Escreval("Digite Sua Altura")
Leia(A)
Escreval("Qual � o Seu sexo? Digite 'H' para Homem, 'M' para Mulher")
Leia(S)
 Se  S="h" entao
  Ps:=(72.7*A)-58
  Escreval("Seu Peso ideal � ",Ps)
   Senao
     Ps:=(62.1*A)-44.7
     Escreval("Seu Peso ideal � ",Ps)
 fimse
fimalgoritmo

