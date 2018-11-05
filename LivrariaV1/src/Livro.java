import java.text.DecimalFormat;
import javax.swing.JOptionPane;

public class Livro extends Produto
{
	private String autor, editora, edicao;
	
	public Livro(String descricao, String genero, int estoqueDisponivel,
			double precoCusto, String autor, String editora, String edicao) {
		super(descricao, genero, estoqueDisponivel, precoCusto);
		this.autor = autor;
		this.editora = editora;
		this.edicao = edicao;
	}
	
	public Livro()
	{
		this("","",0,0,"","","");
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
	
	DecimalFormat df = new DecimalFormat("###,##0.00");
	
	public void listarProduto()
	{
		JOptionPane.showMessageDialog(null, "Descrição: " + getDescricao() +
				"\nGenero: " + getGenero() + "\nEstoque Disponível: " + getEstoqueDisponivel() +
				"\nPreço de Custo: R$ " + df.format(getPrecoCusto()) +
				"\nAutor: " + getAutor() + "\nEditora: " + getEditora() +
				"\nEdição: " + getEdicao());
	}
}
