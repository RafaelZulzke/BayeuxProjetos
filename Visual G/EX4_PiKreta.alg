algoritmo "Company&Tecnology "
// Fun��o :Calcular Quantidade de Latas, Or�amento e a �rea Total para pintar Cilindros de Tinta
// Autor :Daniel Galhardi TheGodOnlyKnows & Rafael Zulzke TheShinigami
// Data : 28/8/2013
// Se��o de Declara��es 
var
Valordatinta:REAL
Quantidadedolitrosdatinta:REAL
Rendimentodolitrodotintametrolitro:REAL
Altura:REAL
Raio:REAL
OrcamentoemReais:REAL
AreaCirculo:REAL
Circunferencia:REAL
AreaTotal,AreaA:REAL
QuantidadedeLatas:REAL
umalata:REAL


inicio
// Se��o de Comandos 
ESCREVAL("DIGITE O VALOR DO Raio")
Leia(Raio)
ESCREVAL("DIGITE O VALOR DA Altura")
Leia(Altura)
ESCREVAL("DIGITE O VALOR DA TINTA")
Leia(ValordaTinta)
ESCREVAL("DIGITE A QUANTIDADE EM LITROS DE TINTA NA LATA")
Leia(Quantidadedolitrosdatinta)
ESCREVAL("1 LITRO DE TINTA PINTA QUANTOS METROS QUADRADOS?")
Leia(Rendimentodolitrodotintametrolitro)


AreaCirculo:=3.14*Raio*Raio
Circunferencia:=2*3.14*Raio
AreaA:=Circunferencia*Altura
AreaTotal:=AreaA+AreaCirculo
QuantidadedeLatas:=int((AreaTotal/Rendimentodolitrodotintametrolitro/Quantidadedolitrosdatinta)+0.9)
OrcamentoemReais:=ValordaTinta*QuantidadedeLatas
ESCREVAL("A �REA TOTAL A SER PINTADA �",AreaTotal,"METROS")
ESCREVAL("A QUANTIDADE DE LATAS A SEREM UTILIZADAS �",QuantidadedeLatas)
ESCREVAL("VOC� IR� DESEMBOLSAR  ",OrcamentoemReais:2:2,"  R$")



fimalgoritmo
