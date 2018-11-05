import javax.swing.JOptionPane;


public class Produto {
	
	private String descricao, genero;
	private int estoqueDisponivel;
	private double precoCusto,precoVenda;
	
	public Produto()
	
	{
		this("","",0,0,0);
	}
	public Produto(String descricao, String genero, int estoqueDisponivel,
			double precoCusto,double precoVenda) {
		super();
		this.descricao = descricao;
		this.genero = genero;
		this.estoqueDisponivel = estoqueDisponivel;
		this.precoCusto = precoCusto;
		this.precoVenda = precoVenda;
		
	}

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

	public void comprar(int qtde)
	{
		setEstoqueDisponivel(getEstoqueDisponivel() + qtde);
		JOptionPane.showMessageDialog(null, "Compra realizada com sucesso");
		
	}
	
	public void vender(int qtde)
	{
		setEstoqueDisponivel(getEstoqueDisponivel() - qtde);
		JOptionPane.showMessageDialog(null, "Venda realizada com sucesso");
	}
	
	public void calcularPrecoVenda()
	{
		JOptionPane.showMessageDialog(null, "Preço Venda Anterior" + this.getPrecoVenda()+
				                             "\nPorcentagem Aplicada: 10 %" + "\nPreço de Venda Atual:" + (this.getPrecoCusto()* 1.1 ));
	
		
	}
}
