import javax.swing.JOptionPane;


public class Vendedor {
		
		private String nome;
		private double salarioBase, comissao, vv, salarioTotal;

	//construtores
		public Vendedor()
		{
			this("",0,0,0,0);
		}		
		
				
		public Vendedor(String nome, double salarioBase, double comissao,
			double vv, double salarioTotal) {
		super();
		this.nome = nome;
		this.salarioBase = salarioBase;
		this.comissao = comissao;
		this.vv = vv;
		this.salarioTotal = salarioTotal;
	}

		//getters and setters
		public String getNome() {
			return nome;
		}


		public void setNome(String nome) {
			this.nome = nome;
		}


		public double getSalarioBase() {
			return salarioBase;
		}


		public void setSalarioBase(double salarioBase) {
			this.salarioBase = salarioBase;
		}


		public double getComissao() {
			return comissao;
		}


		public void setComissao(double comissao) {
			this.comissao = comissao;
		}


		public double getVv() {
			return vv;
		}


		public void setVv(double vv) {
			this.vv = vv;
		}


		public double getSalarioTotal() {
			return salarioTotal;
		}


		public void setSalarioTotal(double salarioTotal) {
			this.salarioTotal = salarioTotal;
		}

		//metodo Entrada de dados
				public void EntradaDados()
				{
					setNome(JOptionPane.showInputDialog("Digite o nome do funcion�rio."));
					setSalarioBase(Double.parseDouble(JOptionPane.showInputDialog("Digite o sal�rio base do funcion�rio.")));
				}
		
		
		//metodo calculo comissao
		public double CalculoComissao(double valorVendido) 
	{
			//O calculo da Comiss�o � 23,5% do valor que foi vendido pelo Vendedor, armazenado.
 
			setVv(valorVendido);
			setComissao(23.5 * getVv()/100);
			setSalarioTotal(getSalarioBase() + getComissao());
			return getComissao();
	}


		public void MostrarInfos()
		{
			//Informa��es para mostrar: Nome, Sal�rio Base, Valor Vendido, Comiss�o, Sal�rio Total.
			JOptionPane.showMessageDialog(null, "Nome do Funcion�rio: " + getNome() +
					                             "\nSal�rio Base do Funcion�rio: R$" + getSalarioBase()+
					                             "\nValor Vendido pelo Vendedor: R$" + getVv()+
					                             "\nComiss�o do Vendedor: R$" + getComissao()+
					                             "\nSal�rio Total do Vendedor: R$"+ getSalarioTotal());
			                                     
			
		}
}
		
		
		
