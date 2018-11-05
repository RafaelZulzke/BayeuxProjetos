algoritmo "JUROS"
// Função :
// Autor :
// Data : 02/09/2013
// Seção de Declarações 
var
P,J,VJ,PJ:REAL
A:INTEIRO
inicio
// Seção de Comandos
ESCREVAL("DIGITE O VALOR DA PRESTAÇÃO")
LEIA(P)
ESCREVAL("DIGITE A QUANTIDADE DE DIAS EM ATRASO")
LEIA(A)
J:=(0.05/30)*A
VJ:=J*P
PJ:=P+VJ
ESCREVAL("O VALOR PARCELA",P)
ESCREVAL("VALOR JUROS",J:2:2)
ESCREVAL("TOTAL A PAGAR",PJ:2:2)
fimalgoritmo
