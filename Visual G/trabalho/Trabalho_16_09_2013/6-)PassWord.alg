algoritmo "Galhardi & Zulzke, Company: TestPassWord"
// Função : Tela de Bloqueio a qual se não inserir os caracteres corretamente, fecha o programa
// Autor :  Daniel Galhardi & Rafael Zulzke
// Data : 16/09/2013
// Seção de Declarações
var
Senha:LITERAL
inicio
// Seção de Comandos
Escreval("Bem Vindo ao 'Galhardi & Zulzke, Company: TestPassWord'")
Escreval("    ")
Escreval("Este é um programa que diz onde achar as respostas para as grandes ")
Escreval("questões da humanidade.")
Escreval("Só é necessário acertar a Senha")
Escreval("      ")
Escreval("Inicio")
Escreval("        ")
Escreval("Digite sua Senha,")
leia(Senha)

 Se (Senha="ASDFG") ou (Senha="joao8_32") ou (Senha="oi_eu_sou_o_goku") entao
   Escreval("Acesso Permitido")
   Escreval("       ")
   Escreval("Para saber todas as respostas, leia a bíblia!")
   Escreval("Ela tem a verdade!")
   Escreval("    ")
   Escreval("'Conhecereis a verdade e a verdade vos libertara'- João 8:32")
  Senao
   Escreval("Acesso Negado")
   Escreval("Feche a Janela")

 Fimse
fimalgoritmo
