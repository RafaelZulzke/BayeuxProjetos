
public abstract class Usuario {

	private String nome;
	private String login;
	private String senha;
	private boolean ativo;
	
	public Usuario()
	{
		this("","","",false);
	}

	public Usuario(String nome, String login, String senha, boolean ativo) {
		super();
		this.nome = nome;
		this.login = login;
		this.senha = senha;
		this.ativo = ativo;
	}

	
	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
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

	public boolean isAtivo() {
		return ativo;
	}

	public void setAtivo(boolean ativo) {
		this.ativo = ativo;
	}
	
	
}
