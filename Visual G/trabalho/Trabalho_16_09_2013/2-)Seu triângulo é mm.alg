algoritmo "Galhardi & Zulzke, Company: TiposDeTri�ngulos"
// Fun��o : Informar que  tipo de tri�ngulo � formado a partir das medidas dos lados
// Autor : Daniel Galhardi & Rafael Zulzke
// Data : 18/09/2013
// Se��o de Declara��es
var
A,B,C:real
inicio
// Se��o de Comandos
Escreval("  A fun��o desse Software � Mostrar que tipo de tri�ngulo ")
Escreval("ir� ser formado somente com as medidas dos lados")
Escreval("")
Escreval("  Obrigado por escolher nossos produtos")
Escreval("  Bom uso :) ")
Escreval("")
Escreval("  In�cio:")
Escreval("")

Escreval("Digite a Medida do Lado 'A'")
Leia(A)
Escreval("Digite a Medida do Lado 'B'")
Leia(B)
Escreval("Digite a Medida do Lado 'C'")
Leia(C)

SE ((A+B)>C) e  ((B+C)>A) e ((A+C)>B) entao
   Escreval("")
   Escreval("Essas medidas permitem formar um tri�ngulo, ent�o:")
   Escreval("")
   Se (A=B) e (B=C) Entao
      Escreval("O seu tri�ngulo � equil�tero")

   Senao
      Se(A=B) ou (B=C) ou (A=C) Entao
         Escreval("O seu tri�ngulo � is�celes")

      Senao
         Se (A<>B) e (B<>C) Entao
            Escreval("O seu tri�ngulo � escaleno")

         fimse
      fimse
   fimse
senao
   Escreval("N�o foi poss�vel formar um tri�ngulo")
Fimse
fimalgoritmo
