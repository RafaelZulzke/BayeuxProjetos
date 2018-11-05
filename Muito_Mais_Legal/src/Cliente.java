import javax.swing.JOptionPane;


public class Cliente extends Usuario {
	
	private String cpf;
	private double RendaMensal;
	private double limiteCredito;
	
	public Cliente(){
		
		this("",0,0);
		
	}

	public Cliente(String cpf, double rendaMensal, double limiteCredito) {
		super();
		this.cpf = cpf;
		RendaMensal = rendaMensal;
		this.limiteCredito = limiteCredito;
		
	}

	public Cliente(String nome, String login, String senha, boolean ativo) {
		super(nome, login, senha, ativo);
	}

	public String getCpf() {
		return cpf;
	}

	public void setCpf(String cpf) {
		this.cpf = cpf;
	}

	public double getRendaMensal() {
		return RendaMensal;
	}

	public void setRendaMensal(double rendaMensal) {
		RendaMensal = rendaMensal;
	}

	public double getLimiteCredito() {
		return limiteCredito;
	}

	public void setLimiteCredito(double limiteCredito) {
		this.limiteCredito = limiteCredito;
	}

	public void cadastrarCliente()
    {
 	   setNome(JOptionPane.showInputDialog("Digite o nome do cliente."));
 	   setLogin(JOptionPane.showInputDialog("Digite o login do cliente."));
 	   setSenha(JOptionPane.showInputDialog("Digite a senha do cliente."));
 	  setCpf(JOptionPane.showInputDialog("Digite o CPF do cliente."));
 	   setRendaMensal(Double.parseDouble(JOptionPane.showInputDialog("Digite o valor da renda mensal do cliente.")));
 	   setLimiteCredito(0);
 	   setAtivo(false);
 	   
    }
	
	public void apresentarCliente()
	{

 	   JOptionPane.showMessageDialog(null, "Nome Cliente: " +getNome() 
 			    + "\nLogin do Cliente: "+ getLogin()+
 			    "\nSenha do Cliente: "+ getSenha() +
 			    "\nCPF do Cliente: "+ getCpf()+
 			    "\nRenda Mensal do Cliente: "+ getRendaMensal() +
 			    "\nLimite de Crédito do Cliente: "+ getLimiteCredito()+ 
 			    "\nCliente Ativo ou Não" +isAtivo());
		
	}
	
	
	
}
