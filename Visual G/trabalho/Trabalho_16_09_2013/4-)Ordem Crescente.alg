algoritmo "Galhardi & Zulzke, Company: OrdemCrescente"
// Função : Colocar em ordem crescente no máximo 3 números aleatórios
// Autor : Daniel Galhardi & Rafael Zulzke
// Data : 18/09/2013
// Seção de Declarações
var
N1,N2,N3,a,b,c:Inteiro
inicio
// Seção de Comandos
Escreval("  Bem vindo ao 'Galhardi & Zulzke, Company: OrdemCrescente'")
Escreval("  ")
Escreval("  A função desse Software é organizar os números inseridos em ordem crescente")
Escreval("  Obrigado por escolher nossos produtos")
Escreval("  Bom uso :) ")
Escreval("                                                ")
Escreval("  Início:")
Escreval("                                                ")
Escreval("Coloque o Primeiro Número")
Leia(N1)
Escreval("Coloque o Segundo Número")
Leia(N2)
Escreval("Coloque o Terceiro Número")
Leia(N3)

se (N1<N2) e (N2<N3)  entao
   a:=N1
   b:=N2
   C:=N3
   Escreval("Em ordem crescente os números são, ",a,", ",b,", ",c)
senao
   se (N2<N1) e (N1<N3) entao
      a:=N2
      b:=N1
      c:=N3
      Escreval("Em ordem crescente os números são, ",a,", ",b,", ",c)
   senao
      se (N3<N2) e (N2<N1) entao
         a:=N3
         b:=N2
         c:=N1
         Escreval("Em ordem crescente os números são, ",a,", ",b,", ",c)
      senao
         se (N1<N3) e (N3<N2) entao
            a:=N1
            b:=N3
            c:=N2
            Escreval("Em ordem crescente os números são, ",a,", ",b,", ",c)
         senao
            se (N3<N1) e (N1<N2) entao
               a:=N3
               b:=N1
               c:=N2
               Escreval("Em ordem crescente os números são, ",a,", ",b,", ",c)
            senao
               se (N2<N3) e (N3<N1) entao
                  a:=N2
                  b:=N3
                  c:=N1
                  Escreval("Em ordem crescente os números são, ",a,", ",b,", ",c)

               fimse
            fimse
         fimse
      fimse
   fimse
fimse
fimalgoritmo
