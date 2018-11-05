algoritmo "Calculando bônus salarial"
// Função :Calcular o bônus salarial
// Autor :Daniel Galhardi & Rafael Zulzke
// Data : 09/09/2013


var
SB,SF,VVTM,PASQV,VC:REAL
NF:Literal

inicio
Escreval("O Nome do Funcionário")
Leia(NF)
Escreval("O Salário Base do Funcionário")
Leia(SB)
Escreval("O Valor Total das Vendas do Funcionário no Mês")
Leia(VVTM)

SE (VVTM>=0)e(VVTM<=10000) Entao
   VC:=SB*0.0005
   SF:=SB*1.0005
   Escreval("O Funcionário:",NF)
   Escreval("Obteve para a loja ",VVTM)
   Escreval(" Por esse motivo teve 0.05% de comissão por cada venda")
   Escreval(" No total teve adicionado ao salário ",VC:2:2)
   Escreval(" O salário final foi de ",SF:2:2," R$")

Senao

   Se  (VVTM>=10000.01) e (VVTM<=25000.00) ENTAO
      SF:=SB*1.0007
      VC:=SB*0.0007
      Escreval("O Funcionário:",NF)
      Escreval("Obteve para a loja ",VVTM)
      Escreval(" Por esse motivo teve 0.07% de comissão por cada venda")
      Escreval(" No total teve adicionado ao salário ",VC:2:2)
      Escreval("O Salário final é ",SF:2:2)

   Senao

      Se (VVTM>=25000.01)e(VVTM<=50000.00) ENTAO
         SF:=SB*1.0009
         VC:=SB*0.0009
         Escreval("O Funcionário:",NF)
         Escreval("Obteve para a loja ",VVTM)
         Escreval(" Por esse motivo teve 0.09% de comissão por cada venda")
         Escreval(" No total teve adicionado ao salário ",VC:2:2)
         Escreval("O Salário final é ",SF)


      Senao


         Se(VVTM>=50000.01) ENTAO
            SF:=(SB*1.05)+150.00
            VC:=(SB*0.05)+150.00
            Escreval("O Funcionário:",NF)
            Escreval("Obteve para a loja ",VVTM)
            Escreval(" Por esse motivo teve 0.05% de comissão por cada venda mais um bônus 150 R$")
            Escreval(" No total teve adicionado ao salário ",VC:2:2)
            Escreval("O Salário final é ",SF)
         fimse
      fimse
   fimse
FIMSE
fimalgoritmo


