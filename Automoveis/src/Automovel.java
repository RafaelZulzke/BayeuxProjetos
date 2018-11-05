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
		setNomeAutomovel(JOptionPane.showInputDialog("Digite o nome do autom�vel."));
		setPrecoFabrica(Double.parseDouble(JOptionPane.showInputDialog("Digite o pre�o de f�brica do autom�vel.")));
	}
	
	
	
	//metodo para calcular valores
	
	public void CalcularValores()
	{
		
		// setters para porcentagemRevendedor, valorImposto, precoFinal;
		
		
		setPorcentagemRevendedor(getPrecoFabrica()*0.23); 
		setValorImposto(getPrecoFabrica()*0.115); 
		setPrecoFinal(getPrecoFabrica() + getPorcentagemRevendedor() + getValorImposto());
		
		JOptionPane.showMessageDialog(null, "Porcentagem do Revendedor: R$ " +getPorcentagemRevendedor() +
				"\nValor do Imposto: R$ " + getValorImposto() + "\nPre�o Final: R$" + getPrecoFinal());     	
	}
	
	//metodo para exibi��o de dados
	
		public void MostrarDados()
		{
			
			// mostrar dados para porcentagemRevendedor, valorImposto, precoFinal;
		    JOptionPane.showMessageDialog(null,"Nome do Autom�vel: " +getNomeAutomovel()+
			                                "\nPre�o de F�brica do Autom�vel: "+getPrecoFabrica() +
			                                "\nPorcentagem do Revendedor: "+getPorcentagemRevendedor() +
			                                "\nValor do Imposto: " +getValorImposto()+
			                                "\nPre�o Final: " +getPrecoFinal());
			                                 
			}
		
	
	}


