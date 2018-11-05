
public abstract class Funcionario extends Usuario{

	private double salariobase;
	
	public Funcionario()
	{
		this("","","",true,0);
	}

	public Funcionario(String nome, String login, String senha, boolean ativo,
			double salarioBase) {
		super(nome, login, senha, ativo);
this.salariobase = salarioBase;
	}


	public double getSalarioBase() {
		return salariobase;
	}

	public void setSalarioBase(double salarioBase) {
		this.salariobase = salarioBase;
	}
	
}
