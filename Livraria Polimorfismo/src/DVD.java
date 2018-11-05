import javax.swing.JOptionPane;


public class DVD extends Produto{

	private String Diretor,Duracao,Censura;



	public DVD(String descricao, String genero, int estoqueDisponivel,
			double precoCusto, double precoVenda,String Duracao, String Diretor,String Censura) {
		super(descricao, genero, estoqueDisponivel, precoCusto, precoVenda);

	}

	public DVD()
	{
		this("","",0,0,0,"","","");
	}


	public String getDiretor() {
		return Diretor;
	}

	public void setDiretor(String diretor) {
		Diretor = diretor;
	}

	public String getDuracao() {
		return Duracao;
	}

	public void setDuracao(String duracao) {
		Duracao = duracao;
	}

	public String getCensura() {
		return Censura;
	}

	public void setCensura(String censura) {
		Censura = censura;
	}


	public void listarProduto()
	{
		JOptionPane.showMessageDialog(null, "Descrição: " + getDescricao() +
				                      "\nGenero: " + getGenero() + "\nEstoque Disponível: " + getEstoqueDisponivel() +
				                       "\nPreço de Custo: R$" + getPrecoCusto() +
				                       "\nDiretor: " + getDiretor() + "\nDuração: "+ getDuracao() +
				                       "\nCensura: " + getCensura());
	}

	public void calcularPrecoVenda (double CotacaoDolar)
	{
		JOptionPane.showMessageDialog(null,"Preço da Venda" + this.getPrecoVenda()+
				                            "Cotação Dollar" + CotacaoDolar +
				                            "Atual Preço de Venda"  + (this.getPrecoCusto()+ (this.getPrecoCusto() * CotacaoDolar)));
		
		this.setPrecoVenda(this.getPrecoCusto() + (this.getPrecoCusto()* CotacaoDolar));
	 	
	}
	
}
