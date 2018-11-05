import javax.swing.JOptionPane;


public class CD extends Produto {
	
private String artista,gravadora,PaisOrigem;

public CD(String artista, String gravadora, String paisOrigem) {
	super();
	this.artista = artista;
	this.gravadora = gravadora;
	PaisOrigem = paisOrigem;
}

public CD ()
{
this("","","");	
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

public void listarProduto()
{
JOptionPane.showMessageDialog(null, "Artista:" + getArtista()+
		                            "\nGravadora" + getGravadora()+
		                             "\nPais de Origem" + getPaisOrigem());

	
}

public void calcularPreco()
{
	JOptionPane.showMessageDialog(null, "Preco de Venda Anterior:" + this.getPrecoCusto()+
			                       "\nPorcentagem Aplicada : 15 %" +"\nPreco de Venda Atual"+
			                             (this.getPrecoCusto()* 0.15));
	
}



}
