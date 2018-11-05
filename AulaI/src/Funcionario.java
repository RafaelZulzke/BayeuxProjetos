import javax.swing.JOptionPane;


public class Funcionario {
	
	private String nome, cargo;
	private int idade;
	private double salarioBruto, salarioLiquido;
	
	public Funcionario()
	{
		this("","",0,0,0);
	}

	public Funcionario(String nome, String cargo, int idade,
			double salarioBruto, double salarioLiquido) {
		super();
		this.nome = nome;
		this.cargo = cargo;
		this.idade = idade;
		this.salarioBruto = salarioBruto;
		this.salarioLiquido = salarioLiquido;
	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getCargo() {
		return cargo;
	}

	public void setCargo(String cargo) {
		this.cargo = cargo;
	}

	public int getIdade() {
		return idade;
	}

	public void setIdade(int idade) {
		this.idade = idade;
	}

	public double getSalarioBruto() {
		return salarioBruto;
	}

	public void setSalarioBruto(double salarioBruto) {
		this.salarioBruto = salarioBruto;
	}

	public double getSalarioLiquido() {
		return salarioLiquido;
	}

	public void setSalarioLiquido(double salarioLiquido) {
		this.salarioLiquido = salarioLiquido;
	}
	
	
	public void entradaDados()
	{
		setNome(JOptionPane.showInputDialog("Digite o nome do funcionário"));
		setCargo(JOptionPane.showInputDialog("Digite o cargo do funcionário."));
		setIdade(Integer.parseInt(JOptionPane.showInputDialog("Digite a idade do funcionário")));
		setSalarioBruto(Double.parseDouble(JOptionPane.showInputDialog("Digite o salário bruto do funcionário ")));
		setSalarioLiquido(0);
	}
	
	public void mostrarDados()
	{
		JOptionPane.showMessageDialog(null, "Nome do Funcionário: " + getNome() +
				"\nCargo do Funcionário: " + getCargo() + 
				"\nIdade do Funcionário: " + getIdade() +
				"\nSalário Bruto do Funcionário: " + getSalarioBruto() +
				"\nSalário Líquido do Funcionário: " + getSalarioLiquido());
	}
	
	public void calcularValores()
	{
		double gratificacao, desconto;
		
		gratificacao = getSalarioBruto() * 0.0295;
		desconto = getSalarioBruto() * 0.0112;
		
		setSalarioLiquido(getSalarioBruto() + gratificacao - desconto); 
		
		JOptionPane.showMessageDialog(null, "Gratificação: R$ " + gratificacao + 
				"\nDesconto: R$ " + desconto +
				"\n Salário Líquido do Funcionário: R$ " + getSalarioLiquido());
	}
	
}
