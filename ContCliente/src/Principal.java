import javax.swing.JOptionPane;

public class Principal {

	public static void main(String[] args) {
	
		Cliente objCliente = new Cliente();
		
		/* •	Apresentar um menu com as opções: 
                1 – Cadastrar Cliente
                2 – Listar Cliente
                3 – Calcular Limite de Crédito
                0 – Sair */
		
		int opc;
		
		do
		{
			opc = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção"+
		                                                        "\n1 - Cadastrar Cliente"+
		                                                        "\n2 - Listar Cliente"+
		                                                        "\n3 - Calcular Limite de Crédito"+
		                                                        "\n0 - Sair"));
			
			switch (opc)
			{
			case 1:
				objCliente.cadastrarCliente();
				break;
			
			case 2:
				objCliente.ListarCliente();
				break;
				
			case 3:
				objCliente.CalcularLC();
			break;
				
			case 0:
				JOptionPane.showMessageDialog(null, "Programa Encerrado.");
        		break;
			}
		}while (opc!=0);
	}
	}
	
		
	
		
	
	
	
	