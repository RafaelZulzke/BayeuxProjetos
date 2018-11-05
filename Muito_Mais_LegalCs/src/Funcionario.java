public abstract class Funcionario extends Usuario
{
	private double salarioBase;

	public Funcionario(String nome, String login, String senha, boolean ativo,
			double salarioBase) {
		super(nome, login, senha, ativo);
		this.salarioBase = salarioBase;
	}
	
	public Funcionario()
	{
		this("","","",true,0);
	}

	public double getSalarioBase() {
		return salarioBase;
	}

	public void setSalarioBase(double salarioBase) {
		this.salarioBase = salarioBase;
	}
}



