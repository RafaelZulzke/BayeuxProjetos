algoritmo "Salario Fina"
// Função :Calcular o Salario final
// Autor :Rafael
// Data : 15/09/2013
// Seção de Declarações
var
SF,SB,A:REAL
TDS:INTEIRO
inicio
// Seção de Comandos
ESCREVAL("O SALARIO BASE")
LEIA(SB)
ESCREVAL("O TEMPO DE SERVIÇO")
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
ESCREVAL("O SALARIO FINAL É", SF)

fimalgoritmo
