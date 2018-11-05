import javax.swing.JOptionPane;


public class Cliente {
	
	private int id;
	private String Nome,Endereco,Email;
	
	private double LC,RM;
	
	public Cliente(int id, String nome, String endereco, String email,
			double rM, double lC) {
		super();
		this.id = id;
		Nome = nome;
		Endereco = endereco;
		Email = email;
		RM = rM;
		LC = lC;
	}
	
	public Cliente()
	{
	this(0,"","","",0,0);
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getNome() {
		return Nome;
	}

	public void setNome(String nome) {
		Nome = nome;
	}

	public String getEndereco() {
		return Endereco;
	}

	public void setEndereco(String endereco) {
		Endereco = endereco;
	}

	public String getEmail() {
		return Email;
	}

	public void setEmail(String email) {
		Email = email;
	}

	public double getRM() {
		return RM;
	}

	public void setRM(double rM) {
		RM = rM;
	}

	public double getLC() {
		return LC;
	}

	public void setLC(double lC) {
		LC = lC;
	}
	
	public void CadastrarCliente()
	{
		setLC(0);
		setId(getId()+1);
		setNome(JOptionPane.showInputDialog("Insira seu Nome"));
		setEndereco(JOptionPane.showInputDialog("Insira seu Endereço"));
		setEmail(JOptionPane.showInputDialog("Digite seu Email agora"));
		setRM(Double.parseDouble(JOptionPane.showInputDialog("Qual sua Renda Mensal")));
	}
	
	public void ListarDados()
	{
		JOptionPane.showMessageDialog(null,"ID:" + getId()+
				                           "Nome:" + getNome()+
				                           "\nEndereço:" + getEndereco()+
				                           "\nEmail:"+getEmail()+
				                           "\nRenda Mensal:"+getRM()+
				                           "\nLimite de Crédito:" + getLC());
	}
	
	public double CalcularLimiteCredito()
	
	{
		setLC(getRM()*0.4);
	    JOptionPane.showMessageDialog(null,"Calculo Efetuado");
	    return getLC();
   }
	
	public boolean ConfirmarCompra(double valor)	
	{
		double LA ;
		LA = getLC();
		
		if (getLC() > valor)
			
		{
			setLC(getLC()-valor);
			JOptionPane.showMessageDialog(null,"\nLimite Anterior  R$:" + LA +
					                           "\nValor da Compra  R$:" +valor+
					                           "\nNovo Limite de Credito  R$:"+getLC());
			
		return true;
		}
		else 
		{
			return false;
		}
		}
		
		
	}


