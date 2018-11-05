
public class Cliente {
	
	private String nome, email;
	private double limitedeCredito;
	
	public Cliente()
	
	{
		this("","",0);
	}

	public Cliente(String nome, String email, double limitedeCredito) {
		super();
		this.nome = nome;
		this.email = email;
		this.limitedeCredito = limitedeCredito;
	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public double getLimitedeCredito() {
		return limitedeCredito;
	}

	public void setLimitedeCredito(double limitedeCredito) {
		this.limitedeCredito = limitedeCredito;
	}
	
	public void cadastrar (String pNome, String pEmail, double pLimitedeCredito)
	{
		this.setNome(pNome);
		this.setEmail(pEmail);
		this.setLimitedeCredito(pLimitedeCredito);
	}

	public boolean verificaLimite (double pLimite)
	{
		boolean retorno=false;
		if (this.getLimitedeCredito() >= pLimite)
		{
			retorno=true;
		}
		return retorno;
	}
}
