

	import java.text.DecimalFormat;
	import javax.swing.JOptionPane;

	public class CD extends Produto
	{
		private String artista, gravadora, paisOrigem;

		public CD(String descricao, String genero, int estoqueDisponivel,
				double precoCusto, double precoVenda, String artista,
				String gravadora, String paisOrigem) {
			super(descricao, genero, estoqueDisponivel, precoCusto, precoVenda);
			this.artista = artista;
			this.gravadora = gravadora;
			this.paisOrigem = paisOrigem;
		}
		
		public CD()
		{
			this("","",0,0,0,"","","");
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
												"\nGenero: " + getGenero() +
												"\nEstoque Disponível: " + getEstoqueDisponivel() +
												"\nPreço de Custo: R$ " + df.format(getPrecoCusto()) +
												"\nPreço de Venda: R$ " + df.format(getPrecoVenda()) +
												"\nArtista: " + getArtista() +
												"\nGravadora: " + getGravadora() +
												"\nPaís de Origem: " + getPaisOrigem());
		}
		
		public void calcularPrecoVenda()
		{
			setPrecoVenda(getPrecoCusto() * 1.23);
			JOptionPane.showMessageDialog(null, "Calculo Efetuado com Sucesso!!!");
		}
		
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
	}




