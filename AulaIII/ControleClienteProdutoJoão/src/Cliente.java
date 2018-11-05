import javax.swing.JOptionPane;


public class Cliente {

	private int id;
	private String nome;
	private String endereco;
	private String email;
	private double rendamensal;
	private double limitecredito;
	
	
	  public Cliente(int id, String nome, String endereco, String email,
			double rendamensal, double limitecredito)
	  {
		super();
		this.id = id;
		this.nome = nome;
		this.endereco = endereco;
		this.email = email;
		this.rendamensal = rendamensal;
		this.limitecredito = limitecredito;
	}
	  
	  

      
	public Cliente() {
		// TODO Auto-generated constructor stub
	}
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	public String getEndereco() {
		return endereco;
	}
	public void setEndereco(String endereco) {
		this.endereco = endereco;
	}
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	public double getRendamensal() {
		return rendamensal;
	}
	public void setRendamensal(double rendamensal) {
		this.rendamensal = rendamensal;
	}
	public double getLimitecredito() {
		return limitecredito;
	}
	public void setLimitecredito(double limitecredito) {
		this.limitecredito = limitecredito;
	}
	
	public void cadastrarCliente()
	{
		setLimitecredito(0);
		setId(getId()+1);
		setNome(JOptionPane.showInputDialog("Digite o Nome do Cliente"));
		setEndereco(JOptionPane.showInputDialog("Digite o Endereço do Cliente"));
		setEmail(JOptionPane.showInputDialog("Digite o e-mail do Cliente"));
		setRendamensal(Double.parseDouble(JOptionPane.showInputDialog("Digite a Renda Mensal")));
	}
	
	public void listarCliente()
	{
		JOptionPane.showMessageDialog(null, "Identificador: " + getId() +
											"\nCliente: " + getNome() +
											"\nEndereço: " + getEndereco() +
											"\nE-mail: " + getEmail() +
											"\nRenda Mensal: R$ " + getRendamensal() +
											"\nLimite de Crédito: R$ " + getLimitecredito());
	}
	
	public double calcularLimiteCredito()
	{
		setLimitecredito(getRendamensal() * 0.4);
		JOptionPane.showMessageDialog(null, "Calculo Efetuado com Sucesso!");
		return getLimitecredito();
	}
	
	public boolean confirmarCompra(double valor)
	{
		double limiteAnterior;
		limiteAnterior = getLimitecredito();
		if (getLimitecredito() > valor)
		{
			setLimitecredito(getLimitecredito() - valor);
			JOptionPane.showMessageDialog(null, "Limite Anterior: R$ " + limiteAnterior +
					"\nValor da Compra: R$ " + valor +
					"\nNovo Limite de Crédito: R$ " + getLimitecredito());
			return true;
		}
		else
			return false;
	}
}


