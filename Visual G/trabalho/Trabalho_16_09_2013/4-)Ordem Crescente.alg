algoritmo "Galhardi & Zulzke, Company: OrdemCrescente"
// Fun��o : Colocar em ordem crescente no m�ximo 3 n�meros aleat�rios
// Autor : Daniel Galhardi & Rafael Zulzke
// Data : 18/09/2013
// Se��o de Declara��es
var
N1,N2,N3,a,b,c:Inteiro
inicio
// Se��o de Comandos
Escreval("  Bem vindo ao 'Galhardi & Zulzke, Company: OrdemCrescente'")
Escreval("  ")
Escreval("  A fun��o desse Software � organizar os n�meros inseridos em ordem crescente")
Escreval("  Obrigado por escolher nossos produtos")
Escreval("  Bom uso :) ")
Escreval("                                                ")
Escreval("  In�cio:")
Escreval("                                                ")
Escreval("Coloque o Primeiro N�mero")
Leia(N1)
Escreval("Coloque o Segundo N�mero")
Leia(N2)
Escreval("Coloque o Terceiro N�mero")
Leia(N3)

se (N1<N2) e (N2<N3)  entao
   a:=N1
   b:=N2
   C:=N3
   Escreval("Em ordem crescente os n�meros s�o, ",a,", ",b,", ",c)
senao
   se (N2<N1) e (N1<N3) entao
      a:=N2
      b:=N1
      c:=N3
      Escreval("Em ordem crescente os n�meros s�o, ",a,", ",b,", ",c)
   senao
      se (N3<N2) e (N2<N1) entao
         a:=N3
         b:=N2
         c:=N1
         Escreval("Em ordem crescente os n�meros s�o, ",a,", ",b,", ",c)
      senao
         se (N1<N3) e (N3<N2) entao
            a:=N1
            b:=N3
            c:=N2
            Escreval("Em ordem crescente os n�meros s�o, ",a,", ",b,", ",c)
         senao
            se (N3<N1) e (N1<N2) entao
               a:=N3
               b:=N1
               c:=N2
               Escreval("Em ordem crescente os n�meros s�o, ",a,", ",b,", ",c)
            senao
               se (N2<N3) e (N3<N1) entao
                  a:=N2
                  b:=N3
                  c:=N1
                  Escreval("Em ordem crescente os n�meros s�o, ",a,", ",b,", ",c)

               fimse
            fimse
         fimse
      fimse
   fimse
fimse
fimalgoritmo
