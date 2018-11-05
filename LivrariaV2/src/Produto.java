import javax.swing.JOptionPane;


public class Produto {
	
	//Atributos
	private String descricao;
	private String genero;
	private int estoqueDisponivel;
	private double precoVenda;
	public double precoCusto;
	
	// Construtores
	public Produto(String descricao, String genero, int estoqueDisponivel,
			double precoCusto, double precoVenda) {
		super();
		this.descricao = descricao;
		this.genero = genero;
		this.estoqueDisponivel = estoqueDisponivel;
		this.precoCusto = precoCusto;
		this.precoVenda = precoVenda;
	}
	
	public Produto()
	{
		this("","", 0, 0, 0);
	}
	
	// Getters and Setters
	
	public String getDescricao() {
		return descricao;
	}

	public void setDescricao(String descricao) {
		this.descricao = descricao;
	}

	public String getGenero() {
		return genero;
	}

	public void setGenero(String genero) {
		this.genero = genero;
	}

	public int getEstoqueDisponivel() {
		return estoqueDisponivel;
	}

	public void setEstoqueDisponivel(int estoqueDisponivel) {
		this.estoqueDisponivel = estoqueDisponivel;
	}

	public double getPrecoCusto() {
		return precoCusto;
	}

	public void setPrecoCusto(double precoCusto) {
		this.precoCusto = precoCusto;
	}

	public double getPrecoVenda() {
		return precoVenda;
	}

	public void setPrecoVenda(double precoVenda) {
		this.precoVenda = precoVenda;
	}
	
	// Métodos Específicos da Classe
	
	// Recebe a quantidade comprada por parametro
	public void comprar (int qtde)
	{
		int estoqueAnterior = getEstoqueDisponivel();
		setEstoqueDisponivel(getEstoqueDisponivel() + qtde);
		
		
		// Apresenta o estoque atual e o estoque já reajustado
		JOptionPane.showMessageDialog(null, "Estoque Anterior: " + estoqueAnterior +
				"\nQuantidade Comprada: " + qtde +
				"\nEstoque Atual: " + getEstoqueDisponivel());
		
		// Atribui o resultado da soma ao atributo estoqueDisponivel
		this.setEstoqueDisponivel(this.estoqueDisponivel + qtde);
	}
	
	// Recebe a quantidade vendida por parâmetro
	public void vender(int qtde)
	{
		int estoqueAnterior = getEstoqueDisponivel();
		setEstoqueDisponivel(getEstoqueDisponivel() - qtde);
				// Apresenta o estoque atual e o estoque já reajustado
		JOptionPane.showMessageDialog(null, "Estoque Anterior: " + estoqueAnterior +
				"\nQuantidade Vendida: " + qtde +
"\nEstoque Atual: " + getEstoqueDisponivel());
		
		// Atribui o resultado da subtração do atributo estoqueDisponivel
		this.setEstoqueDisponivel(this.estoqueDisponivel - qtde);
	}
	
	//Método Calcular Preço Venda da CLASSE PRINCIPAL
	public void calcularPrecoVenda()
	{
		/* Calcula 10% sobre o preço de custo e armazena no atributo
		precoVenda (precoCusto*1.11)  */
		
		// Apresenta o estoque atual e o estoque já reajustado
		JOptionPane.showMessageDialog(null, "Preço de Venda Anterior: " + this.getPrecoVenda() +
				    "\nPorcentagem aplicada: 10%" + "\nPreço de Venda Atual:" + (this.getPrecoCusto() + (this.getPrecoCusto() * 0.1)));
		
		// Atribui o resultado da subtração do atributo estoqueDisponivel
		this.setPrecoVenda(this.precoCusto + (this.precoCusto * 0.1));
	}
	

}
