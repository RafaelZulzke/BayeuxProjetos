import javax.swing.JOptionPane;


public class Cd extends Produto {
	
	// Atributos
	private String artista;
	private String gravadora;
	private String paisOrigem;
	
// Construtores 
	
	public Cd() {
		this("", "",0, 0, 0, "", "", "");
	}


	public Cd(String descricao, String genero, int estoqueDisponivel,
			double precoCusto, double precoVenda, String artista,
			String gravadora, String paisOrigem) {
		super(descricao, genero, estoqueDisponivel, precoCusto, precoVenda);
		this.artista = artista;
		this.gravadora = gravadora;
		this.paisOrigem = paisOrigem;
	}


	// getters and setters
	public String getArtista() {
		return artista;
	}


	public void setArtista(String artista) {
		this.artista = artista;
	}


	public String getGravadora() {
		return gravadora;
	}


	public void setGravadora(String gravadora) {
		this.gravadora = gravadora;
	}


	public String getPaisOrigem() {
		return paisOrigem;
	}


	public void setPaisOrigem(String paisOrigem) {
		this.paisOrigem = paisOrigem;
	}
	
	public void listarProduto(){
		JOptionPane.showMessageDialog(null,"Descrição:" + this.getDescricao()+
				"\nGenero:" + this.getGenero()+ "\nEstoque:"+this.getEstoqueDisponivel()+
			"\nPreço Custo:" + this.getPrecoCusto()+"\nGravadora" + this.getGravadora()+
			"\nPais de Origem:" + this.getPaisOrigem()+"\nArtista:" + this.getArtista());	
	}
	
	
public void calcularPrecoVenda()
{
	// Apresenta o estoque atual e p estoque ja reajustado
JOptionPane.showMessageDialog(null,"Preço Venda Anterior"+ this.getPrecoVenda()+
		"\nPorcentagem Aplicada :15%"+"\nPreco de Venda Atual" +(this.getPrecoCusto()+(this.getPrecoCusto()*0.15)));
// Atribui o resultado da subtraçaõ do atributo estoqueDisponivel
this.setPrecoVenda(this.precoCusto+(this.precoCusto*0.15));
}
	
	
	
	
	
	
}
