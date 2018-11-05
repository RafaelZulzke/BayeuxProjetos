algoritmo "DELTA"
// Função :Calcular o Delta
// Autor :Rafael
// Data : 02/09/2013
// Seção de Declarações
var
A,B,C:INTEIRO
DELTA,X1,X2:REAL
inicio
// Seção de Comandos
ESCREVAL("INSIRA O VALOR DE A")
LEIA(A)
ESCREVAL("INSIRA O VALOR DE B")
LEIA(B)
ESCREVAL("INSIRA O VALOR DE C")
LEIA(C)
DELTA:=(B*B)-4*A*C

SE DELTA < 0 ENTAO
   ESCREVAL("DELTA É NEGATIVO IMPOSSIVEL CONTINUAR")
FIMSE
SE DELTA >=0 ENTAO

   X1:=(-B)+Raizq(DELTA)/2*A
   X2:=(-B)-Raizq(DELTA)/2*A
   ESCREVAL("O SEU X1 É", X1)
   ESCREVAL("O SEU X2 É",X2)

FIMSE
fimalgoritmo

