algoritmo "Maior/Menor"
// Fun��o :
// Autor :
// Data : 16/10/2013
// Se��o de Declara��es
var
N,Nu,S,Maior,Menor,X:Inteiro
M:Real
inicio
// Se��o de Comandos
Escreval("Insira qualquer n�mero que desejar, para saber:")
Escreval("*A Soma de Todos")
Escreval("*A M�dia de Todos")
Escreval("*O Maior inserido")
Escreval("*O Menor Inserido")
Escreval("")
Escreval("Para encerar o programa e receber os resultados digite '0'")
Escreval("")
N:=N+1
Escreval("Coloque o,",N,"�")
Leia(Nu)

Maior:=0
Menor:=10000000
Enquanto Nu <> 0 Faca
Se Nu = 0 Entao
Fimse
 Se Nu > Maior Entao
  Maior:=Nu
   Senao
    Se Nu < Menor Entao
     Menor:=Nu
    fimse
fimse
   
   S:=Nu+S
   M:=S/N

  N:=N+1
   Escreval("Coloque o,",N,"�")
   Leia(Nu)
Fimenquanto

Escreval("A Soma de Todos os N�meros � ",S)
Escreval("A M�dia de Todos os N�meros � ",M)
Escreval("O Maior N�mero Inserido � ",Maior)
Escreval("O Menor N�mero Inserido � ",Menor)
Escreval("")
Escreval("Encerrando Programa...")
Escreval("")
Escreval("Obrigado por usar :)")
Escreval("Fim, Precione Esc para sair da aplica��o")


fimalgoritmo
