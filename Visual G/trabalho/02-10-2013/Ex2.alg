algoritmo "EX2"
// Função :
// Autor :
// Data : 02/10/2013
// Seção de Declarações
var
I,N,NUM,R:INTEIRO
inicio
// Seção de Comandos
Escreval("entre com o número a ser multiplicado")
leia(NUM)
Escreval("Multiplicar até qual posição")
leia(N)

para I de 1 ate N faca
   R:=NUM*I

   Escreval(NUM," X ",I,"=",R)
fimpara
fimalgoritmo
