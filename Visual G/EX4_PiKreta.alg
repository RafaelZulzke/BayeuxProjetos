algoritmo "Company&Tecnology "
// Função :Calcular Quantidade de Latas, Orçamento e a Área Total para pintar Cilindros de Tinta
// Autor :Daniel Galhardi TheGodOnlyKnows & Rafael Zulzke TheShinigami
// Data : 28/8/2013
// Seção de Declarações 
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
// Seção de Comandos 
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
ESCREVAL("A ÁREA TOTAL A SER PINTADA É",AreaTotal,"METROS")
ESCREVAL("A QUANTIDADE DE LATAS A SEREM UTILIZADAS É",QuantidadedeLatas)
ESCREVAL("VOCÊ IRÁ DESEMBOLSAR  ",OrcamentoemReais:2:2,"  R$")



fimalgoritmo
