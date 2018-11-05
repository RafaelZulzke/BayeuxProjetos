import javax.swing.JOptionPane;


public class Funcionario {


	private String nome, cargo;
	private int idade;
	private double SalBruto, SalLiq, Vinss, Vir;
	
	public Funcionario()
	{
	this("","",0,0,0,0,0)	;
	}
	
	public Funcionario(String nome, String cargo, int idade, double salBruto,
			double salLiq, double vinss, double vir) {
		super();
		this.nome = nome;
		this.cargo = cargo;
		this.idade = idade;
		SalBruto = salBruto;
		SalLiq = salLiq;
		Vinss = vinss;
		Vir = vir;
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
		return SalBruto;
	}

	public void setSalBruto(double salBruto) {
		SalBruto = salBruto;
	}

	public double getSalLiq() {
		return SalLiq;
	}

	public void setSalLiq(double salLiq) {
		SalLiq = salLiq;
	}

	public double getVinss() {
		return Vinss;
	}

	public void setVinss(double vinss) {
		Vinss = vinss;
	}

	public double getVir() {
		return Vir;
	}

	public void setVir(double vir) {
		Vir = vir;
	}

	public void entrarDados()
	{
		setNome(JOptionPane.showInputDialog("Digite o nome do funcion�rio"));
		setCargo(JOptionPane.showInputDialog("Digite o cargo do funcion�rio"));
		setIdade(Integer.parseInt(JOptionPane.showInputDialog("Digite a idade do funcion�rio")));
		setSalBruto(Double.parseDouble(JOptionPane.showInputDialog("Digite o sal�rio bruto do funcion�rio")));
		setSalLiq(0);
	}
	
	public void mostrarDados()
	{
		JOptionPane.showMessageDialog(null, "Funcion�rio: " +getNome()+
				                            "\nCargo: " + getCargo() +
				                            "\nIdade: " + getIdade() +                           
				                            "\nSal�rio Bruto: " + getSalBruto() +
				                            "\nINSS: " + getVinss() +
				                            "\nIR: " + getVir() +
				                            "\nSal�rio L�quido: R$ " + getSalLiq());
	}
	
	public void calcularValores()
	{
		double gratificacao;
		gratificacao = getSalBruto()* 0.0493 ;
		
		if (getSalBruto()<= 2500)
		{
			setVinss(getSalBruto() *0.55);
			setVir(getSalBruto() * 0.75);
		}
		else
			if (getSalBruto() <= 3750.50)
			{
				setVinss(getSalBruto() * 0.073);
				setVir(getSalBruto() * 0.0915);
			}
			else 
				if (getSalBruto() <= 5213.93)
				{
					setVinss(getSalBruto() * 0.0925);
					setVir(getSalBruto() * 0.11);
				}
				else
				{
					setVinss(518.23);
					setVir(getSalBruto() * 0.275);
		}
		
		setSalLiq(getSalBruto() + gratificacao - Vinss - Vir);
		JOptionPane.showMessageDialog(null, "Gratifica��o: R$ " + gratificacao+
				                            "\nINSS: R$ " + getVinss() + 
				                             "\nIR: R$ " +getVir() +
				                              "\nSal�rio L�quido: R$ " + getSalLiq());
		
	}
	
	
	
	
	
}
