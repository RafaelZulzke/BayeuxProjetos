algoritmo "Quantidade de N�meros M�ltiplos de 3 de 250 at� 3500"
// Fun��o :
// Autor :
// Data : 21/10/2013
// Se��o de Declara��es
var
A,N,Y:Inteiro
Resp:Literal
inicio
// Se��o de Comandos
Escreval("Quer Saber Quantos m�ltiplos de 3 existem entre 250 e 3500?")
Escreval("S para sim, N para n�o")
Leia(Resp)
Se Resp = "S" entao



   N:=250
   Para A de N ate 3500 faca
      Se N Mod 3 = 0  Entao
         Y:=Y+1
      Fimse

      N:=N+1
   fimpara
   Escreval("A Quantudade de  M�ltiplos de 3, de 250 ate 3500 �,",Y)
Senao
   Escreval("J� que n�o deseja, encerre o programa")
fimse
fimalgoritmo

