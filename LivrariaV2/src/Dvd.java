import javax.swing.JOptionPane;

//A Classe Dvd é filha ilegitima da classe Produto 
public class Dvd extends Produto {
	
	//Atributos 
	private String diretor;
	private String duracao;
	private String censura;
	
	//Construtores
	public Dvd ()
	{
		this("", "", 0,0, "", "", "");
	}


	public Dvd(String descricao, String genero, int estoqueDisponivel,
			double precoCusto,String diretor,String duracao,String censura) {
		super(descricao, genero, estoqueDisponivel, precoCusto, precoCusto);
		this.diretor = diretor;
		this.duracao = duracao;
		this.censura = censura;
}
	//Getters e Setters


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
	
	//Metodos Unicos dessa Classe o resto é recalque
	
	public void listarProduto(){
		JOptionPane.showMessageDialog(null,"Descrição:" + this.getDescricao()+
				"\nGenero:" + this.getGenero()+ "\nEstoque:"+this.getEstoqueDisponivel()+
			"\nPreço Custo:" + this.getPrecoCusto()+"\nCensura:" + this.getCensura()+
			"\nDuração:" + this.getDuracao()+"\nDiretor:" + this.getDiretor());	
	}
	
	public void calcularPrecoVenda(double cotacaoDolar)
	{
		/* Calcula o preço de venda utilizando a cotação do dolar passada
		   por parâmetro precoVenda(precoCusto * 1.22 * cotacaoDolar). */
		
		// Apresenta o estoque atual e o estoque já reajustado
		JOptionPane.showMessageDialog(null, "Preço de Venda Anterior: " + this.getPrecoVenda() +
				    "\nCotação do dólar: " + cotacaoDolar + "\nPreço de Venda Atual: " +
				(this.getPrecoCusto() + (this.getPrecoCusto() * cotacaoDolar)));
		
		// Atribui o resultado da subtração do atributo estoqueDisponivel
		this.setPrecoVenda(this.precoCusto + (this.precoCusto * cotacaoDolar));
	}
	
}
