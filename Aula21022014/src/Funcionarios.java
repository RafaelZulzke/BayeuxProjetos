import javax.swing.JOptionPane;


public class Funcionarios {

		//Atributos
		private String  nome, cargo; 
		public int idade;
		public double slbruto, slliquido;
		
		//Construtores 
		
		public Funcionarios()
		{
              this ("","",0,0,0);
		}

		public Funcionarios(String nome, String cargo, int idade, double slbruto,double slliquido) 
		{
			super();
			this.nome = nome;
			this.cargo = cargo;
			this.idade = idade;
			this.slbruto = slbruto;
			this.slliquido = slliquido;
			
		}
		
		// getters and setters
		
		public String getNome() {
			return nome;
		}

		public void setNome(String nome) {
			this.nome = nome;
		}
		
		public String getCargo() {
			return nome;
		}

		public void setCargo(String nome) {
			this.nome = nome;
		}

		
		public int getIdade() {
			return idade;
		}

		public void setIdade(int idade) {
			this.idade = idade;
		}

		public double getSlbruto() {
			return slbruto;
		}

		public void setSlbruto(double slbruto) {
			this.slbruto = slbruto;
		}

		public double getSlliquido() {
			return slliquido;
		}

		public void setSlliquido(double slliquido)
		{
			this.slliquido = slliquido;
		}
		
		
		//metodo para entrada de dados
		
		public void EntradaDados()
		{ 
			setNome(JOptionPane.showInputDialog("Digite o nome do funcionário."));
			setCargo(JOptionPane.showInputDialog("Digite o cargo do funcionário."));
			setIdade(Integer.parseInt(JOptionPane.showInputDialog("Digite a Idade do Funcionario")));
			setSlbruto(Double.parseDouble(JOptionPane.showInputDialog("Digite o Salario Bruto do Funcionario")));
		}
		
		//metodo para exibição de dados
		public void MostrarDados()
		{
			JOptionPane.showMessageDialog(null,"Nome :" +getNome()+
												"\nCargo :" +getCargo()+
												"\nIdade:" +getIdade()+
												"\nSalario Bruto :" +getSlbruto()+
												"\nSalario Liquido :" +getSlliquido());
			
			
		}
		
		//metodo para calcular salario liquido
		public void CalcularSl()
		{
			double grtf, desconto;
			
			
			grtf=(getSlbruto()*0.0295);//Ou 0.0295;
			desconto=(getSlbruto()*0.0112);//Ou 0.0112
			
			
	      setSlliquido(getSlbruto()+grtf-desconto);
	    		  
	      JOptionPane.showMessageDialog(null, "Gratificação: R$ " + grtf +
					"\nDesconto: R$ " + desconto + "\nSalário Liquido: R$ " + getSlliquido());
		}		
}
