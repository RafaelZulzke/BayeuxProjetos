algoritmo "ex3"
// Função :
// Autor :
// Data : 07/10/2013
// Seção de Declarações 
var
Resp,Sx,M:literal
V,QM,QF,VM,VF,VV,VT,TV,MV,A,VMT,VFT:REAL
inicio
// Seção de Comandos


Escreval("Digite o sexo do vendedor(a)  <M> ou <F>")
Leia(Sx)
Se Sx= M entao
QM:=QM+1
Senao
QF:=QF+1
Fimse
Escreval("Insira o valor da Venda")
Leia(VV)
Se Sx = M Entao
VM:=VV
VMT:=VM+VMT
Senao
VF:=VV
VFT:=VF+VFT
Fimse
Fimenquanto
VT:=VMT+VFT
TV:=QM+QF
MV:=VT/TV
SE MV=<10,000 Entao
A:=2
Senao
SE MV>=25,000 Entao
A:=3
SE MV>25,000 Entao
A:=4
FIMSE
FIMSE
FIMSE
ESCREVAL("O total de vendas da loja foi",VT)
escreval("O total de vendedores masculinos é",QM)
ESCREVAL("O total de vendas masculino foi",VMT:2,"R$")
escreval("O total de vendedoras femininas é",QF)
ESCREVAL("O total de vendas feminina foi",VFT:2,"R$")
escreval("A média de vendas foi",MV)
ESCREVAL("O total de vendedores foi",TV)
escreval("O acrescimo no salario de todos os vendedores foi",A,"%"

fimalgoritmo
