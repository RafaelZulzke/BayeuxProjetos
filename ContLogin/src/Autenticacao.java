
public class Autenticacao {

  public String validar()
	{
		String mensagem = "Bem Vindo Visitante!"; 
		
		return mensagem;

	}
	
   public String validar (int senha)
	{
	/* Verifica se o par�metro informado � igual a 123, se for, retorna
	a mensagem �Bem vindo usu�rio teste!� sen�o �Usu�rio tempor�rio inv�lido!� */
		if (senha == 123)
				
			      return "Bem Vindo Usu�rio Teste!";
	             //JOptionPane.showMessageDialog(null,"Bem Vindo Usuario Teste");		
				
		else 
		
			return "Usu�riuo Tempor�rio inv�lido!!!";
		//JOptionPane.showMessageDialog(null,"Usuario Invalido");	
		
	}
		
	
	
	public String validar (String senha)
	{
		if(senha.equals("abc"))
		
			return "Bem Vindo Usu�rio.";
			//JOptionPane.showMessageDialog(null,"Bem Vindo Usuario!");
		

		else
		
			return "Usu�rio Inv�lido!!!";
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
			return "Administrador Inv�lido";
	}

	}

		
		
		


