algoritmo "semnome"
// Fun��o :
// Autor :
// Data : 25/09/2013
// Se��o de Declara��es
var
TG,QL,VU,TC,T,DF,D:real
NL,L,I,TL:Inteiro
inicio
// Se��o de Comandos
Escreval("Bem Vindo ao 'Xavier Lanches'")
Escreval("")
Escreval("Quantos tipos de Lanche voc� deseja")
Leia(TL)

Para I de 1 ate TL faca

   Escreval("Abaixo segue nosso card�pio:")
   Escreval("")
   Escreval("1- X.Xavier................R$20,00")
   Escreval("2- X.Wolverine.............R$15,00")
   Escreval("3- X.Jean..................R$12,00")
   Escreval("4- X.Ciclop................R$08,00")
   Escreval("5- Gambit Hamburguer.......R$12,00")
   Escreval("6- X.Salada de Magneto.....R$09,00")
   Escreval("7- X.Noturno...............R$07,00")


   Escreval("")
   Escreval("")

   Escreval("Digite o n�mero do,",I,"� lanche X.Escolhido:")
   Leia(NL)

   Se (NL > 8) ou (NL<1) Entao
      Escreval("Op��o Inv�lida")
   senao
      Escreval("")
      Escreval("Digite a Quantidade de Lanches Desejadas")
      Leia(QL)
      Escreval("")

      escolha nl
      Caso 1
         TC:=QL*20.0


      Caso 2
         TC:=QL*15.0


      Caso 3
         TC:=QL*12.0


      Caso 4
         TC:=QL*8.0


      Caso 5
         TC:=QL*12.0


      Caso 6
         TC:=QL*9.0


      Caso 7
         TC:=QL*7.0

      fimescolha
   fimse
Fimpara

Escreval("Coloque quanto dinheiro voc� tem")
Leia(D)
Escreval("")

Se D > TC Entao
   T:=D-TC
   Escreval("Obrigado Pela Compra")
   Escreval("Seu Troco �", T)
   Escreval("Compra Finalizada, Volte Sempre")
Senao
   Se D = TC Entao
      Escreval("Obrigado Pela Compra")
      Escreval("Compra Finalizada, Volte Sempre")
   Senao
      Se D < TC Entao
         DF:=TC-D
         Escreval("N�o foi poss�vel finalizar a compra")
         Escreval("Faltam R$ ",DF)
         Escreval("Adicione o Dinheiro restante")
      fimse
   fimse



FIMALGORITMO




