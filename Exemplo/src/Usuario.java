import javax.swing.JOptionPane;


public class Usuario {
	
	//Atributos
	private String nome;
	private String email;
	private String login, senha;
	
	//Construtores 
	public Usuario(){
		this ("","","","");
	}
	
	public Usuario(String nome, String email, String login, String senha) {
		super();
		this.nome = nome;
		this.email = email;
		this.login = login;
		this.senha = senha;
	}
	
    //Getters e Setters
	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public String getLogin() {
		return login;
	}

	public void setLogin(String login) {
		this.login = login;
	}

	public String getSenha() {
		return senha;
	}

		public void setSenha(String senha) {
		this.senha = senha;
	}
	 
	/*public void provarExistencia()
	{
		
	setNome(JOptionPane.showInputDialog("Digite o nome"));
	    JOptionPane.showMessageDialog(null, getNome());
	    
	    //System.out.println("Atributos: Nome/Email/Login/Senha");
	}*/
		
		public void cadastrarExemplo()
		{
			setNome(JOptionPane.showInputDialog("Digite o seu nome."));
			setEmail(JOptionPane.showInputDialog("Digite o seu email."));
			setLogin(JOptionPane.showInputDialog("Digite o seu Login"));
			setSenha(JOptionPane.showInputDialog("Digite a sua senha."));
		}
	
		public void mostrarExemplo()
		{
			JOptionPane.showMessageDialog(null, "Nome: " + getNome()+
			"\nEmail: " + getEmail()+
			"\nLogin: " + getLogin()+
			"\nSenha: " + getSenha());
		}
	 
	
	

}