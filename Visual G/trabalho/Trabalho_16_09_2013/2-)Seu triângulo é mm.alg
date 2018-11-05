algoritmo "Galhardi & Zulzke, Company: TiposDeTriângulos"
// Função : Informar que  tipo de triângulo é formado a partir das medidas dos lados
// Autor : Daniel Galhardi & Rafael Zulzke
// Data : 18/09/2013
// Seção de Declarações
var
A,B,C:real
inicio
// Seção de Comandos
Escreval("  A função desse Software é Mostrar que tipo de triângulo ")
Escreval("irá ser formado somente com as medidas dos lados")
Escreval("")
Escreval("  Obrigado por escolher nossos produtos")
Escreval("  Bom uso :) ")
Escreval("")
Escreval("  Início:")
Escreval("")

Escreval("Digite a Medida do Lado 'A'")
Leia(A)
Escreval("Digite a Medida do Lado 'B'")
Leia(B)
Escreval("Digite a Medida do Lado 'C'")
Leia(C)

SE ((A+B)>C) e  ((B+C)>A) e ((A+C)>B) entao
   Escreval("")
   Escreval("Essas medidas permitem formar um triângulo, então:")
   Escreval("")
   Se (A=B) e (B=C) Entao
      Escreval("O seu triângulo é equilátero")

   Senao
      Se(A=B) ou (B=C) ou (A=C) Entao
         Escreval("O seu triângulo é isóceles")

      Senao
         Se (A<>B) e (B<>C) Entao
            Escreval("O seu triângulo é escaleno")

         fimse
      fimse
   fimse
senao
   Escreval("Não foi possível formar um triângulo")
Fimse
fimalgoritmo
