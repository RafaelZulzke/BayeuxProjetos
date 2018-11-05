import javax.swing.JOptionPane;


public class Principal {

	public static void main(String[] args) {
       autenticacao objAutenticacao = new autenticacao ();
	
	int opcao;
	String s,A;
	do
	{
		opcao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção" +
				"\n1 - Visitante " +
				"\n2 - Usuário Temporário" + 
				"\n3 - Usuário" +
				"\n4 - Administrador" +
                 "\n0 - Sair"));
	
	
	switch (opcao)
	{
	case 1:
		s=objAutenticacao.Validar();
		JOptionPane.showMessageDialog(null, "" + s);
		break;
	case 2:
		int senha = Integer.parseInt(JOptionPane.showInputDialog("Digite a senha: "));
		objAutenticacao.Validar(senha );
		JOptionPane.showMessageDialog(null, "" + senha);
		break;
	case 3:
		String se = JOptionPane.showInputDialog("Digite a senha:");
		se=objAutenticacao.Validar(se);
		JOptionPane.showMessageDialog(null, "" + se);
		break;
    case 4:
		String s1 = JOptionPane.showInputDialog("Digite o login:"); 
		String s2 = JOptionPane.showInputDialog("Digite a senha:");
		s1=objAutenticacao.Validar(s1);
		s2=objAutenticacao.Validar(s2);
		JOptionPane.showMessageDialog(null, "" + s1);
		JOptionPane.showMessageDialog(null, "" + s2);
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

	

