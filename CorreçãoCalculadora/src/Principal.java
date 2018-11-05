import javax.swing.JOptionPane;

public class Principal
{
	public static void main(String[] args)
	{
		ClasseM objClasseM = new ClasseM();
		
		int opcao;
		double passagemA, passagemB;
		
		do
		{
			opcao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção:" +
					"\n1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n0 - SAIR"));
			switch (opcao)
			{
			case 1://Somar
				objClasseM.somar();
			break;
			
			case 2://Subtrair
				passagemA = Double.parseDouble(JOptionPane.showInputDialog("Digite o Valor de A"));
				passagemB = Double.parseDouble(JOptionPane.showInputDialog("Digite o Valor de B"));
				objClasseM.subtrair(passagemA, passagemB);
			break;
				
			case 3://Multiplicar
				double retornoMultiplicar = objClasseM.multiplicar();
				JOptionPane.showMessageDialog(null, "Resultado da Multiplicação: " + retornoMultiplicar);
			break;
				
			case 4://Dividir
				passagemA = Double.parseDouble(JOptionPane.showInputDialog("Digite o Valor de A"));
				passagemB = Double.parseDouble(JOptionPane.showInputDialog("Digite o Valor de B"));
				double retornoDividir = objClasseM.dividir(passagemA, passagemB);
				JOptionPane.showMessageDialog(null, "Resultado da Divisão: " + retornoDividir);
			break;
				
			case 0:
				JOptionPane.showMessageDialog(null, "Programa Terminado!");
			break;

			default:
				JOptionPane.showMessageDialog(null, "Opção Inválida...");
			break;
			}			
		}while(opcao!=0);
	}
}

