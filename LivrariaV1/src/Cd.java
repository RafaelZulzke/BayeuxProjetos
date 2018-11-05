import java.text.DecimalFormat;
import javax.swing.JOptionPane;

public class Cd extends Produto
{
	private String artista, gravadora, paisOrigem;

	public Cd(String descricao, String genero, int estoqueDisponivel,
			double precoCusto, String artista, String gravadora,
			String paisOrigem) {
		super(descricao, genero, estoqueDisponivel, precoCusto);
		this.artista = artista;
		this.gravadora = gravadora;
		this.paisOrigem = paisOrigem;
	}
	
	public Cd()
	{
		this("","",0,0,"","","");
	}

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
	
	DecimalFormat df = new DecimalFormat("###,##0.00");
	
	public void listarProduto()
	{
		JOptionPane.showMessageDialog(null, "Descrição: " + getDescricao() +
				"\nGenero: " + getGenero() + "\nEstoque Disponível: " + getEstoqueDisponivel() +
				"\nPreço de Custo: R$ " + df.format(getPrecoCusto()) +
				"\nArtista: " + getArtista() + "\nGravadora: " + getGravadora() +
				"\nPaís de Origem: " + getPaisOrigem());
	}
}

