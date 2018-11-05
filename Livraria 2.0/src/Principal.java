import javax.swing.JOptionPane;


public class Principal {

	public static void main(String[] args) {
		
		Livro objLivro = new Livro();//("Livro 1", "Gênero 1", 10, 50.00, "Autor 1" , "Editora 1", "Edição 1");
        CD objCd = new CD();//("Cd 1", "Gênero 1", 20, 30.00, "Artista 1", "RCA", "País 1");
	    DVD objDVD = new DVD();//("DVD 1", "Genero 1", 23, 40.00, "Diretor 1", "120 minutos", "18 anos");
	    
	    int op=0,opcao=0, operacao;
	    
	    do
	    {
	    	
	    	switch (op)
	    	{
	    	
	    	case 1:
	    		
				operacao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção\n1 - Listar\n2 - Comprar\n3 - Vender"));
				if (operacao == 1) objLivro.listaProduto();
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
			 
	    	case 2 :
	    		operacao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção \n1- Listar \n2-Comprar \n3- Vender "));
	    		if (operacao == 1) objCd.listarProduto();
	    		if(operacao == 2 )
	    		{
	    			int qtde = Integer.parseInt(JOptionPane.showInputDialog("Digite a Quantidade Comprada"));
	    			
	    			objCd.comprar(qtde);
	    		}
	    		if(operacao == 3)
	    		{
	    			int qtde = Integer.parseInt(JOptionPane.showInputDialog("Digite a Quantidade Vendida"));
	    			objCd.vender(qtde);
	    		}
	    		break;
	    		
	    	case 3:
	    		operacao = Integer.parseInt(JOptionPane.showInputDialog("Esclha a Opção \n1 - Listar \n2 - Comprar \n3 - Vender"));
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

	    
	
