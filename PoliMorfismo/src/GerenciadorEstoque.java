import javax.swing.JOptionPane;


public class GerenciadorEstoque {
	
	public void comprar(Produto prod){
		int quantidade = Integer.parseInt(JOptionPane.showInputDialog("Digite a quantidade comprada: "));
		
		JOptionPane.showMessageDialog(null, "Estoque anterior de " + prod.getClass().getName() + ": " +
		prod.getEstoqueDisponivel() + "\nQuantidade comprada:" + quantidade + 
		"\nEstoque atual:" + (prod.getEstoqueDisponivel() + quantidade));
		
		prod.setEstoqueDisponivel(prod.getEstoqueDisponivel() + quantidade);
		
	}
	
	public void vender(Produto prod){
		int quantidade = Integer.parseInt(JOptionPane.showInputDialog("Digite a quantidade vendida:"));
		
		JOptionPane.showMessageDialog(null, "Estoque Anterior " + prod.getClass().getName() + ": " +
		prod.getEstoqueDisponivel() + "\nQuantidade vendida:" + quantidade +
		"\nEstoque atual:" + (prod.getEstoqueDisponivel() - quantidade));
		
		prod.setEstoqueDisponivel(prod.getEstoqueDisponivel() - quantidade);
	}
		public void encomendar (Produto  prod)
		{
			
			int qtde = Integer.parseInt(JOptionPane.showInputDialog("Digite a quantidade de " +
			prod.getClass().getName() + " desejada: "));
			
			if(qtde <= prod.getEstoqueDisponivel())
			{
			JOptionPane.showMessageDialog(null,"Encomenda do " + prod.getClass().getName() + "-"+ prod.getDescricao() + "Realizada com Pronta Entrega");
			}
			else{
				JOptionPane.showMessageDialog(null, "Encomenda do " + prod.getClass().getName() + " - " + 
			prod.getDescricao() + " em análise, realizando pedido com fornecedores.");
			}
		}
			
	
	}


