import javax.swing.JOptionPane;


public abstract class Conta {
	
	private double saldo;
	
	public Conta()
	{
		this(0);
	}

	public Conta(double saldo) {
		super();
		this.saldo = saldo;
	}

	public double getSaldo() {
		return saldo;
	}

	public void setSaldo(double saldo) {
		this.saldo = saldo;
	}

	public void creditar (double valor)
	{  double saldoanterior = getSaldo();
	 
	
	setSaldo(saldoanterior + valor);
	
	JOptionPane.showMessageDialog(null, "Saldo Anterior: "+ saldoanterior + 
			                             "\nSaldo Atual"+getSaldo());
	}
	
	public void debitar (double valor)
	{

		valor = Double.parseDouble(JOptionPane.showInputDialog("Digite o valor a debitar:"));
		 if(this.getSaldo() >= valor){
			 
		this.setSaldo(this.getSaldo() - valor);	 
		JOptionPane.showMessageDialog(null,"Valor Debitado.");
		
		
		 }else{
			JOptionPane.showMessageDialog(null, "Saldo Atual: "+ String.valueOf(this.getSaldo())); 
			JOptionPane.showMessageDialog(null, "Saldo Insuficente."); 
		 }
		
		
	}
	
	abstract void atualizarSaldos();
}
