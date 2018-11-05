import javax.swing.JOptionPane;


public class Movimentação {

	public static void main(String[] args) {
		
		Cliente objCliente = new Cliente();
		Produto objProduto = new Produto();
	
	int op, qtde;
	double rtLimite, rtPedido;
	boolean rtConfirmar;
	
	do
	{
		op = Integer.parseInt(JOptionPane.showInputDialog("1 - Cadastrar Cliente " +
	"\n2 - Listar Cliente" +
				"\n3 - Cadastrar Produto" +
	"\n4 - Listar Produto " +
				"\n5 - Calcular Limite de Crédito" + 
	"\n6 - Vender " + 
				"\n0 - Sair"));
		switch (op)
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
			objProduto.listarProduto();
			break;
			
		case 5:
			rtLimite = objCliente.calcularLimiteCredito();
			JOptionPane.showMessageDialog(null, "Limite de Crédito: R$ " +rtLimite);
			break;
			
		case 6:
			qtde = Integer.parseInt(JOptionPane.showInputDialog("Digite a quantidade."));
			rtConfirmar = objProduto.confirmarProduto(qtde);
			
			if (rtConfirmar == true)
			{
				rtPedido = objProduto.pedido(qtde);
				rtConfirmar = objCliente.confirmarCompra(rtPedido);
				
				if (rtConfirmar == true)
					objProduto.vender(qtde);
				
				else
					JOptionPane.showMessageDialog(null, "Limite de Crédito do cliente é Insuficiente.");
			}
			
			else
				JOptionPane.showMessageDialog(null, "Quantidade solicitada do produto indisponivel.");
			break;
			
		case 0:
			JOptionPane.showMessageDialog(null, "Programa encerrado.");
			break;
			
			default:
				JOptionPane.showMessageDialog(null, "Opção Inválida. ");
				break;
			}
		}while(op!=0);
	}
}
