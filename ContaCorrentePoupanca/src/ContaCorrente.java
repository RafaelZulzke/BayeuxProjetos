import javax.swing.JOptionPane;


public class ContaCorrente extends Conta {
	
	private double limiteEspecial;
	
	public ContaCorrente()
	{
		this(0);
	}
	
	public ContaCorrente(double saldo) {
		super(saldo);
		this.limiteEspecial = limiteEspecial;
	}

	public double getLimiteEspecial() {
		return limiteEspecial;
	}

	public void setLimiteEspecial(double limiteEspecial) {
		this.limiteEspecial = limiteEspecial;
	}

	public void atualizarSaldo()
	{
		double saldo = getSaldo(); 
		if (saldo < 0)
		{
			double valorJuros=(saldo*0.0299);
			saldo = (0.0299-saldo-getLimiteEspecial());
		   JOptionPane.showMessageDialog(null,"Saldo Anterior"+getSaldo() +
				                              "\nSaldo Negativo e Juros"+String.valueOf (valorJuros));
		}
		
	}
	
	
	public void debitar (double valor)
	{
		setLimiteEspecial(Double.parseDouble(JOptionPane.showInputDialog(null,"Digite o Limite Especial")));
		valor = Double.parseDouble(JOptionPane.showInputDialog("Digite o valor a debitar:"));
		
		double saldoanterior = getSaldo();
		
		
		if (this.getSaldo()+ this.getLimiteEspecial() >= valor)
        {
			this.setSaldo(this.getSaldo()- valor);
        	JOptionPane.showMessageDialog(null, "Saldo Negativo além do que o limite especial permite.");
        	
        } else{
				
		JOptionPane.showMessageDialog(null, "Saldo Ficará Negativo Em: R$"+ saldoanterior + String.valueOf((this.getSaldo()+ limiteEspecial)- valor));
        }
	}

}
