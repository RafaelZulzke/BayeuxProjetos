
public class Autenticacao {

  public String validar()
	{
		String mensagem = "Bem Vindo Visitante!"; 
		
		return mensagem;

	}
	
   public String validar (int senha)
	{
	/* Verifica se o parâmetro informado é igual a 123, se for, retorna
	a mensagem “Bem vindo usuário teste!” senão “Usuário temporário inválido!” */
		if (senha == 123)
				
			      return "Bem Vindo Usuário Teste!";
	             //JOptionPane.showMessageDialog(null,"Bem Vindo Usuario Teste");		
				
		else 
		
			return "Usuáriuo Temporário inválido!!!";
		//JOptionPane.showMessageDialog(null,"Usuario Invalido");	
		
	}
		
	
	
	public String validar (String senha)
	{
		if(senha.equals("abc"))
		
			return "Bem Vindo Usuário.";
			//JOptionPane.showMessageDialog(null,"Bem Vindo Usuario!");
		

		else
		
			return "Usuário Inválido!!!";
		//JOptionPane.showMessageDialog(null,"Usuario Invalido");
		
	}
	
	/*public String validar (String login,String senha)
	{
		if(login == "adm")
		{
		 if (senha == "master")
		 {
			 JOptionPane.showMessageDialog(null,"Bem Vindo Administrador");
			 
			 if(senha != "master")
			 {
			 
				 JOptionPane.showMessageDialog(null,"Senha Invalida");
			 }
		 }
		 if(login !="master")
		 {
		 JOptionPane.showMessageDialog(null,"Administrador Invalido");
		}*/
	
	public String validar(String login, String senha)
	{
		if ((login.equals("adm")) && (senha.equals("master")))
			return "Bem Vindo Administrador";
		else
			return "Administrador Inválido";
	}

	}

		
		
		


