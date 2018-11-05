import javax.swing.JOptionPane;


public class Produto {
	
	private int id, estoqueDisponivel;
	private double precoUnitario;
	private String descricao;
	
	public Produto()
	{
		this(0,0,0,"");
	}

	public Produto(int id, int estoqueDisponivel, double precoUnitario,
			String descricao) {
		super();
		this.id = id;
		this.estoqueDisponivel = estoqueDisponivel;
		this.precoUnitario = precoUnitario;
		this.descricao = descricao;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public int getEstoqueDisponivel() {
		return estoqueDisponivel;
	}

	public void setEstoqueDisponivel(int estoqueDisponivel) {
		this.estoqueDisponivel = estoqueDisponivel;
	}

	public double getPrecoUnitario() {
		return precoUnitario;
	}

	public void setPrecoUnitario(double precoUnitario) {
		this.precoUnitario = precoUnitario;
	}

	public String getDescricao() {
		return descricao;
	}

	public void setDescricao(String descricao) {
		this.descricao = descricao;
	}

	public void cadastrarProduto()
	{
		setId(getId()+1);
		setDescricao(JOptionPane.showInputDialog("Descreva o Produto."));
		setEstoqueDisponivel(Integer.parseInt(JOptionPane.showInputDialog("Digite o número do Estoque Disponível do produto.")));
		setPrecoUnitario(Double.parseDouble(JOptionPane.showInputDialog("Digite o preçp unitário do produto.")));
		}
	
	public void listarProduto()
	{
		JOptionPane.showMessageDialog(null, "Id do Produto : "+ getId()+
				                      "\nDescrição do Produto : "+ getDescricao() +
				                      "\nEstoque Disponível do Produto : "+ getEstoqueDisponivel()+
				                      "\nPreço Unitário do Produto : "+ getPrecoUnitario());
		}
	
	 public boolean confirmarPedido (int qtde)
	{
		 if (getEstoqueDisponivel() > qtde)
		 {
			 JOptionPane.showMessageDialog(null, "Estoque Disponível.");
			 return true;
		 }
		 
		 else 
			 
			 return false;	
	}
	
	
	 public double pedido(int qtde)
	 
	{
	double valorCompra;
	
	valorCompra = qtde * getPrecoUnitario();
	JOptionPane.showMessageDialog(null, "Valor da Compra: R$ " + valorCompra);
	return valorCompra;	
	}
	 
	
	 public void vender (int qtde)
	  {
	  setEstoqueDisponivel(getEstoqueDisponivel() - qtde);
	  JOptionPane.showMessageDialog(null, "Venda Realizada com Sucesso.");
	  }
	 
	
}
