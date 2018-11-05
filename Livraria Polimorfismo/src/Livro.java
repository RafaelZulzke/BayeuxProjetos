import javax.swing.JOptionPane;


public class Livro extends Produto {

private String autor, editora, edicao;
	
	public Livro()
	{
		this("","","");
	}

	public Livro(String autor, String editora, String edicao) {
		super();
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
	
	public void listaProduto()
	{
		JOptionPane.showMessageDialog(null, "Autor: " + getAutor() +
				"\nEditora: " + getEditora() +
				"\nEdição: " + getEdicao());
	}
	
	public void calcularPreco()
	{
		JOptionPane.showMessageDialog(null, "Preco de Venda Anterior:" + this.getPrecoCusto()+
				                       "\nPorcentagem Aplicada : 10 %" +"\nPreco de Venda Atual"+
				                             (this.getPrecoCusto()* 0.10));
		
	}
	
}
