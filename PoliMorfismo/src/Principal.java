import javax.swing.JOptionPane;

public class Principal {
	
	public static void main(String[] args) {
	
		Livro objLivro = new Livro();
		Cd objCD = new Cd();
		Dvd objDvd = new Dvd();
		GerenciadorEstoque objGerenciado = new GerenciadorEstoque();
	
		int op=0, operacao;
		
		do
		{
			op = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção \n1 - Cadastrar Livro  \n2 - Cadastrar CD \n3 - Cadastrar Dvd  \n4 - Livro \n5 - CD \n6 - DVD \n0 - Sair"));
			 
			switch (op)
			{	
			
			case 1:
				objLivro.cadastrar();
				break;
			case 2:
				objCD.cadastrar();
				break;
				
			case 3:
				objDvd.cadastrar();
				break;
				
			case 4: 
				operacao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção  \n1 - Listar \n2 - Comprar \n3 - Vender \n4 - Calcular Preço \n5 - Encomendar "));
				
				if (operacao == 1) 
					{
					objLivro.listarProduto();
					}
					if (operacao == 2)
				{
					
					objGerenciado.comprar(objLivro);
				}
				if (operacao == 3)
				{
					
					objGerenciado.vender(objLivro);
				}
				
				if (operacao == 4)
				{
					objLivro.calcularPrecoVenda();
				}
				
				if (operacao == 5 ) 
				{
					objGerenciado.encomendar(objLivro);
				}
					break;
					
			case 5:
				operacao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção \n1 - Listar \n2 - Comprar \n3 - Vender \n4 - Calcular Preço \n5 - Encomendar "));
				
				if (operacao == 1) 
				{
					objCD.listarProduto();
				}
					if (operacao == 2)
				{
				
					objGerenciado.comprar(objCD);
				}
				
				if (operacao == 3)
				{
					objGerenciado.vender(objCD);
					}
				if (operacao == 4)
				{
					objCD.calcularPrecoVenda();
				}
				
				if (operacao == 5 ) 
				{
					objGerenciado.encomendar(objLivro);
				}
				break;	
			case 6:
				operacao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção \n1 - Listar \n2 - Comprar \n3 - Vender \n4 - Calcular Preço \n5 - Encomendar "));
				
				if (operacao == 1) 
				{
					objDvd.listarProduto();
				}
					if (operacao == 2)
				{
				
					objGerenciado.comprar(objDvd);
				}
				
				if (operacao == 3)
				{
					objGerenciado.vender(objDvd);
				}
				
				if (operacao == 4)
				{
					String resp = JOptionPane.showInputDialog("DVD é Importado ? S/N");
					if (resp.equals("S") || resp.equals("s"))
					{

					double dolar = Double.parseDouble(JOptionPane.showInputDialog("Digite a cotação do Dolar"));
					objDvd.calcularPrecoVenda(dolar);
					}
					else 
						objDvd.calcularPrecoVenda();
				}
				
				if (operacao == 5 ) 
				{
					objGerenciado.encomendar(objLivro);
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

	


