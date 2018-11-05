import javax.swing.JOptionPane;


public class Principal  {

	public static void main(String[] args)
	{
		Validador objValidador = new Validador();
		Operador objOpe = new Operador();
		Cliente objCli = new Cliente();
		Administrador objAdm = new Administrador();
		int opcao=0, operacao = 0,codPassagem;

		do {
			opcao= Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção de Produto" +
					"\n1 - Cliente " +
					"\n2 - Operador " + 
					"\n3 - Administrador" +
					"\n0 - Sair"));
		switch(opcao)
		{
		case 1://Cliente
			do
			{
			operacao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção" +
					"\n1 - Logar no Sistema" + "\n2 - Cadastrar Cliente" +
					"\n3 - Visualizar Cliente" +
					"\n0 - Voltar ao Menu Anterior"));
			if (operacao == 1) objValidador.validarUsuario(objCli);
			if (operacao == 2) objCli.cadastrarCliente();
			if (operacao == 3) objCli.apresentarCliente();
			}while(operacao!=0);
			break;
		case 2://Operador
			do
			{
			operacao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção" +
					"\n1 - Logar no Sistema" + "\n2 - Cadastrar Operador" +
					"\n3 - Visualizar Operador" +
					"\n4 - Calcular Salário Final" +
					"\n0 - Voltar ao Menu Anterior"));
			if (operacao == 1)
				{
					codPassagem = Integer.parseInt(JOptionPane.showInputDialog("Digite o Código de Acesso"));
					objAdm.autorizarUsuario(codPassagem, objOpe);
				}
			if (operacao == 2) objOpe.CadastrarOperador();
			if (operacao == 3) objOpe.apresentarOperador();
			if (operacao == 4)
				{
					double varComissao = objOpe.calcularSalario();
					JOptionPane.showMessageDialog(null, "Valor da Comissão: R$ " + varComissao);
				}
			}while(operacao!=0);
			break;
		case 3://Administrador
			do
			{
			operacao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção" +
					"\n1 - Logar no Sistema" + "\n2 - Autorizar Usuário" +
					"\n3 - Calcular Limite de Crédito" +
					"\n0 - Voltar ao Menu Anterior"));
			if (operacao == 1)
				{
					codPassagem = Integer.parseInt(JOptionPane.showInputDialog("Digite o Código de Acesso"));
					objAdm.autorizarUsuario(codPassagem, objAdm);
				}
			if (operacao == 2) objAdm.autorizarUsuario(10, objOpe);
			if (operacao == 3) objAdm.calcularLimiteCredito(10, objCli);
			}while(operacao!=0);
			break;
		case 0://Sair
			JOptionPane.showMessageDialog(null, "Programa Terminado!");
			break;
		default:
			JOptionPane.showMessageDialog(null, "Opção Inválida...");
			break;
		}
	}while(opcao!=0);
}
}


