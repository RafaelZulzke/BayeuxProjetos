import javax.swing.JOptionPane;


// A classe Livro � subclasse de Produto
public class Livro extends Produto {
	
	// Atributos
	private String autor;
	private String editora;
	private String edicao;
	
	public Livro()
	{
		this("", "", 0, 0,0, "", "", "");
	}

	public Livro(String descricao, String genero, int estoqueDisponivel,
			double precoCusto, double precoVenda, String autor, String editora,
			String edicao) {
		super(descricao, genero, estoqueDisponivel, precoCusto, precoVenda);
		this.autor = autor;
		this.editora = editora;
		this.edicao = edicao;
		
	}

	public String getAutor() {
		return autor;
	}

	public void setAutor(String autor) {
		this.autor = autor;
	}

	public String getEditora() {
		return editora;
	}

	public void setEditora(String editora) {
		this.editora = editora;
	}

	public String getEdicao() {
		return edicao;
	}

	public void setEdicao(String edicao) {
		this.edicao = edicao;
	}

public void listarProduto(){
		
		JOptionPane.showMessageDialog(null, "Descri��o:" + this.getDescricao() +
				"\nGenero:" + this.getGenero()+ "\nEstoque:" + this.getEstoqueDisponivel()+
				"\nPre�o de Custo:" + this.getPrecoCusto()+"\nAutor:"+ this.getAutor()+ "\nEditora:"+this.getEditora()+
		           "\nEdi��o:"+this.getEdicao());
		
		
		
	}
	

	
	

}