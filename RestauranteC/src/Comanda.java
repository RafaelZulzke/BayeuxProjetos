import java.text.DecimalFormat;

import javax.swing.JOptionPane;


public class Comanda {

	
	private int id;
	private double valorConsumo, valorEstacionamento, valorCouvert, valorDescontoPromocional, valorTotal;
	
	
	public Comanda()
	{
		this(0, 0, 0, 0, 0, 0);
	}


	public Comanda(int id, double valorConsumo, double valorEstacionamento,
			double valorCouvert, double valorDescontoPromocional,
			double valorTotal) {
		super();
		this.id = id;
		this.valorConsumo = valorConsumo;
		this.valorEstacionamento = valorEstacionamento;
		this.valorCouvert = valorCouvert;
		this.valorDescontoPromocional = valorDescontoPromocional;
		this.valorTotal = valorTotal;
	}

	public Comanda(int id)
	{
		this.id = id;
	}

	public int getId() {
		return id;
	}


	public void setId(int id) {
		this.id = id;
	}


	public double getValorConsumo() {
		return valorConsumo;
	}


	public void setValorConsumo(double valorConsumo) {
		this.valorConsumo = valorConsumo;
	}


	public double getValorEstacionamento() {
		return valorEstacionamento;
	}


	public void setValorEstacionamento(double valorEstacionamento) {
		this.valorEstacionamento = valorEstacionamento;
	}


	public double getValorCouvert() {
		return valorCouvert;
	}


	public void setValorCouvert(double valorCouvert) {
		this.valorCouvert = valorCouvert;
	}


	public double getValorDescontoPromocional() {
		return valorDescontoPromocional;
	}


	public void setValorDescontoPromocional(double valorDescontoPromocional) {
		this.valorDescontoPromocional = valorDescontoPromocional;
	}


	public double getValorTotal() {
		return valorTotal;
	}


	public void setValorTotal(double valorTotal) {
		this.valorTotal = valorTotal;
	}
	
	public void lancarGastos()
	{
		setId(getId()+1);
		setValorConsumo(Double.parseDouble(JOptionPane.showInputDialog("Digite o Valor Consumido.")));
		setValorEstacionamento(Double.parseDouble(JOptionPane.showInputDialog("Digite o Valor do Estacionamento.")));
		setValorCouvert(Double.parseDouble(JOptionPane.showInputDialog("Digite o Valor do Couvert.")));
		setValorDescontoPromocional(0);
		setValorTotal(0);
	}
		
	public void verificarPromocao()
	{//verifica se o valor consumido foi superior a R$ 180,00, se for, armazena 5% do valor consumido no atributo valorDescontoPromocional.
		
		if (getValorConsumo() >= 180)
		{
			//5% do valor consumo, no atributo valorDescontoPromocional.
			setValorDescontoPromocional(getValorConsumo()*0.05);
			JOptionPane.showMessageDialog(null, "Cliente ganhou Desconto");
		}
		else 
			JOptionPane.showMessageDialog(null,"Cliente não ganhou desconto");
	}
	
	DecimalFormat df = new DecimalFormat("###,##0.00");
	
	public void listarComanda()
	{
		JOptionPane.showMessageDialog(null, "Valor Consumido: "+ df.format(getValorConsumo())+
				                             "\nValor Estacionamento: "+df.format(getValorEstacionamento())+
				                              "\nValor Couvert: " +df.format(getValorCouvert())+
				                              "\nValor Desconto Promocional:"+df.format(getValorDescontoPromocional())+
                                              "\nValor Total: "+df.format(getValorTotal())+
                                              "\nId: "+getId());
		}
		
		

	}


