import javax.swing.JOptionPane;


public class Produto {

	private int id;
	private String descricao;
	private int estoquedisponivel;
	private double precounitario;
	
	public Produto(int id, String descricao, int estoquedisponivel,
			double precounitario) {
		super();
		this.id = id;
		this.descricao = descricao;
		this.estoquedisponivel = estoquedisponivel;
		this.precounitario = precounitario;
	}
	
	public Produto()
	{
		this(0,"",0,0);
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getDescricao() {
		return descricao;
	}

	public void setDescricao(String descricao) {
		this.descricao = descricao;
	}

	public int getEstoquedisponivel() {
		return estoquedisponivel;
	}

	public void setEstoquedisponivel(int estoquedisponivel) {
		this.estoquedisponivel = estoquedisponivel;
	}

	public double getPrecounitario() {
		return precounitario;
	}

	public void setPrecounitario(double precounitario) {
		this.precounitario = precounitario;
	}
	public void cadastrarProduto()
	{
		setId(getId() + 1);
		setDescricao(JOptionPane.showInputDialog("Insira a descricao do produto"));
		setEstoquedisponivel(Integer.parseInt(JOptionPane.showInputDialog("Insira o estoque desse produto")));
		setPrecounitario(Double.parseDouble(JOptionPane.showInputDialog("Insira o preco unitario do produto")));
		
	}
	public void listarproduto()
	{
		JOptionPane.showMessageDialog(null, "Informação dos Produto:"+
										"id:"+getId()+
										"Descrição:"+getDescricao()+
										"estoque disponivel"+getEstoquedisponivel()+
										"Preco Unitario:"+getPrecounitario());
	}
	public boolean confirmarPedido(int qtde)
	{
		if (getEstoquedisponivel() > qtde)
		{
			JOptionPane.showMessageDialog(null, "Estoque Disponível!");
			return true;
		}
		else
			return false;
	}
	
	public double pedido(int qtde)
	{
		double valorCompra;
		valorCompra = qtde * getPrecounitario();
		JOptionPane.showMessageDialog(null, "Valor da Compra: R$ " + valorCompra);
		return valorCompra;
	}
	
	public void vender(int qtde)
	{
		setEstoquedisponivel(getEstoquedisponivel() - qtde);
		JOptionPane.showMessageDialog(null, "Venda Realizada com Sucesso!");
	}
}


	
	

