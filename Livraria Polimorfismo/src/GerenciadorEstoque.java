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
		JOptionPane.showMessageDialog(null, "Encomenda do " + prod.getClass().getName() + "�"  + prod.getDescricao() + "em an�lise, realizando pedido com fornecedores.");
	
	}
	
	}
	
	
	public void criarListaProdutos() {
		// Declara��o e inicializa��o de vari�veis de controle de menu e �ndice do array
		int opProd = 0, �ndice = 0;
		// Declara e inicializa como nulo um objeto (uma refer�ncia) do tipo Produto
		Produto prod = null;
		// Instancia um array do tipo Produto de 10 posi��es chamado produtos
		Produto produtos[] = new Produto[10];

		do
		{
		// Apresenta menu de produtos
		opProd = Integer.parseInt(JOptionPane.showInputDialog("Digite o produto desejado: " + "\n1 � Livro \n2 � CD \n3 � DVD \n0 �Listar produtos cadastrados"));

		// Verifica o produto escolhido, instancia um objeto de acordo com  a op��o
		// e atribui sua refer�ncia ao objeto prod
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
		// Se n�o foi escolhida a op��o Listar produtos cadastrados
		if(opProd !=0)
		{
		// L� a descri��o, o estoque dispon�vel e o pre�o de custo do objeto instanciado
		prod.setDescricao(JOptionPane.showInputDialog("Digite a descri��o: "));
		prod.setEstoqueDisponivel(Integer.parseInt(JOptionPane.showInputDialog("Digite o estoque dispon�vel: ")));
		prod.setPrecoCusto(Double.parseDouble(JOptionPane.showInputDialog("Digite o pre�o de custo:")));

		//Atribui o objeto instanciado no array produtos
		produtos[�ndice] = prod;
		//Incrementa do �ndice
		�ndice++;
		// Destr�i o objeto (limpa a refer�ncia)
		prod = null;
		}
		// Enquanto a op��o Lista produtos cadastrados n�o for escolhida
		// repete as opera��es do looping
		} while(opProd != 0);
	
		// Apresenta os produtos armazenados no array produtos utilizando o m�todo mostraListaProdutos
		JOptionPane.showMessageDialog(null, mostrarListaProdutos(�ndice,produtos) + "\n");
		
	}
		// m�todo privado para leitura do array produtos
		// recebe a quantidade de itens lidos (tamanho) e o array produtos
		private String mostrarListaProdutos(int tamanho,Produto[] prod) {
		// Monta uma string come�ando com um cabe�alho
		String relacao="Rela��o de Produtos Cadastrados\n";
		// e concatenando cada um dos produtos armazenados no array
		for(int i = 0;1 < tamanho; i++) 
		{
		relacao = relacao + "\n" + String.valueOf(i) + " � Tipo:"  + prod[i].getClass().getName() + "- Descricao" + prod[i].getDescricao()+ "-Estoque" + prod[i].getEstoqueDisponivel()+" � Pre�o Custo: " + prod[i].getPrecoCusto();
		}
		// Retorna uma string com todos os produtos contidos no array
		return relacao;
		}
		
		// M�todo implementado para testar passagem de array por par�metro
		public void totalizadorEstoque(Produto produtos[]) {
			
		// Zera o valor total de estoque (para n�o acumular com a totaliza��o anterior)
		this.setValorEstoque(0);
		// Percorre o array recebido por par�metro do �ndice zero at� seu tamanho total
		for (int i = 0; i <= produtos.length - 1; i++) {
		// Apresenta o produto e o pre�o de custo analisado
		JOptionPane.showMessageDialog(null, "Produto: " + produtos[i].getClass().getName() + "\nPre�o de custo:" + produtos[i].getPrecoCusto() + "\nQuantidade: " + produtos[i].getEstoqueDisponivel());
		// Soma em valorTotalEstoque
		this.setValorEstoque(this.ValorEstoque += ( produtos[i].getPrecoCusto() * produtos[i].getEstoqueDisponivel()));
		}
		// Apresenta o total
		JOptionPane.showMessageDialog(null, "Total em estoque:" + this.getValorEstoque());
		}

	
	
}

