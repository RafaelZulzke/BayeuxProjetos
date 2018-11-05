import javax.swing.JOptionPane;


public class Validador   {
	
	public String login;
	public String senha;
	public boolean ativo;
	
public Validador(){
		
		this("","",true);
		
	}
	
	

	
	public Validador(String login, String senha, boolean ativo) {
	super();
	this.login = login;
	this.senha = senha;
	this.ativo = ativo;
}

		
		public void validarUsuario(Usuario usu)
		{
			if ((usu.getLogin().equals("Zulzke")) && (usu.getSenha().equals("Zulzke")))
				if (usu.isAtivo() == true)
					JOptionPane.showMessageDialog(null, "Usuário " + usu.isAtivo() + " Autorizado!");
				else
					JOptionPane.showMessageDialog(null, "Usuário Bloqueado...");
			else
				JOptionPane.showMessageDialog(null, "Usuário " + usu.isAtivo() + " Deconhecido!");
		}

		
		
	}
	

    

