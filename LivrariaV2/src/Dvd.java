import javax.swing.JOptionPane;

//A Classe Dvd � filha ilegitima da classe Produto 
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
	
	//Metodos Unicos dessa Classe o resto � recalque
	
	public void listarProduto(){
		JOptionPane.showMessageDialog(null,"Descri��o:" + this.getDescricao()+
				"\nGenero:" + this.getGenero()+ "\nEstoque:"+this.getEstoqueDisponivel()+
			"\nPre�o Custo:" + this.getPrecoCusto()+"\nCensura:" + this.getCensura()+
			"\nDura��o:" + this.getDuracao()+"\nDiretor:" + this.getDiretor());	
	}
	
	public void calcularPrecoVenda(double cotacaoDolar)
	{
		/* Calcula o pre�o de venda utilizando a cota��o do dolar passada
		   por par�metro precoVenda(precoCusto * 1.22 * cotacaoDolar). */
		
		// Apresenta o estoque atual e o estoque j� reajustado
		JOptionPane.showMessageDialog(null, "Pre�o de Venda Anterior: " + this.getPrecoVenda() +
				    "\nCota��o do d�lar: " + cotacaoDolar + "\nPre�o de Venda Atual: " +
				(this.getPrecoCusto() + (this.getPrecoCusto() * cotacaoDolar)));
		
		// Atribui o resultado da subtra��o do atributo estoqueDisponivel
		this.setPrecoVenda(this.precoCusto + (this.precoCusto * cotacaoDolar));
	}
	
}
