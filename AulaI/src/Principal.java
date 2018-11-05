import javax.swing.JOptionPane;


public class Principal {

	
	public static void main(String[] args) {
		
		Funcionario objFuncionario = new Funcionario();
		
		int op;
		
		do
		{
			op = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção: " +
		            "\n1 - Cadastrar Funcionário" +
					"\n2 - Listar Funcionário" +
		            "\n3 - Calcular Salário Líquido do Funcionário" +
					"\n0 - SAIR"));
			
			switch (op)
			{
			
			case 1:
				objFuncionario.entradaDados();
				break;
				
			case 2:
				objFuncionario.mostrarDados();
				break;
				
			case 3:
				objFuncionario.calcularValores();
				
			case 0:
				JOptionPane.showMessageDialog(null, "Programa Finalizado.");
				break;
				
			default:
				JOptionPane.showMessageDialog(null, "Opção Inválida.");
				break;
			}
			
			
			}while(op!=0);
			
			
		}

	}

