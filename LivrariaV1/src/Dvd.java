import java.text.DecimalFormat;
import javax.swing.JOptionPane;

public class Dvd extends Produto
{
	private String diretor, duracao, censura;

	public Dvd(String descricao, String genero, int estoqueDisponivel,
			double precoCusto, String diretor, String duracao, String censura) {
		super(descricao, genero, estoqueDisponivel, precoCusto);
		this.diretor = diretor;
		this.duracao = duracao;
		this.censura = censura;
	}
	
	public Dvd()
	{
		this("","",0,0,"","","");
	}

	public String getDiretor() {
		return diretor;
	}

	public void setDiretor(String diretor) {
		this.diretor = diretor;
	}

	public String getDuracao() {
		return duracao;
	}

	public void setDuracao(String duracao) {
		this.duracao = duracao;
	}

	public String getCensura() {
		return censura;
	}

	public void setCensura(String censura) {
		this.censura = censura;
	}
	
	DecimalFormat df = new DecimalFormat("###,##0.00");
	
	public void listarProduto()
	{
		JOptionPane.showMessageDialog(null, "Descrição: " + getDescricao() +
				"\nGenero: " + getGenero() + "\nEstoque Disponível: " + getEstoqueDisponivel() +
				"\nPreço de Custo: R$ " + df.format(getPrecoCusto()) +
				"\nDiretor: " + getDiretor() + "\nDuração: " + getDuracao() +
				"\nCensura: " + getCensura());
	}
}


