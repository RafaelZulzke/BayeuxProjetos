import java.text.DecimalFormat;
import javax.swing.JOptionPane;

public class Operador extends Funcionario
{
	private String cargo;
	private double valorComissao;
	
	public Operador(String nome, String login, String senha, boolean ativo,
			double salarioBase, String cargo, double valorComissao) {
		super(nome, login, senha, ativo, salarioBase);
		this.cargo = cargo;
		this.valorComissao = valorComissao;
	}
	
	public Operador()
	{
		this("","","",true,0,"",0);
	}

	public String getCargo() {
		return cargo;
	}

	public void setCargo(String cargo) {
		this.cargo = cargo;
	}

	public double getValorComissao() {
		return valorComissao;
	}

	public void setValorComissao(double valorComissao) {
		this.valorComissao = valorComissao;
	}
	
	public void cadastrarOperador()
	{
		setNome(JOptionPane.showInputDialog("Digite o Nome do Operador"));
		setLogin(JOptionPane.showInputDialog("Digite um Login para o Operador"));
		setSenha(JOptionPane.showInputDialog("Digite uma Senha para o Operador"));
		setAtivo(false);
		setCargo(JOptionPane.showInputDialog("Digite o Cargo do Operador"));
		setValorComissao(Double.parseDouble(JOptionPane.showInputDialog("Digite o Valor da Comissão")));
		setSalarioBase(Double.parseDouble(JOptionPane.showInputDialog("Digite o Valor do Salario Base")));
	}
	
	double varValorComissao, varSalarioFinal;
	
	DecimalFormat df = new DecimalFormat("###,##0.00");
	
	public void apresentarOperador()
	{
		JOptionPane.showMessageDialog(null, "Cargo: " + getCargo() +
				"\nNome do Operador: " + getNome() +
				"\nLogin do Operador: " + getLogin() +
				"\nSenha do Operador: " + getSenha() +
				"\nSalário Base: R$ " + df.format(getSalarioBase()) +
				"\nValor da Comissão: R$ " + df.format(varValorComissao) +
				"\nSalário Final: R$ " + df.format(varSalarioFinal) + 
				"\nCliente Ativo ? " + isAtivo());
	}
	
	public double calcularSalario()
	{
		varValorComissao = getValorComissao() * 0.99;
		varSalarioFinal = getSalarioBase() + varValorComissao;
		JOptionPane.showMessageDialog(null, "Nome do Operardor: " + getNome() +
							"\nValor da Comissão: R$ " + varValorComissao);
		return varValorComissao;
	}
}


