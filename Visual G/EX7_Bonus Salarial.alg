algoritmo "Calculando b�nus salarial"
// Fun��o :Calcular o b�nus salarial
// Autor :Daniel Galhardi & Rafael Zulzke
// Data : 09/09/2013


var
SB,SF,VVTM,PASQV,VC:REAL
NF:Literal

inicio
Escreval("O Nome do Funcion�rio")
Leia(NF)
Escreval("O Sal�rio Base do Funcion�rio")
Leia(SB)
Escreval("O Valor Total das Vendas do Funcion�rio no M�s")
Leia(VVTM)

SE (VVTM>=0)e(VVTM<=10000) Entao
   VC:=SB*0.0005
   SF:=SB*1.0005
   Escreval("O Funcion�rio:",NF)
   Escreval("Obteve para a loja ",VVTM)
   Escreval(" Por esse motivo teve 0.05% de comiss�o por cada venda")
   Escreval(" No total teve adicionado ao sal�rio ",VC:2:2)
   Escreval(" O sal�rio final foi de ",SF:2:2," R$")

Senao

   Se  (VVTM>=10000.01) e (VVTM<=25000.00) ENTAO
      SF:=SB*1.0007
      VC:=SB*0.0007
      Escreval("O Funcion�rio:",NF)
      Escreval("Obteve para a loja ",VVTM)
      Escreval(" Por esse motivo teve 0.07% de comiss�o por cada venda")
      Escreval(" No total teve adicionado ao sal�rio ",VC:2:2)
      Escreval("O Sal�rio final � ",SF:2:2)

   Senao

      Se (VVTM>=25000.01)e(VVTM<=50000.00) ENTAO
         SF:=SB*1.0009
         VC:=SB*0.0009
         Escreval("O Funcion�rio:",NF)
         Escreval("Obteve para a loja ",VVTM)
         Escreval(" Por esse motivo teve 0.09% de comiss�o por cada venda")
         Escreval(" No total teve adicionado ao sal�rio ",VC:2:2)
         Escreval("O Sal�rio final � ",SF)


      Senao


         Se(VVTM>=50000.01) ENTAO
            SF:=(SB*1.05)+150.00
            VC:=(SB*0.05)+150.00
            Escreval("O Funcion�rio:",NF)
            Escreval("Obteve para a loja ",VVTM)
            Escreval(" Por esse motivo teve 0.05% de comiss�o por cada venda mais um b�nus 150 R$")
            Escreval(" No total teve adicionado ao sal�rio ",VC:2:2)
            Escreval("O Sal�rio final � ",SF)
         fimse
      fimse
   fimse
FIMSE
fimalgoritmo


