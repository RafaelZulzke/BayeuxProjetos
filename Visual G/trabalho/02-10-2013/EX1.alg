algoritmo "ex1"
// Função :Par ou Impar
// Autor :
// Data : 02/10/2013
// Seção de Declarações 
var
I,N,CP,CI,SG:INTEIRO
inicio
// Seção de Comandos 
Para I de 1 ate 5 faca

Escreval("Entre com o", I," Numero")
Leia(N)
Se N MOD 2 = 0 Entao
CP:=CP+1
Senao
CI:=CI+1
Fimse
SG:=SG+N
FIMPARA
Escreval("Seu CP é",CP)
Escreval("Seu CI é",CI)
Escreval("Sua Soma Geral é",SG)
fimalgoritmo
