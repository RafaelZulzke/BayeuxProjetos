import javax.swing.JOptionPane;
import java.text.DecimalFormat;



public class Cd extends Produto {
	
private String artista,gravadora,PaisOrigem;

public Cd()
{
	this("","",0,0,0,"","","");
}

public Cd(String descricao, String genero, int estoqueDisponivel, double precoCusto, double precoVenda,String artista, String gravadora, String PaisOrigem) {
	super(descricao,genero,estoqueDisponivel,precoCusto,precoVenda);
	this.artista = artista;
	this.gravadora = gravadora;
	this.PaisOrigem = PaisOrigem;
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
	return PaisOrigem;
}

public void setPaisOrigem(String paisOrigem) {
	PaisOrigem = paisOrigem;
}

DecimalFormat df = new DecimalFormat("###,##0.00");

public void listarProduto()
{
	JOptionPane.showMessageDialog(null, "Descrição: " + getDescricao() +
										"\nGenero: " + getGenero() +
										"\nEstoque Disponível: " + getEstoqueDisponivel() +
										"\nPreço de Custo: R$ " + df.format(getPrecoCusto()) +
										"\nPreço de Venda: R$ " + df.format(getPrecoVenda()) +
										"\nArtista: " + getArtista() +
										"\nGravadora: " + getGravadora() +
										"\nPaís de Origem: " + getPaisOrigem());
}

/*public void listarProduto()
{
JOptionPane.showMessageDialog(null, "Artista:" + getArtista()+
		                            "\nGravadora" + getGravadora()+
		                             "\nPais de Origem" + getPaisOrigem());

	
}*/


public void cadastrar()
{
	setDescricao(JOptionPane.showInputDialog("Digite a Descrição do CD"));
	setGenero(JOptionPane.showInputDialog("Digite o Genero do CD"));
	setEstoqueDisponivel(Integer.parseInt(JOptionPane.showInputDialog("Digite o Estoque Atual do CD")));
	setPrecoCusto(Double.parseDouble(JOptionPane.showInputDialog("Digite o Preço de Custo do CD")));
	setPrecoVenda(0);
	setArtista(JOptionPane.showInputDialog("Digite o Artista do CD"));
	setGravadora(JOptionPane.showInputDialog("Digite a Gravadora do CD"));
	setPaisOrigem(JOptionPane.showInputDialog("Digite o País de Origem do CD"));
}


public void calcularPrecoVenda()
{
	setPrecoVenda(getPrecoCusto() * 1.23);
	JOptionPane.showMessageDialog(null, "Calculo Efetuado com Sucesso!!!");
}



/*public void calcularPreco()
{
	JOptionPane.showMessageDialog(null, "Preco de Venda Anterior:" + this.getPrecoCusto()+
			                       "\nPorcentagem Aplicada : 15 %" +"\nPreco de Venda Atual"+
			                             (this.getPrecoCusto()* 0.15 + this.getPrecoCusto()));
	
}*/



}