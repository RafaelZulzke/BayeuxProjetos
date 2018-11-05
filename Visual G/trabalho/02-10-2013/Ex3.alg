algoritmo "Ex3"
// Função :
// Autor :
// Data : 02/10/2013
// Seção de Declarações
var

I,K,N:Inteiro
SN,N1,MA,MG,SG:Real

inicio
// Seção de Comandos

Escreval("Quantos alunos há na sala?")
Leia(N)

Para I de 1 ate N faca
   Para K de 1 ate 3 faca
      Escreval("Digite a ",K,"ª Nota do",I,"º Aluno")
      Leia(N1)

      SN:=SN+N1

   Fimpara

   SG:=SG+SN
   MA:=SN/3

   Escreval("A média do, ",I,"º Aluno,",MA)

   MA:=0
   SN:=0

Fimpara

MG:=SG/N

Escreval("A média geral da sala é,"MG)

fimalgoritmo
