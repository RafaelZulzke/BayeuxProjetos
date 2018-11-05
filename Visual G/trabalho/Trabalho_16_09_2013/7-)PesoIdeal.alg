algoritmo "Galhardi & Zulzke, Company: CalculePesoIdeal"
// Função : Calcular o Peso ideal de uma pessoa
// Autor : Daniel Galhardi & Rafael Zulzke
// Data : 18/09/2013
// Seção de Declarações 
var
S,H,M:Literal
A,Ps:Real
inicio
// Seção de Comandos
Escreval("Bem Vindo ao Galhardi & Zulzke, Company: CalculePesoIdeal")
Escreval("    ")
Escreval("  A função desse Software é calcular o peso ideal de uma pessoa")
Escreval("  Obrigado por escolher nossos produtos")
Escreval("  Bom uso :) ")
Escreval("                                                ")
Escreval("  Início:")
Escreval("                                                ")

Escreval("Digite Sua Altura")
Leia(A)
Escreval("Qual é o Seu sexo? Digite 'H' para Homem, 'M' para Mulher")
Leia(S)
 Se  S="h" entao
  Ps:=(72.7*A)-58
  Escreval("Seu Peso ideal é ",Ps)
   Senao
     Ps:=(62.1*A)-44.7
     Escreval("Seu Peso ideal é ",Ps)
 fimse
fimalgoritmo

