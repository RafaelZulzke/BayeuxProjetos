import javax.swing.JOptionPane;


public class Principal {
	public static void main(String[] args) {
		
		Funcionario objFuncionario = new Funcionario();
		int opcao;
		do
		{
			opcao = Integer.parseInt(JOptionPane.showInputDialog("Escolha uma das opções:" +
		"\n1 - Cadastrar Cliente" +
					"\n2 - Listar Cliente" +
					"\n3 - Calcular Limite de Crédito" + 
					"\n0 - SAIR"));

switch (opcao)
{
case 1:
objFuncionario.entrarDados();
break;
case 2:
objFuncionario.mostrarDados();
break;
case 3:
objFuncionario.calcularValores();
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
