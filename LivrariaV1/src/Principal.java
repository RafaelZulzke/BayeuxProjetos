import javax.swing.JOptionPane;

public class Principal
{
	public static void main(String[] args)
	{
		Livro objLivro = new Livro("A Torre Negra vol.1", "Suspense", 10, 80.00, "Stephen King", "Makron", "2ª Edição");
		Cd objCd = new Cd("Brave New World", "Rock", 20, 40.00, "Iron Maiden", "RCA", "EUA");
		Dvd objDVD = new Dvd("A Mão que Balança o Berço", "Suspense", 23, 39.99, "Neal Bloonkamp", "120 minutos", "18 anos");
		
		int opcao, operacao;
		
		do
		{
			opcao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção\n1 - Livro\n2 - CD\n3 - DVD\n0 - SAIR"));
			switch (opcao)
			{
				case 1:
					operacao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção\n1 - Listar\n2 - Comprar\n3 - Vender"));
					if (operacao == 1) objLivro.listarProduto();
					if (operacao == 2) 
					{
						int qtde = Integer.parseInt(JOptionPane.showInputDialog("Digite a Quantidade Comprada"));
						objLivro.comprar(qtde);
					}
					if (operacao == 3) 
					{
						int qtde = Integer.parseInt(JOptionPane.showInputDialog("Digite a Quantidade Vendida"));
						objLivro.vender(qtde);
					}
				break;
				case 2:
					operacao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção\n1 - Listar\n2 - Comprar\n3 - Vender"));
					if (operacao == 1) objCd.listarProduto();
					if (operacao == 2) 
					{
						int qtde = Integer.parseInt(JOptionPane.showInputDialog("Digite a Quantidade Comprada"));
						objCd.comprar(qtde);
					}
					if (operacao == 3) 
					{
						int qtde = Integer.parseInt(JOptionPane.showInputDialog("Digite a Quantidade Vendida"));
						objCd.vender(qtde);
					}
				break;
				case 3:
					operacao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção\n1 - Listar\n2 - Comprar\n3 - Vender"));
					if (operacao == 1) objDVD.listarProduto();
					if (operacao == 2) 
					{
						int qtde = Integer.parseInt(JOptionPane.showInputDialog("Digite a Quantidade Comprada"));
						objDVD.comprar(qtde);
					}
					if (operacao == 3) 
					{
						int qtde = Integer.parseInt(JOptionPane.showInputDialog("Digite a Quantidade Vendida"));
						objDVD.vender(qtde);
					}
				break;
				case 0:
					JOptionPane.showMessageDialog(null, "Progrma Terminado>>>");
				break;
				default:
					JOptionPane.showMessageDialog(null, "Opção Inválida!");
				break;
			}
		}while(opcao != 0);
	}
}


