import javax.swing.JOptionPane;


public class Principal_Movimentação {
	public static void main(String[] args)
	{
		Cliente objCliente = new Cliente();
		Produto objProduto = new Produto();
		
		int op;
		double RetornoLimite,RetornoPedido;
		boolean RetornoConfirmar;
		
		do
		{
			op = Integer.parseInt(JOptionPane.showInputDialog("Escolha Opção" +
					"\n1 - Cadastrar Cliente" +
					"\n2 - Listar Cliente" +
					"\n3 - Cadastrar Produto" +
					"\n4 - Listar Produto" +
					"\n5 - Calcular Limite de Crédito" +
					"\n6 - Vender" +
					"\n0 - SAIR"));
			
	switch(op)
		
		{
		
		case 1:
		{
			objCliente.CadastrarCliente();
		break;
		}
		
		case 2 :
		{
			objCliente.ListarDados();
		break;
		}
		
		case 3:
		{
			objProduto.cadastrarProduto();
			break;
		}
		
		case 4:
		{
			objProduto.ListarProduto();
			break;
		}
		case 5:
			
		{
			RetornoLimite = objCliente.CalcularLimiteCredito();
			JOptionPane.showMessageDialog(null,"Limite de Credito" + RetornoLimite);
	    break;
		}
		
		case 6:
		{
			int Quantia = Integer.parseInt(JOptionPane.showInputDialog("Digite a Quantidade da Compra"));
			RetornoConfirmar = objProduto.CorfirmarPedido(Quantia);
			if (RetornoConfirmar == true)
			{
				RetornoPedido = objProduto.pedido(Quantia);
				RetornoConfirmar = objCliente.ConfirmarCompra(RetornoPedido);
				if (RetornoConfirmar == true)
					objProduto.Vender(Quantia);
				else
					JOptionPane.showMessageDialog(null, "Limite de Crédito do Cliente Insuficiente...");
			}
			else
				JOptionPane.showMessageDialog(null, "Quantidade desejada do Produto indisponível...");	
		break;
		}
		case 0:
		{
		JOptionPane.showMessageDialog(null, "Programa Terminado!");
		break;
		}
		default:
		{
			JOptionPane.showMessageDialog(null, "Opção Inválida...");
		break;
		}
		
		}

			
		}while(op !=0);
	}

}
