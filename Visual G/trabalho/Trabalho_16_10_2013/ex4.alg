algoritmo "semnome"
// Função :
// Autor :
// Data : 21/10/2013
// Seção de Declarações
var
N,T,Pt1,Pt2,Pt3:Inteiro
T1,T2,T3:Real
R:Literal
inicio
// Seção de Comandos
Escreval("Dejesa Colocar  Notas? S ou N")
Leia(R)
Enquanto R = "s" Faca
   Escreval("Coloque a Nota de 1 a 3")
   Leia(N)
   T:=T+1
   Se (R>3) e (R<1) Entao
   Fimse
   Se R = 3 Entao
      T3:=T3+1
      Escreval("Dejesa Colocar Mais Notas? S ou N")
      Leia(R)
   Senao
      Se R=2 Entao
         T2:=T2+1
         Escreval("Dejesa Colocar Mais Notas? S ou N")
         Leia(R)
      Senao
         Se R=1 Entao
            T1:=T1+1
            Escreval("Dejesa Colocar Mais Notas? S ou N")
            Leia(R)
         Fimse
      Fimse
   Fimse

   Escreval("")
   Escreval("O Total de Entrevistados Foi,",T)
   Escreval("Foram dadas,",T3,"Notas 3")
   Escreval("Foram dadas",T2,"Notas 2")
   Escreval("Foram dadas",T1,"Notas 1")
   Pt3:=T/T3
   Pt2:=T/T2
   Pt1:=T/T1
   Escreval(Pt3,"% das pessoas respondeu 3")
   Escreval(Pt2,"% das pessoas respondeu 2")
   Escreval(Pt1,"% das pessoas respondeu 1")


fimalgoritmo
