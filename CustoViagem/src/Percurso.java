
import java.text.DecimalFormat;

import javax.swing.JOptionPane;


public class Percurso {

	private double kmPercorrida, valorCombustivel, valorPedagio;


	
	//construtores
	
	public Percurso(double kmPercorrida, double valorCombustivel,
			double valorPedagio) {
		super();
		this.kmPercorrida = kmPercorrida;
		this.valorCombustivel = valorCombustivel;
		this.valorPedagio = valorPedagio;
	}
	
	public Percurso()
	{
		this(0,0,0);
	}

	//getters and setters
	public double getKmPercorrida() {
		return kmPercorrida;
	}

	public void setKmPercorrida(double kmPercorrida) {
		this.kmPercorrida = kmPercorrida;
	}

	public double getValorCombustivel() {
		return valorCombustivel;
	}

	public void setValorCombustivel(double valorCombustivel) {
		this.valorCombustivel = valorCombustivel;
	}

	public double getValorPedagio() {
		return valorPedagio;
	}

	public void setValorPedagio(double valorPedagio) {
		this.valorPedagio = valorPedagio;
	}
	
	//metodo para cadastrar percurso
	
	public void cadastrarPercurso()
	{
		setKmPercorrida(Double.parseDouble(JOptionPane.showInputDialog(null, "Insira o KM percorrido")));
		setValorCombustivel(Double.parseDouble(JOptionPane.showInputDialog(null,"Insira o Valor do Combustível")));
		setValorPedagio(Double.parseDouble(JOptionPane.showInputDialog(null,"Insira o preço do Pedagio")));
		
	}
	DecimalFormat df = new DecimalFormat("###,##0.00");
	public void listarPercurso()
	{
	 	JOptionPane.showMessageDialog(null,"KM Percorrido : " + getKmPercorrida() + 
	                                  "\nValor do Combustível : R$ "+ df.format(getValorCombustivel())+
	                                  "\nValor Pedagio: R$ " +df.format(getValorPedagio()));                                  
 }
	

	}


