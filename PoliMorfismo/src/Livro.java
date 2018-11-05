import java.text.DecimalFormat;
import javax.swing.JOptionPane;


public class Livro extends Produto {
	
	private String autor, editora, edicao;
	
	public Livro()
	{
		this("","",0,0,0,"","","");
	}

	public Livro(String descricao, String genero, int estoqueDisponivel, double precoCusto, double precoVenda,String autor, String editora, String edicao) {
		super(descricao,genero,estoqueDisponivel,precoCusto,precoVenda);
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
	DecimalFormat df = new DecimalFormat("###,##0.00");
	public void listaProduto()
	{
		JOptionPane.showMessageDialog(null, "Descrição: " + getDescricao() +
				"\nGenero: " + getGenero() +
				"\nEstoque Disponível: " + getEstoqueDisponivel() +
				"\nPreço de Custo: R$ " + df.format(getPrecoCusto()) +
				"\nPreço de Venda: R$ " + df.format(getPrecoVenda()) +
				"\nAutor: " + getAutor() +
				"\nEditora: " + getEditora() +
				"\nEdição: " + getEdicao());
;
	}
	
	public void calcularPrecoVenda()
	{
		setPrecoVenda(getPrecoCusto() * 1.23);
		JOptionPane.showMessageDialog(null, "Calculo Efetuado com Sucesso!!!");
	}
	

	public void cadastrar()
	{
		setDescricao(JOptionPane.showInputDialog("Digite a Descrição do Livro"));
		setGenero(JOptionPane.showInputDialog("Digite o Genero do Livro"));
		setEstoqueDisponivel(Integer.parseInt(JOptionPane.showInputDialog("Digite o Estoque Atual do Livro")));
		setPrecoCusto(Double.parseDouble(JOptionPane.showInputDialog("Digite o Preço de Custo do Livro")));
		setPrecoVenda(0);
		setAutor(JOptionPane.showInputDialog("Digite o Autor(a) do Livro"));
		setEditora(JOptionPane.showInputDialog("Digite a Editora do Livro"));
		setEdicao(JOptionPane.showInputDialog("Digite a Edição do Livro"));
	}

	/*public void calcularPreco()
	{
		JOptionPane.showMessageDialog(null, "Preco de Venda Anterior:" + this.getPrecoCusto()+
				                       "\nPorcentagem Aplicada : 10 %" +"\nPreco de Venda Atual"+
				                             (this.getPrecoCusto()* 0.10 + this.getPrecoCusto() ));
		
	}*/
}