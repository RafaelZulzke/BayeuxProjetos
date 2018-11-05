import javax.swing.JOptionPane;


public class Produto {
	
	private int Id ;
	private String Descricao;
	private int ED;
	private double PU;
	public Produto(int id, String descricao, int eD, double pU) {
		super();
		Id = id;
		Descricao = descricao;
		ED = eD;
		PU = pU;
	}
	
	public Produto()
	{
		this(0,"",0,0);
	}

	public int getId() {
		return Id;
	}

	public void setId(int id) {
		Id = id;
	}

	public String getDescricao() {
		return Descricao;
	}

	public void setDescricao(String descricao) {
		Descricao = descricao;
	}

	public int getED() {
		return ED;
	}

	public void setED(int eD) {
		ED = eD;
	}

	public double getPU() {
		return PU;
	}

	public void setPU(double pU) {
		PU = pU;
	}
	
	
	public void cadastrarProduto()
	{
		setId(getId() + 1);
		setDescricao(JOptionPane.showInputDialog("Insira a descricao do produto"));
		setED(Integer.parseInt(JOptionPane.showInputDialog("Insira o estoque desse produto")));
		setPU(Double.parseDouble(JOptionPane.showInputDialog("Insira o preço unitario do produto")));
		
	}
	public void ListarProduto()
	{
		JOptionPane.showMessageDialog(null, "Informação dos Produto:"+
										"\n" +
										"\nID:"+getId()+
										"\nDescrição:"+getDescricao()+
										"\nEstoque Disponivel:"+getED()+
										"\nPreco Unitario:"+getPU());
	}
		
	public boolean CorfirmarPedido(int Quantia)
	{
		if (getED() > Quantia)
			
		{
		    JOptionPane.showMessageDialog(null, "Estoque Disponível!");
			return true;
		}
		
		else
		{
			return false;
		}
		
	}
	
	public double pedido(int Quantia)
	{
		double ValorCompra;
		ValorCompra = Quantia * getPU();
		JOptionPane.showMessageDialog(null, "Valor da Compra: R$ " + ValorCompra);
		return ValorCompra;
		
	}
	
	public void Vender(int Quantia)
	{
	 setED(getED()-Quantia);
	 JOptionPane.showMessageDialog(null,"Venda Realizada com Sucesso");
	 
	}

	}



