import javax.swing.JOptionPane;

public class Principal
{
	public static void main(String[] args)
	{
		Funcionarios objFuncionarios = new Funcionarios();
		
		int opcao;
		
		do
		{
			
		opcao = Integer.parseInt(JOptionPane.showInputDialog("Escolha Op��o" +
											"\n1 - Cadastrar Cliente" +
											"\n2 - Listar Cliente" +
											"\n3 - Calcular Limite de Cr�dito" + 
											"\n0 - SAIR"));

		switch (opcao)
		{
		case 1:
			objFuncionarios.entrarDados();
		break;
		case 2:
			objFuncionarios.mostrarDados();
		break;
		case 3:
			objFuncionarios.calcularValores();
		break;
		case 0:
			JOptionPane.showMessageDialog(null, "Programa Terminado!");
		break;
		default:
			JOptionPane.showMessageDialog(null, "Op��o Inv�lida...");
		break;
		}
		
		}while(opcao!=0);	
	}
}

