import javax.swing.JOptionPane;


public class Principal

        {

	public static void main(String[] args)
		
	{
		Automovel objAutomovel = new Automovel();
		
		int opcao;
		
		do
		{
			opcao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Op��o" +
											"\n1 - Cadastrar Autom�vel" +
											"\n2 - Listar Informa��es" + 
											"\n3 - Calcular Pre�o Final" +
											"\n0 - Sair"));
			switch (opcao)
			{
			case 1:
				objAutomovel.EntradaDados();
				break;
			case 2:
				objAutomovel.MostrarDados();
				break;
			case 3:
				objAutomovel.CalcularValores();
				break;
			case 0:
				JOptionPane.showMessageDialog(null, "Programa Terminado!");
				break;
			default:
				JOptionPane.showMessageDialog(null, "Op��o Inv�lida!!!");
				break;
			}
		}while(opcao!=0);
	}
}




	


