import javax.swing.JOptionPane;


public class Principal {

	
	public static void main(String[] args) {
		
		Funcionario objFuncionario = new Funcionario();
		
		int op;
		
		do
		{
			op = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Op��o: " +
		            "\n1 - Cadastrar Funcion�rio" +
					"\n2 - Listar Funcion�rio" +
		            "\n3 - Calcular Sal�rio L�quido do Funcion�rio" +
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
				JOptionPane.showMessageDialog(null, "Op��o Inv�lida.");
				break;
			}
			
			
			}while(op!=0);
			
			
		}

	}

