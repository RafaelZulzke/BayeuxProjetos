import javax.swing.JOptionPane;


public class Operador extends Funcionario {

	private String cargo;
	private double Comissao;
	
	public Operador(){
		
		this("","","",true,0,"",0);		
	}
	
	public Operador(String nome, String login, String senha, boolean ativo,
			double salarioBase, String cargo, double valorComissao) {
		super(nome, login, senha, ativo, salarioBase);
		this.cargo = cargo;
		this.Comissao = valorComissao;
	}
	

public String getCargo() {
	return cargo;
}

public void setCargo(String cargo) {
	this.cargo = cargo;
}

public double getComissao() {
	return Comissao;
}

public void setComissao(double comissao) {
	Comissao = comissao;
}
	
public void CadastrarOperador()
{
	setNome(JOptionPane.showInputDialog("Digite o nome do operador."));
	setLogin(JOptionPane.showInputDialog("Digite o login do operador."));
	setSenha(JOptionPane.showInputDialog("Digite a senha do operador."));	
	setComissao(Double.parseDouble(JOptionPane.showInputDialog("Digite a comissao do operador.")));
	setAtivo(false);
	setSalarioBase(Double.parseDouble(JOptionPane.showInputDialog("Digite o Salário Base do operador.")));
}

public void apresentarOperador()
{

	   JOptionPane.showMessageDialog(null, "Nome Operador: " +getNome() 
			    + "\nLogin do Operador: "+ getLogin()+
			    "\nSenha do Operador: "+ getSenha() +
			    "\nComissão do Operador: "+ getComissao()+
			   "\nSalário Base do Operador: "+ getSalarioBase()+ 
			    "\nOperador Ativo ou Não" +isAtivo());
	   
}

public double calcularSalario()
{
	
	double SalarioFinal;
	double comissao;
	comissao = getComissao()*0.99;
	SalarioFinal = this.getSalarioBase()+this.getComissao();
	JOptionPane.showMessageDialog(null, "Nome Operador: " +getNome() +
			"Salário Final: " +SalarioFinal+ "Comissao "+comissao );
	return Comissao;	
	
}




}


