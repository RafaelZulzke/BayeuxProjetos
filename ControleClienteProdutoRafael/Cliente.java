import javax.swing.JOptionPane;


public class Cliente {

		private int id;
		private double rendaMensal, limiteCredito;
		private String nome, endereco, email;
		
		public Cliente()
		{
			this(0,0,0,"","","");
			
		}
		
		public Cliente(int id, double rendaMensal, double limiteCredito,
				String nome, String endereco, String email) {
			super();
			this.id = id;
			this.rendaMensal = rendaMensal;
			this.limiteCredito = limiteCredito;
			this.nome = nome;
			this.endereco = endereco;
			this.email = email;
		}

		
		public int getId() {
			return id;
		}

		public void setId(int id) {
			this.id = id;
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

		public String getNome() {
			return nome;
		}

		public void setNome(String nome) {
			this.nome = nome;
		}

		public String getEndereco() {
			return endereco;
		}

		public void setEndereco(String endereco) {
			this.endereco = endereco;
		}

		public String getEmail() {
			return email;
		}

		public void setEmail(String email) {
			this.email = email;
		}

		public void cadastrarCliente()
		{
			// setID
			setNome(JOptionPane.showInputDialog("Digite o nome do cliente."));
			setEndereco(JOptionPane.showInputDialog("Digite o endereço do cliente."));
			setEmail(JOptionPane.showInputDialog("Digite o email do cliente."));
			setRendaMensal(Double.parseDouble(JOptionPane.showInputDialog("Digite a renda mensal do cliente.")));
			setLimiteCredito(0);
		}
		
		public void listarCliente()
		{
			JOptionPane.showMessageDialog(null, "Nome: " + getNome() +
					                            "\nEndereço: " + getEndereco() + 
					                            "\nEmail :" +getEmail() + 
					                            "\nRendaMensal: " + getRendaMensal() + 
					                            "\nLimite de Crédito: " + getLimiteCredito());
		}
		
		public double calcularLimiteCredito()
		{
			setLimiteCredito(getRendaMensal()*0.40);
			JOptionPane.showMessageDialog(null, "Cálculo efetuado com sucesso.");
			return getLimiteCredito(); 
		}
		
		public boolean confirmarCompra(double valor)
		{
			double limiteAnterior;
			limiteAnterior = getLimiteCredito();
			
			if (getLimiteCredito() >= valor)
			{
				setLimiteCredito(getLimiteCredito() - valor);
				JOptionPane.showMessageDialog(null, "Limite Anterior: " + limiteAnterior +
						                            "Valor da Compra: " + valor + 
						                             "Novo Limite de Crédito: " + getLimiteCredito());
				
				return true;
				
			}
			else
			{
		    return false;
			}
			
			
			
		}
	}

