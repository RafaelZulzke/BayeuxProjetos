algoritmo "Lanchonete"
// Função :
// Autor :
// Data : 25/09/2013
// Seção de Declarações
var
QL,VU,TC,T,DF,D,Tr,Tx:real
L:Inteiro
inicio
// Seção de Comandos
Escreval("Bem Vindo ao 'Xavier Lanches'")
Escreval("")
Escreval("Abaixo segue nosso cardápio:")
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

Escreval("Para parar a compra digite 0 no número do lanche")

Repita

   Escreval("Digite o número do lanche X.Escolhido:")
   Leia(L)
   Escreval("")
   Se (L>7) ou (L<1) Entao
      Escreval("Opção Invalida, Coloque outra opção")
   Senao
      Se L=1 Entao
         VU:=20
      Senao
         Se L=2 Entao
            VU:=15
         Senao
            Se L=3 Entao
               VU:=12
            Senao
               Se L=4 Entao
                  VU:=8
               Senao
                  Se L=5 Entao
                     VU:=12
                  Senao
                     Se L=6 Entao
                        VU:=9
                     Senao
                        Se L=7 Entao
                           VU=7

                        fimse
                     fimse
                  fimse
               fimse
            fimse
         fimse
      fimse
   fimse

   Se (L>=1)e (L<=7) Entao
      Escreval("Quantos Lanches desse tipo quer?")
      Leia(QL)
      T:=QL*L
      TC:=TC+T
   Fimse

Ate L=0


Escreval("Ao todo você precisa pagar,",TC:2:2,"R$")
Escreval("Coloque quanto dinheiro você tem")
Leia(D)

Se (TC<D) Entao
   Tr:=D-TC
   Escreval("Seu Troco é,",Tr:2:2,"R$, pegue seu troco")
   Escreval("Obrigado pela compra! Volte sempre!")
Senao

   Se (TC>D) Entao
      DF:=TC-D
      Escreval("Faltam,"DF:2:2,"R$ para completar a compra")
      Escreval("De o dinheiro faltando")
      Leia(D)
      Tx:=D+DF
      Se (Tx) = (TC) Entao
         Escreval("Obrigado pela compra volte sempre")
      fimse
   Senao

      Se (TC=D) Entao
         Escreval("Compra Efetuada, volte sempre!")
      fimse
   fimse
fimse



FIMALGORITMO

