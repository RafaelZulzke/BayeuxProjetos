import javax.swing.JOptionPane;


public class Principal
{
	public static void main(String[] args)
	{
		Autenticacao objLogin = new Autenticacao();
		
		int opcao;
		
		String retorno;
		
		do
		{
			opcao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Op��o:" +
		"\n1 - Visitante\n2 - Usu�rio Tempor�rio\n3 - Usu�rio\n4 - Administrador\n0 - SAIR"));
			switch (opcao)
			{
			case 1:
				retorno = objLogin.validar();
				JOptionPane.showMessageDialog(null, retorno);
			break;
			
			case 2:
				int senha = Integer.parseInt(JOptionPane.showInputDialog("Digite a Senha para Verifica��o"));
				retorno = objLogin.validar(senha);
				JOptionPane.showMessageDialog(null, retorno);
			break;
			
			case 3:
				String senha1 = JOptionPane.showInputDialog("Digite a Senha para Verifica��o");
				retorno = objLogin.validar(senha1);
				JOptionPane.showMessageDialog(null, retorno);
			break;
			
			case 4:
				String login = JOptionPane.showInputDialog("Digite o seu Login para Verifica��o");
				String senha2 = JOptionPane.showInputDialog("Digite a sua Senha para Verifica��o");
				retorno = objLogin.validar(login, senha2);
				JOptionPane.showMessageDialog(null, retorno);
			break;
			
			case 0:
				JOptionPane.showMessageDialog(null, "Programa Terminado....");
			break;

			default:
				JOptionPane.showMessageDialog(null, "Op��o Inv�lida!");
			break;
			}
			
		}while(opcao!=0);
	}
}
