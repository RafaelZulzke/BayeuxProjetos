algoritmo "ex1"
// Fun��o :
// Autor :
// Data : 25/09/2013
// Se��o de Declara��es 
var
R,N1,N2:REAL
OP:INTEIRO
inicio
// Se��o de Comandos
Escreval("Escolha uma Op��o")
Escreval("1-Adi��o")
Escreval("2-Subtra��o")
Escreval("3-Multiplica��o")
Escreval("4-Divis�o")
Escreval("Digite a Op��o")
Leia(OP)
Escreval("Digite o Primeiro Numero")
Leia(N1)
Escreval("Digite o Segundo Numero")
Leia(N2)
Escolha OP
Caso 1
R:=N1+N2
Caso 2
R:=N1-N2
Caso 3
R:=N1*N2
Caso 4
R:=N1/N2
Outrocaso
Escreval("Opera��o Invalida")
Fimescolha
Escreval("O Resultado da opera��o �",R)
fimalgoritmo
