import javax.swing.JOptionPane;

public class GerenciadorEstoque
{
	public void comprar(Produto prod)//Ok
	{
		int quantidade = Integer.parseInt(JOptionPane.showInputDialog("Digite a Quantidade Comprada"));
		
		JOptionPane.showMessageDialog(null, "Estoque Anterior de " + prod.getClass().getName() +
				": " + prod.getEstoqueDisponivel() + "\nQuantidade Comprada: " + quantidade +
				"\nEstoque Atual: " + (prod.getEstoqueDisponivel() + quantidade));
		
		prod.setEstoqueDisponivel(prod.getEstoqueDisponivel() + quantidade);
	}
	
	public void vender(Produto prod)//Ok
	{
		int quantidade = Integer.parseInt(JOptionPane.showInputDialog("Digite a Quantidade Vendida"));
		
		JOptionPane.showMessageDialog(null, "Estoque Anterior de " + prod.getClass().getName() +
				": " + prod.getEstoqueDisponivel() + "\nQuantidade Vendida: " + quantidade +
				"\nEstoque Atual: " + (prod.getEstoqueDisponivel() - quantidade));
		
		prod.setEstoqueDisponivel(prod.getEstoqueDisponivel() - quantidade);
	}
	
	public void encomendar(Produto prod)//Ok
	{
		int quantidade = Integer.parseInt(JOptionPane.showInputDialog("Digite a Quantidade de " + prod.getClass().getName() + " desejada:"));
		
		if (quantidade <= prod.getEstoqueDisponivel())
			JOptionPane.showMessageDialog(null, "Encomenda do " + prod.getClass().getName() + " - " +
						prod.getDescricao() + " realizada com pronta Entrega!");
		else
			JOptionPane.showMessageDialog(null, "Encomenda do " + prod.getClass().getName() + " - " +
					prod.getDescricao() + " em analise, reaizando pedido com fornecedores!");
	}
	
	public void totalizadorEstoque(Produto produto[])
	{
		double valorTotalEstoque = 0;
		for (int i=0; i <= produto.length - 1; i++)
		{
			JOptionPane.showMessageDialog(null, "Produto: " + produto[i].getClass().getName() +
					"\nPreço de Custo: R$ " + produto[i].getPrecoCusto() +
					"\nQuantidade: " + produto[i].getEstoqueDisponivel());
			
			valorTotalEstoque = valorTotalEstoque += (produto[i].getPrecoCusto() *
					produto[i].getEstoqueDisponivel());
		}
		JOptionPane.showMessageDialog(null, "Total em Estoque: R$ " + valorTotalEstoque);
	}
	
	public void criarListaProduto()
	{
		int opProd=0, indice=0;
		Produto prod = null;
		Produto produtos[] = new Produto[10];
		
		do
		{
			opProd = Integer.parseInt(JOptionPane.showInputDialog("Digite o Produto Desejado: " + 
					"\n1 - Livro\n2 - CD\n3 - DVD\n4 - Listar Produtos Cadastrados"));
			
			if (opProd == 1) prod = new Livro();
			
			if (opProd == 2) prod = new CD();
			
			if (opProd == 3) prod = new DVD();
			
			//if (opProd == 4); listar cadastrados
			
			if (opProd != 0)
			{
				prod.setDescricao(JOptionPane.showInputDialog("Digite a Descrição: "));
				prod.setEstoqueDisponivel(Integer.parseInt(JOptionPane.showInputDialog("Digite o Estoque Disponível: ")));
				prod.setPrecoCusto(Double.parseDouble(JOptionPane.showInputDialog("Digite o Preço de Custo: R$ ")));
				
				produtos[indice] = prod;
				
				indice++;
				
				prod = null;
			}
			
		}while(opProd != 0);
		
		JOptionPane.showMessageDialog(null, mostrarListaProduto(indice, produtos) + "\n");
	}
	
	public String mostrarListaProduto(int tamanho, Produto prod[])
	{
		String relacao = "Relação de Produtos Cadastrados\n";
		
		for (int i=0; i < tamanho; i++)
		{
			relacao = relacao + "\n" + String.valueOf(i) + " - Tipo: " + prod[i].getClass().getName() +
					" - Descrição: " + prod[i].getDescricao() + " - Estoque: " + prod[i].getEstoqueDisponivel() +
					" - Preço de Custo: R$ " + prod[i].getPrecoCusto();
		}
		
		return relacao;
	}
}
