algoritmo "ex1"
// Função :
// Autor :
// Data : 25/09/2013
// Seção de Declarações 
var
R,N1,N2:REAL
OP:INTEIRO
inicio
// Seção de Comandos
Escreval("Escolha uma Opção")
Escreval("1-Adição")
Escreval("2-Subtração")
Escreval("3-Multiplicação")
Escreval("4-Divisão")
Escreval("Digite a Opção")
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
Escreval("Operação Invalida")
Fimescolha
Escreval("O Resultado da operação é",R)
fimalgoritmo
