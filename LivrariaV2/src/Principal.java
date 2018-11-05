
import javax.swing.JOptionPane;

public class Principal {
	
	public static void main(String[] args){
		
		
		//Inicializa os Atributos dos objetos direto no construtor
		//Outra opçao seria cria um metodo cadastrar nas Classes Livro,Cd e Dvd
		
		Livro objLivro = new Livro("Titulo do Livro", "Suspense", 10,90.00, 80.00,
				"Nome do Autor", "Nome da Editora", "6a Edição");
		
		Cd objCd = new Cd ("Título do CD", "Rock", 20, 30.00,40.00,
				"Nome do Artista", "Nome da gravadora", "País de Origem");
		
		Dvd objDvd = new Dvd("Titulo do Dvd", "Terror", 15,120.00,
				"Nome do Diretor", "Tempo de Duração", "18 Anos");
		
		
		
		
	
		
	int op, operacao;

	do
	{
		op = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção \n1 - Livro \n2 - CD \n3 - DVD \n0 - Sair"));
	 
		switch (op)
		{
		case 1:
			operacao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção \n1 - Listar \n2 - Comprar \n3 - Vender"));
		
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
			operacao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção \n1 - Listar \n2 - Comprar \n3 - Vender "));
			
			if (operacao == 1) objCd.listarProduto();
			if (operacao == 2)
			{
				int qtde = Integer.parseInt(JOptionPane.showInputDialog("Digite a Quantidade"));
			
				objCd.comprar(qtde);
			}
			
			if (operacao == 3)
			{
				int qtde = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção \n1 - Listar \n2 - Comprar \n3 - Vender "));
				objCd.vender(qtde);
				}
			break;
			
		case 3:
			operacao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção\n1 - Listar\n2 - Comprar\n3 - Vender"));
			
			if (operacao == 1) objDvd.listarProduto();
			if (operacao == 2)
			{
				int qtde = Integer.parseInt(JOptionPane.showInputDialog("Digite a Quantidade Comprada"));
			
				objDvd.comprar(qtde);
			}
			
			if (operacao == 3)
			{
				int qtde = Integer.parseInt(JOptionPane.showInputDialog("Digite a Quantidade Vendida"));
				objDvd.vender(qtde);
			}
			break;
			
			
				case 0:
					JOptionPane.showMessageDialog(null, "Programa Encerrado.");
					break;
					
					default:
						JOptionPane.showMessageDialog(null, "Opção Inválida.");
						break;
			}
		}while(op != 0);
	}
}