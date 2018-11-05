algoritmo "Maior/Menor"
// Função :
// Autor :
// Data : 16/10/2013
// Seção de Declarações
var
N,Nu,S,Maior,Menor,X:Inteiro
M:Real
inicio
// Seção de Comandos
Escreval("Insira qualquer número que desejar, para saber:")
Escreval("*A Soma de Todos")
Escreval("*A Média de Todos")
Escreval("*O Maior inserido")
Escreval("*O Menor Inserido")
Escreval("")
Escreval("Para encerar o programa e receber os resultados digite '0'")
Escreval("")
N:=N+1
Escreval("Coloque o,",N,"º")
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
   Escreval("Coloque o,",N,"º")
   Leia(Nu)
Fimenquanto

Escreval("A Soma de Todos os Números é ",S)
Escreval("A Média de Todos os Números é ",M)
Escreval("O Maior Número Inserido é ",Maior)
Escreval("O Menor Número Inserido é ",Menor)
Escreval("")
Escreval("Encerrando Programa...")
Escreval("")
Escreval("Obrigado por usar :)")
Escreval("Fim, Precione Esc para sair da aplicação")


fimalgoritmo
