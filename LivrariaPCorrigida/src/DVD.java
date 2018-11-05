import java.text.DecimalFormat;
import javax.swing.JOptionPane;

public class DVD extends Produto
{
	private String diretor, duracao, censura;

	public DVD(String descricao, String genero, int estoqueDisponivel,
			double precoCusto, double precoVenda, String diretor,
			String duracao, String censura) {
		super(descricao, genero, estoqueDisponivel, precoCusto, precoVenda);
		this.diretor = diretor;
		this.duracao = duracao;
		this.censura = censura;
	}
	
	public DVD()
	{
		this("","",0,0,0,"","","");
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
											"\nGenero: " + getGenero() +
											"\nEstoque Disponível: " + getEstoqueDisponivel() +
											"\nPreço de Custo: R$ " + df.format(getPrecoCusto()) +
											"\nPreço de Venda: R$ " + df.format(getPrecoVenda()) +
											"\nDiretor: " + getDiretor() +
											"\nDuração: " + getDuracao() +
											"\nCensura: " + getCensura());
	}
	
	public void calcularPrecoVenda()
	{
		setPrecoVenda(getPrecoCusto() * 1.23);
		JOptionPane.showMessageDialog(null, "Calculo Efetuado com Sucesso!!!");
	}
	
	public void calcularPrecoVenda(double cotacaoDolar)
	{
		setPrecoVenda((getPrecoCusto() * 1.23) * cotacaoDolar);
		JOptionPane.showMessageDialog(null, "Calculo Efetuado com Sucesso!!!");
	}
	
	public void cadastrar()
	{
		setDescricao(JOptionPane.showInputDialog("Digite a Descrição do DVD"));
		setGenero(JOptionPane.showInputDialog("Digite o Genero do DVD"));
		setEstoqueDisponivel(Integer.parseInt(JOptionPane.showInputDialog("Digite o Estoque Atual do DVD")));
		setPrecoCusto(Double.parseDouble(JOptionPane.showInputDialog("Digite o Preço de Custo do DVD")));
		setPrecoVenda(0);
		setDiretor(JOptionPane.showInputDialog("Digite o Diretor(a) do DVD"));
		setDuracao(JOptionPane.showInputDialog("Digite a Duração do DVD"));
		setCensura(JOptionPane.showInputDialog("Digite a Censura do DVD"));
	}
}


