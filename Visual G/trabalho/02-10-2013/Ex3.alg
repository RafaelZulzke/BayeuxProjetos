algoritmo "Ex3"
// Fun��o :
// Autor :
// Data : 02/10/2013
// Se��o de Declara��es
var

I,K,N:Inteiro
SN,N1,MA,MG,SG:Real

inicio
// Se��o de Comandos

Escreval("Quantos alunos h� na sala?")
Leia(N)

Para I de 1 ate N faca
   Para K de 1 ate 3 faca
      Escreval("Digite a ",K,"� Nota do",I,"� Aluno")
      Leia(N1)

      SN:=SN+N1

   Fimpara

   SG:=SG+SN
   MA:=SN/3

   Escreval("A m�dia do, ",I,"� Aluno,",MA)

   MA:=0
   SN:=0

Fimpara

MG:=SG/N

Escreval("A m�dia geral da sala �,"MG)

fimalgoritmo
