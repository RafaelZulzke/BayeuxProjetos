import javax.swing.JOptionPane;


public class GerenciadorEstoque extends Produto {

	private double ValorEstoque;
	

	public double getValorEstoque() {
		return ValorEstoque;
	}

	public void setValorEstoque(double valorEstoque) {
		ValorEstoque = valorEstoque;
	}

	public void comprar(Produto prod){
		
		int quantidade = Integer.parseInt(JOptionPane.showInputDialog("Digite a quantidade comprada:"));
		JOptionPane.showMessageDialog(null, "Estoque anterior de " + prod.getClass().getName() + ": " +
		prod.getEstoqueDisponivel() + "\nQuantidade comrada:" + quantidade +
		"\nEstoque atual:" + (prod.getEstoqueDisponivel() +quantidade));
		
		prod.setEstoqueDisponivel(prod.getEstoqueDisponivel() + quantidade);
	}
	
	public void vender(Produto prod) {
		
		int quantidade = Integer.parseInt(JOptionPane.showInputDialog("Digite a quantidade vendida:"));
		JOptionPane.showMessageDialog(null, "Estoque anterior " + prod.getClass().getName() + ": " +
		prod.getEstoqueDisponivel() + "\nQuantidade vendida:" + quantidade +
		"\nEstoque atual: " + (prod.getEstoqueDisponivel() - quantidade));
		prod.setEstoqueDisponivel(prod.getEstoqueDisponivel() - quantidade);
	}
	
	public void encomendar (Produto prod) {
	
	int qtde = Integer.parseInt(JOptionPane.showInputDialog("Digite a quantidade de " + prod.getClass().getName() + " desejada: "));



	if(qtde <= prod.getEstoqueDisponivel());
	{
	JOptionPane.showMessageDialog(null, "Encomenda do" + prod.getClass().getName() + "-"   + prod.getDescricao() + "realizada com pronta entrega.");
	}

	if(qtde >= prod.getEstoqueDisponivel());
	
	{
		JOptionPane.showMessageDialog(null, "Encomenda do " + prod.getClass().getName() + "–"  + prod.getDescricao() + "em análise, realizando pedido com fornecedores.");
	
	}
	
	}
	
	
	public void criarListaProdutos() {
		// Declaração e inicialização de variáveis de controle de menu e índice do array
		int opProd = 0, índice = 0;
		// Declara e inicializa como nulo um objeto (uma referência) do tipo Produto
		Produto prod = null;
		// Instancia um array do tipo Produto de 10 posições chamado produtos
		Produto produtos[] = new Produto[10];

		do
		{
		// Apresenta menu de produtos
		opProd = Integer.parseInt(JOptionPane.showInputDialog("Digite o produto desejado: " + "\n1 – Livro \n2 – CD \n3 – DVD \n0 –Listar produtos cadastrados"));

		// Verifica o produto escolhido, instancia um objeto de acordo com  a opção
		// e atribui sua referência ao objeto prod
		if(opProd == 1);
		{
		prod = new Livro();
		}
		if(opProd == 2) ;
		{
		prod = new CD();
		}
		if(opProd == 3);
		{
		prod = new DVD();
		}
		// Se não foi escolhida a opção Listar produtos cadastrados
		if(opProd !=0)
		{
		// Lê a descrição, o estoque disponível e o preço de custo do objeto instanciado
		prod.setDescricao(JOptionPane.showInputDialog("Digite a descrição: "));
		prod.setEstoqueDisponivel(Integer.parseInt(JOptionPane.showInputDialog("Digite o estoque disponível: ")));
		prod.setPrecoCusto(Double.parseDouble(JOptionPane.showInputDialog("Digite o preço de custo:")));

		//Atribui o objeto instanciado no array produtos
		produtos[índice] = prod;
		//Incrementa do índice
		índice++;
		// Destrói o objeto (limpa a referência)
		prod = null;
		}
		// Enquanto a opção Lista produtos cadastrados não for escolhida
		// repete as operações do looping
		} while(opProd != 0);
	
		// Apresenta os produtos armazenados no array produtos utilizando o método mostraListaProdutos
		JOptionPane.showMessageDialog(null, mostrarListaProdutos(índice,produtos) + "\n");
		
	}
		// método privado para leitura do array produtos
		// recebe a quantidade de itens lidos (tamanho) e o array produtos
		private String mostrarListaProdutos(int tamanho,Produto[] prod) {
		// Monta uma string começando com um cabeçalho
		String relacao="Relação de Produtos Cadastrados\n";
		// e concatenando cada um dos produtos armazenados no array
		for(int i = 0;1 < tamanho; i++) 
		{
		relacao = relacao + "\n" + String.valueOf(i) + " – Tipo:"  + prod[i].getClass().getName() + "- Descricao" + prod[i].getDescricao()+ "-Estoque" + prod[i].getEstoqueDisponivel()+" – Preço Custo: " + prod[i].getPrecoCusto();
		}
		// Retorna uma string com todos os produtos contidos no array
		return relacao;
		}
		
		// Método implementado para testar passagem de array por parâmetro
		public void totalizadorEstoque(Produto produtos[]) {
			
		// Zera o valor total de estoque (para não acumular com a totalização anterior)
		this.setValorEstoque(0);
		// Percorre o array recebido por parâmetro do índice zero até seu tamanho total
		for (int i = 0; i <= produtos.length - 1; i++) {
		// Apresenta o produto e o preço de custo analisado
		JOptionPane.showMessageDialog(null, "Produto: " + produtos[i].getClass().getName() + "\nPreço de custo:" + produtos[i].getPrecoCusto() + "\nQuantidade: " + produtos[i].getEstoqueDisponivel());
		// Soma em valorTotalEstoque
		this.setValorEstoque(this.ValorEstoque += ( produtos[i].getPrecoCusto() * produtos[i].getEstoqueDisponivel()));
		}
		// Apresenta o total
		JOptionPane.showMessageDialog(null, "Total em estoque:" + this.getValorEstoque());
		}

	
	
}

