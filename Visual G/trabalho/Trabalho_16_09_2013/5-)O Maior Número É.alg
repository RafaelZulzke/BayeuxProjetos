algoritmo "Galhardi & Zulzke, Company: OMaiorNúmeroÉ"
// Função : Diz dos três valores inseridos qual é o maior número
// Autor :  Daniel Galhardi & Rafael Zulzke
// Data : 18/09/2013
// Seção de Declarações 
var
N1,N2,N3,a:Inteiro
inicio
// Seção de Comandos
Escreval("  Bem vindo ao 'Galhardi & Zulzke, Company: OMaiorNúmeroÉ'")
Escreval("  ")
Escreval("  A função desse Software é encontrar o maior número dos três valores inseridos")
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
   a:=N3
   Escreval("O maior número é, ",a)
senao
   se (N2<N1) e (N1<N3) entao
      a:=N3
      Escreval("O maior número é, ",a)
   senao
      se (N3<N2) e (N2<N1) entao
         a:=N1
         Escreval("O maior número é, ",a)
      senao
         se (N1<N3) e (N3<N2) entao
            a:=N2
            Escreval("O maior número é, ",a)
         senao
            se (N3<N1) e (N1<N2) entao
               a:=N2
               Escreval("O maior número é, ",a)
            senao
               se (N2<N3) e (N3<N1) entao
                  a:=N1
                  Escreval("O maior número é, ",a)

               fimse
            fimse
         fimse
      fimse
   fimse
fimse
fimalgoritmo
