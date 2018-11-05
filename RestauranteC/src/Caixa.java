import java.text.DecimalFormat;

import javax.swing.JOptionPane;


public class Caixa {
	
	
	DecimalFormat df = new DecimalFormat("###,##0.00");
	
	public double totalizarComanda(Comanda c)//c=mesa
	{
		c.setValorTotal(c.getValorConsumo()+c.getValorEstacionamento()+c.getValorCouvert()-c.getValorDescontoPromocional());
		JOptionPane.showMessageDialog(null, "Calculos Efetuados com Sucesso!");
		return c.getValorTotal();
	}

	}


