algoritmo "Galhardi & Zulzke, Company: OMaiorN�mero�"
// Fun��o : Diz dos tr�s valores inseridos qual � o maior n�mero
// Autor :  Daniel Galhardi & Rafael Zulzke
// Data : 18/09/2013
// Se��o de Declara��es 
var
N1,N2,N3,a:Inteiro
inicio
// Se��o de Comandos
Escreval("  Bem vindo ao 'Galhardi & Zulzke, Company: OMaiorN�mero�'")
Escreval("  ")
Escreval("  A fun��o desse Software � encontrar o maior n�mero dos tr�s valores inseridos")
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
   a:=N3
   Escreval("O maior n�mero �, ",a)
senao
   se (N2<N1) e (N1<N3) entao
      a:=N3
      Escreval("O maior n�mero �, ",a)
   senao
      se (N3<N2) e (N2<N1) entao
         a:=N1
         Escreval("O maior n�mero �, ",a)
      senao
         se (N1<N3) e (N3<N2) entao
            a:=N2
            Escreval("O maior n�mero �, ",a)
         senao
            se (N3<N1) e (N1<N2) entao
               a:=N2
               Escreval("O maior n�mero �, ",a)
            senao
               se (N2<N3) e (N3<N1) entao
                  a:=N1
                  Escreval("O maior n�mero �, ",a)

               fimse
            fimse
         fimse
      fimse
   fimse
fimse
fimalgoritmo
