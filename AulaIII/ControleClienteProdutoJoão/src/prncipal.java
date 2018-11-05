import javax.swing.JOptionPane;

public class prncipal
{
	public static void main(String[] args)
	{
		Cliente objCliente = new Cliente();
		Produto objProduto = new Produto();
		
		int opcao;
		double retornoLimite, retornoPedido;
		boolean retornoConfirmar;
		
		do
		{
			
		opcao = Integer.parseInt(JOptionPane.showInputDialog("Escolha Opção" +
											"\n1 - Cadastrar Cliente" +
											"\n2 - Listar Cliente" +
											"\n3 - Cadastrar Produto" +
											"\n4 - Listar Produto" +
											"\n5 - Calcular Limite de Crédito" +
											"\n6 - Vender" +
											"\n0 - SAIR"));

		switch (opcao)
		{
		case 1:
			objCliente.cadastrarCliente();
		break;
		case 2:
			objCliente.listarCliente();
		break;
		case 3:
			objProduto.cadastrarProduto();
		break;
		case 4:
			objProduto.listarproduto();
		break;
		case 5:
			retornoLimite = objCliente.calcularLimiteCredito();
			JOptionPane.showMessageDialog(null, "Limite de Crédito: R$ " + retornoLimite);
		break;
		case 6:
			int quantidade = Integer.parseInt(JOptionPane.showInputDialog("Digite a Quantidade da Compra"));
			retornoConfirmar = objProduto.confirmarPedido(quantidade);
			if (retornoConfirmar == true)
			{
				retornoPedido = objProduto.pedido(quantidade);
				retornoConfirmar = objCliente.confirmarCompra(retornoPedido);
				if (retornoConfirmar == true)
					objProduto.vender(quantidade);
				else
					JOptionPane.showMessageDialog(null, "Limite de Crédito do Cliente Insuficiente...");
			}
			else
				JOptionPane.showMessageDialog(null, "Quantidade desejada do Produto indisponível...");
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
