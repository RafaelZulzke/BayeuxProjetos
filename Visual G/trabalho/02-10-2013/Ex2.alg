algoritmo "EX2"
// Fun��o :
// Autor :
// Data : 02/10/2013
// Se��o de Declara��es
var
I,N,NUM,R:INTEIRO
inicio
// Se��o de Comandos
Escreval("entre com o n�mero a ser multiplicado")
leia(NUM)
Escreval("Multiplicar at� qual posi��o")
leia(N)

para I de 1 ate N faca
   R:=NUM*I

   Escreval(NUM," X ",I,"=",R)
fimpara
fimalgoritmo
