import javax.swing.JOptionPane;

public class Administrador extends Funcionario
{
	private int codigoLiberacao;

	public Administrador(String nome, String login, String senha,
			boolean ativo, double salarioBase, int codigoLiberacao) {
		super(nome, login, senha, ativo, salarioBase);
		this.codigoLiberacao = codigoLiberacao;
	}
	
	public Administrador()
	{
		this("","","",true,0,0);
	}

	public int getCodigoLiberacao() {
		return codigoLiberacao;
	}

	public void setCodigoLiberacao(int codigoLiberacao) {
		this.codigoLiberacao = codigoLiberacao;
	}
	
	public void autorizarUsuario(int cod, Usuario usu)
	{
		if (cod == 99)
			usu.setAtivo(true);
		else
			JOptionPane.showMessageDialog(null, "Usuário " + usu.isAtivo() + " não tem permissão para esta Operação!");
	}
	
	public void calcularLimiteCredito(int cod, Cliente cli)
	{
		if (cod == 99)
		{
			cli.setLimiteCredito(cli.getRendaMensal() * 0.239);
			cli.setAtivo(true);
		}
		else
			JOptionPane.showMessageDialog(null, "Usuário não tem permissão para esta Operação!");
	}
}

