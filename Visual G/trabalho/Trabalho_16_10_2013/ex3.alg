algoritmo "Quantidade de Números Múltiplos de 3 de 250 até 3500"
// Função :
// Autor :
// Data : 21/10/2013
// Seção de Declarações
var
A,N,Y:Inteiro
Resp:Literal
inicio
// Seção de Comandos
Escreval("Quer Saber Quantos múltiplos de 3 existem entre 250 e 3500?")
Escreval("S para sim, N para não")
Leia(Resp)
Se Resp = "S" entao



   N:=250
   Para A de N ate 3500 faca
      Se N Mod 3 = 0  Entao
         Y:=Y+1
      Fimse

      N:=N+1
   fimpara
   Escreval("A Quantudade de  Múltiplos de 3, de 250 ate 3500 é,",Y)
Senao
   Escreval("Já que não deseja, encerre o programa")
fimse
fimalgoritmo

