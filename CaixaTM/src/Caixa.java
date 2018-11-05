import javax.swing.JOptionPane;

public class Caixa
{
	private double saldo;

	public Caixa(double saldo) {
		this.saldo = saldo;
	}
	
	public Caixa()
	{
		this(0);
	}

	public double getSaldo() {
		return saldo;
	}

	public void setSaldo(double saldo) {
		this.saldo = saldo;
	}
	
	@SuppressWarnings("finally")
	public String entrada(double valor)
	{
		String mens = "Erro ao Executar a Operação!";
		
		try
		{
			if (valor==0 || valor<0)
			{
				throw new IllegalArgumentException();
			}
			this.setSaldo(this.saldo + valor);
			mens = "Entrada realizada com Sucesso!";
		}
		catch (IllegalArgumentException erro)
		{
			JOptionPane.showMessageDialog(null, "A Movimentação não pode ser Zero ou Negativo.","Tipo Inválido",0);
		}
		finally
		{
			return mens;
		}
		
	}
	
	@SuppressWarnings("finally")
	public String retirada(double valor)
	{
		String mens = "Erro ao Executar a Operação!";
		
		try
		{
			if (valor==0 || valor<0)
			{
				throw new IllegalArgumentException();
			}
			if (valor <= this.getSaldo())
			{
				this.setSaldo(this.saldo - valor);
				mens = "Retirada realizada com Sucesso!";
			}else
				mens = "Saldo Insuficiente!";
		}
		catch (IllegalArgumentException erro)
		{
			JOptionPane.showMessageDialog(null, "A Movimentação não pode ser Zero ou Negativo.","Tipo Inválido",0);
		}
		finally
		{
			return mens;
		}	
	}
}