algoritmo "Galhardi & Zulzke, Company: TestPassWord"
// Fun��o : Tela de Bloqueio a qual se n�o inserir os caracteres corretamente, fecha o programa
// Autor :  Daniel Galhardi & Rafael Zulzke
// Data : 16/09/2013
// Se��o de Declara��es
var
Senha:LITERAL
inicio
// Se��o de Comandos
Escreval("Bem Vindo ao 'Galhardi & Zulzke, Company: TestPassWord'")
Escreval("    ")
Escreval("Este � um programa que diz onde achar as respostas para as grandes ")
Escreval("quest�es da humanidade.")
Escreval("S� � necess�rio acertar a Senha")
Escreval("      ")
Escreval("Inicio")
Escreval("        ")
Escreval("Digite sua Senha,")
leia(Senha)

 Se (Senha="ASDFG") ou (Senha="joao8_32") ou (Senha="oi_eu_sou_o_goku") entao
   Escreval("Acesso Permitido")
   Escreval("       ")
   Escreval("Para saber todas as respostas, leia a b�blia!")
   Escreval("Ela tem a verdade!")
   Escreval("    ")
   Escreval("'Conhecereis a verdade e a verdade vos libertara'- Jo�o 8:32")
  Senao
   Escreval("Acesso Negado")
   Escreval("Feche a Janela")

 Fimse
fimalgoritmo
