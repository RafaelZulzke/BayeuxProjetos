algoritmo "Salario Fina"
// Fun��o :Calcular o Salario final
// Autor :Rafael
// Data : 15/09/2013
// Se��o de Declara��es
var
SF,SB,A:REAL
TDS:INTEIRO
inicio
// Se��o de Comandos
ESCREVAL("O SALARIO BASE")
LEIA(SB)
ESCREVAL("O TEMPO DE SERVI�O")
LEIA(TDS)

SE TDS<5 ENTAO
   A:=SB*0.02
   SF:=SB+A
FIMSE

SE (TDS>5) E (TDS<10) ENTAO
   A:=SB*0.025
   SF:=SB+A
FIMSE

SE (TDS>10) E (TDS<15) ENTAO
   A:=SB*0.03
   SF:=SB+A
FIMSE

SE TDS>=15 ENTAO
   A:=SB*0.035
   SF:=SB+A
FIMSE
ESCREVAL("O SALARIO FINAL �", SF)

fimalgoritmo
