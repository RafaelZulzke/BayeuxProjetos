import javax.swing.JOptionPane;

public class Funcionarios
{
	private String nome, cargo;
	private int idade;
	private double salBruto, salLiquido, valorINSS, valorIR;	
	
	public Funcionarios()
	{
		this("","",0,0,0,0,0);
	}

	public Funcionarios(String nome, String cargo, int idade, double salBruto,
			double salLiquido, double valorINSS, double valorIR) {
		super();
		this.nome = nome;
		this.cargo = cargo;
		this.idade = idade;
		this.salBruto = salBruto;
		this.salLiquido = salLiquido;
		this.valorINSS = valorINSS;
		this.valorIR = valorIR;
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

	public double getSalBruto() {
		return salBruto;
	}

	public void setSalBruto(double salBruto) {
		this.salBruto = salBruto;
	}

	public double getSalLiquido() {
		return salLiquido;
	}

	public void setSalLiquido(double salLiquido) {
		this.salLiquido = salLiquido;
	}

	public double getValorINSS() {
		return valorINSS;
	}

	public void setValorINSS(double valorINSS) {
		this.valorINSS = valorINSS;
	}

	public double getValorIR() {
		return valorIR;
	}

	public void setValorIR(double valorIR) {
		this.valorIR = valorIR;
	}

	public void entrarDados()
	{
		setNome(JOptionPane.showInputDialog("Digite o Nome do Funcionário"));
		setCargo(JOptionPane.showInputDialog("Digite o Cargo do Funcionário"));
		setIdade(Integer.parseInt(JOptionPane.showInputDialog("Digite a Idade do Funcionário")));
		setSalBruto(Double.parseDouble(JOptionPane.showInputDialog("Digite o Salário Bruto do Funcionário")));
		setSalLiquido(0);
	}
	
	public void mostrarDados()
	{
		JOptionPane.showMessageDialog(null, "Funcionário: " + getNome() +
									"\nCargo: " + getCargo() +
									"\nIdade: " + getIdade() +
									"\nSalário Bruto: R$ " + getSalBruto() +
									"\nINSS: R$ " + getValorINSS() +
									"\nIR: R$ " + getValorIR() +
									"\nSalário Liquido: R$ " + getSalLiquido());
	}
	
	public void calcularValores()
	{
		double gratificacao;
		gratificacao = getSalBruto() * 0.0295;
		
		if (getSalBruto() <= 2500)
		{
			setValorINSS(getSalBruto() * 0.055);
			setValorIR(getSalBruto() * 0.075);
		}
		else
			if (getSalBruto() <= 3750.50)
			{
				setValorINSS(getSalBruto() * 0.073);
				setValorIR(getSalBruto() * 0.0915);
			}
			else
				if (getSalBruto() <= 5213.93)
				{
					setValorINSS(getSalBruto() * 0.0925);
					setValorIR(getSalBruto() * 0.11);
				}
				else
					{
						setValorINSS(518.23);
						setValorIR(getSalBruto() * 0.275);
					}		
		
		setSalLiquido(getSalBruto() + gratificacao - valorINSS - valorIR);
		
		JOptionPane.showMessageDialog(null, "Gratificação: R$ " + gratificacao +
				"\nINSS: R$ " + getValorINSS() + "\nIR: R$ " + getValorIR() +
				"\nSalário Liquido: R$ " + getSalLiquido());
	}
}
