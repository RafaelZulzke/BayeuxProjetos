algoritmo "Galhardi & Zulzke Company: Desconto&Furto"
// Fun��o : Descobrir quanto ao m�s lhe � roubado por algo que deveria ser seu direito
// Autor :  Daniel Galhardi & Rafael Zulzke
// Data : 18/09/2013
// Se��o de Declara��es 
var
SB,DINSS,DIRPF,SL:REAL
inicio
// Se��o de Comandos
 Escreval("Bem vindo ao 'Galhardi & Zulzke Company: Desconto&Furto'")
 Escreval("A fun��o desse programa � calcular o quanto voc� vai pagar para INSS e do IRPF ")
 Escreval("baseado em seu sal�rio, e mostrar o sal�rio final ap�s os descontos.")
 Escreval("")
 Escreval("Inicio")
 Escreval("")
Escreval("Qual � o Valor do Seu Salario Base")
Leia(SB)

Escreval("Seu sal�rio base �, R$",SB:2:2," foram descontados pelo INSS e IRPF:")
Escreval("")
Se (SB<=1247.70) Entao
DINSS:=SB*0.08
 Senao
  Se(SB <=2079.50) Entao
  DINSS:=SB*0.09
   Senao
    Se (SB <= 4159.00) Entao
       DINSS:=SB*0.11
    fimse
  fimse
Fimse
Escreval("INSS: R$",DINSS:2:2)
Se (SB <= 1710.78) Entao
 DIRPF:=0
  Senao
   Se (SB <= 2563.91) Entao
    DIRPF:=(SB*0.075)-128.31
     Senao
      Se (SB <= 3418.59) Entao
       DIRPF:=(SB*0.15)-320.60
        Senao
         Se (SB<=4271.59) Entao
          DIRPF:=(SB*0.225)-577.00
           Senao
            Se (SB>4271.59) Entao
             DIRPF:=(SB*0.275)-790.58
            fimse
         fimse
      fimse
   fimse
Fimse
Escreval("IRPF: R$",DIRPF:2:2)
Escreval("")
SL:=SB-DINSS-DIRPF
Escreval("Seu sal�rio final com todos os descontos �, R$",SL:2:2)
Escreval("")
Escreval("Obrigado por usar o programa, agora v� e seja roubado!")
Escreval("")
Escreval("Feche a Janela!")
fimalgoritmo
