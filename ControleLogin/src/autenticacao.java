
public class autenticacao {

	public String Validar (){
	 String s = "Bem Vindo Visitante";
	 return s;
	}
	
	public String Validar (int senha ){
		if (senha==123){
		String A = "bem vindo Usu�rio teste!";
			return A;	
		}
		else{
			 String A = "Usu�rio tempor�rio inv�lido !";
		return A;
		}
	}
	
public String Validar (String senha ){
	if (senha=="abc"){
		String A = "bem vindo Usu�rio teste!";
			return A;	
		}
		else{
			 String A = "Usu�rio tempor�rio inv�lido !";
		return A;
		}
		
	}

public String Validar (String login, String senha ){
	if (login=="adm"){
		String A = "Bem vindo Adiministrador!";
			return A;	
		}
	if (senha=="master"){
		String A = "Bem vindo Adiministrador!";
			return A;	
		}
		else{
			 String A = "Adiministrador inv�lido !";
		return A;
		}
	
}
	
}
