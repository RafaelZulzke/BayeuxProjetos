import java.text.DecimalFormat;
import javax.swing.JOptionPane;

public class Cliente extends Usuario
{
	private String cpf;
	private double rendaMensal, limiteCredito;
	
	public Cliente(String nome, String login, String senha, boolean ativo,
		String cpf, double rendaMensal, double limiteCredito) {
		super(nome, login, senha, ativo);
		this.cpf = cpf;
		this.rendaMensal = rendaMensal;
		this.limiteCredito = limiteCredito;
	}
	
	public Cliente()
	{
		this("","","",true,"",0,0);
	}

	public String getCpf() {
		return cpf;
	}

	public void setCpf(String cpf) {
		this.cpf = cpf;
	}

	public double getRendaMensal() {
		return rendaMensal;
	}

	public void setRendaMensal(double rendaMensal) {
		this.rendaMensal = rendaMensal;
	}

	public double getLimiteCredito() {
		return limiteCredito;
	}

	public void setLimiteCredito(double limiteCredito) {
		this.limiteCredito = limiteCredito;
	}
	
	DecimalFormat df = new DecimalFormat("###,##0.00");
	
	public void cadastrarCliente()
	{
		setNome(JOptionPane.showInputDialog("Digite o Nome do Cliente"));
		setLogin(JOptionPane.showInputDialog("Digite um Login para o Cliente"));
		setSenha(JOptionPane.showInputDialog("Digite uma Senha para o Cliente"));
		setAtivo(true);
		setCpf(JOptionPane.showInputDialog("Digite o CPF do Cliente"));
		setRendaMensal(Double.parseDouble(JOptionPane.showInputDialog("Digite a Renda Mensal")));
		setLimiteCredito(0);
	}
	
	public void apresentarCliente()
	{
		JOptionPane.showMessageDialog(null, "CPF: " + getCpf() +
							"\nNome do Cliente: " + getNome() +
							"\nLogin do Cliente: " + getLogin() +
							"\nSenha do Cliente: " + getSenha() +
							"\nRenda Mensal: R$ " + df.format(getRendaMensal()) +
							"\nLimite de Crédito: R$ " + df.format(getLimiteCredito()) +
							"\nCliente Ativo ? " + isAtivo());
	}
}
