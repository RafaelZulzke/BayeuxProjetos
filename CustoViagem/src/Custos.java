import java.text.DecimalFormat;
import javax.swing.JOptionPane;

public class Custos {

	private double totalPercurso;
	
	public Custos(double totalPercurso) {
		super();
		this.totalPercurso = totalPercurso;
	}
	
	public Custos()
	{
		this(0);
	}

	
	public double getTotalPercurso() {
		return totalPercurso;
	}

	public void setTotalPercurso(double totalPercurso) {
		this.totalPercurso = totalPercurso;
	}
	
	DecimalFormat df = new DecimalFormat("###,##0.00");
	public void CalcViagem(Percurso p)
	{
		setTotalPercurso(p.getKmPercorrida() * p.getValorCombustivel() + p.getValorPedagio());
		JOptionPane.showMessageDialog(null,"Total do Percurso:R$"+ df.format(getTotalPercurso()));
		
	}
	
	
	
	

	

	

}
