import javax.swing.JOptionPane;


public class Cliente {

			
		//Atributos
		private int id;
		private String nome, endr, email;
		private double rendaMensal, limiteCredito;
		
		
		//Construtores
		
		public Cliente(int id, String nome, String endr, String email,
				double rendaMensal, double limiteCredito) {
			super();
			this.id = id;
			this.nome = nome;
			this.endr = endr;
			this.email = email;
			this.rendaMensal = rendaMensal;
			this.limiteCredito = limiteCredito;
		}
		
		
		public Cliente()
		{
			this (0,"","","",0,0);
		}

		// Getters and Setters
		
		public int getId() {
			return id;
		}

		public void setId(int id) {
			this.id = id;
		}

		public String getNome() {
			return nome;
		}

		public void setNome(String nome) {
			this.nome = nome;
		}

		public String getEndr() {
			return endr;
		}

		public void setEndr(String endr) {
			this.endr = endr;
		}

		public String getEmail() {
			return email;
		}

		public void setEmail(String email) {
			this.email = email;
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
		
		
		// metodo para cadastrar clientes
		
		/* private int id;
		private String nome, endr, email;
		private double rendaMensal, limiteCredito; */
		
		public void cadastrarCliente()
		{
			setId(Integer.parseInt(JOptionPane.showInputDialog("Digite a ID do Cliente.")));
			setNome(JOptionPane.showInputDialog("Digite o Nome"));
			setEndr(JOptionPane.showInputDialog("Digite o Endereço"));
			setEmail(JOptionPane.showInputDialog("Digite o Email"));
			setRendaMensal(Double.parseDouble(JOptionPane.showInputDialog("Digite a Renda Mensal")));
			
			
		}
		
		public void CalcularLC()
		{
			setLimiteCredito(getRendaMensal()*0.2399);
		}
		
		public void ListarCliente()
		{
			JOptionPane.showMessageDialog(null, "Id do Funcionario: "+ getId()+
					"\nNome do Cliente: "+getNome()+
					"\nEndereço do Cliente: "+getEndr()+
					"\nEmail do Cliente: "+getEmail()+
					"\nRenda Mensal: "+getRendaMensal()+
					"\nLimite de Credito: "+getLimiteCredito());
		}
		
		
		
		
			
		

	}


