import javax.swing.JOptionPane;




public class Automovel {

	//Atributos
	private String nomeAutomovel;
	private double precoFabrica, porcentagemRevendedor, valorImposto, precoFinal; 
	
	//Construtores
	
	public Automovel()
	{
		this ("",0,0,0,0);
	}

   
	
	public Automovel(String nomeAutomovel, double precoFabrica,
			double porcentagemRevendedor, double valorImposto, double precoFinal) {
		super();
		this.nomeAutomovel = nomeAutomovel;
		this.precoFabrica = precoFabrica;
		this.porcentagemRevendedor = porcentagemRevendedor;
		this.valorImposto = valorImposto;
		this.precoFinal = precoFinal;
	}



	//getters and setters

	public String getNomeAutomovel() {
		return nomeAutomovel;
	}

	public void setNomeAutomovel(String nomeAutomovel) {
		this.nomeAutomovel = nomeAutomovel;
	}

	public double getPrecoFabrica() {
		return precoFabrica;
	}

	public void setPrecoFabrica(double precoFabrica) {
		this.precoFabrica = precoFabrica;
	}

	public double getPorcentagemRevendedor() {
		return porcentagemRevendedor;
	}

	public void setPorcentagemRevendedor(double porcentagemRevendedor) {
		this.porcentagemRevendedor = porcentagemRevendedor;
	}

	public double getValorImposto() {
		return valorImposto;
	}

	public void setValorImposto(double valorImposto) {
		this.valorImposto = valorImposto;
	}

	public double getPrecoFinal() {
		return precoFinal;
	}

	public void setPrecoFinal(double precoFinal) {
		this.precoFinal = precoFinal;
	}

	

	
	
	
    //metodo para entrada de dados nomeAutomovel e precoFabrica
	
	public void EntradaDados()
	{
		setNomeAutomovel(JOptionPane.showInputDialog("Digite o nome do automóvel."));
		setPrecoFabrica(Double.parseDouble(JOptionPane.showInputDialog("Digite o preço de fábrica do automóvel.")));
	}
	
	
	
	//metodo para calcular valores
	
	public void CalcularValores()
	{
		
		// setters para porcentagemRevendedor, valorImposto, precoFinal;
		
		
		setPorcentagemRevendedor(getPrecoFabrica()*0.23); 
		setValorImposto(getPrecoFabrica()*0.115); 
		setPrecoFinal(getPrecoFabrica() + getPorcentagemRevendedor() + getValorImposto());
		
		JOptionPane.showMessageDialog(null, "Porcentagem do Revendedor: R$ " +getPorcentagemRevendedor() +
				"\nValor do Imposto: R$ " + getValorImposto() + "\nPreço Final: R$" + getPrecoFinal());     	
	}
	
	//metodo para exibição de dados
	
		public void MostrarDados()
		{
			
			// mostrar dados para porcentagemRevendedor, valorImposto, precoFinal;
		    JOptionPane.showMessageDialog(null,"Nome do Automóvel: " +getNomeAutomovel()+
			                                "\nPreço de Fábrica do Automóvel: "+getPrecoFabrica() +
			                                "\nPorcentagem do Revendedor: "+getPorcentagemRevendedor() +
			                                "\nValor do Imposto: " +getValorImposto()+
			                                "\nPreço Final: " +getPrecoFinal());
			                                 
			}
		
	
	}


