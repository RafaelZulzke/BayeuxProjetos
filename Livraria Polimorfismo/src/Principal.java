import javax.swing.JOptionPane;


public class Principal {


	public static void main(String[] args) {

		Livro l1 = new Livro(); //Livro("Livro 1", "Gênero 1", 10, 50.00, "Autor 1" , "Editora 1", "Edição 1");
        CD c1 = new CD();//("Cd 1", "Gênero 1", 20, 30.00, "Artista 1", "RCA", "País 1");
	    DVD d1 = new DVD();//("DVD 1", "Genero 1", 23, 40.00, "Diretor 1", "120 minutos", "18 anos");
	    GerenciadorEstoque controle = new GerenciadorEstoque();
        
	    int op=0, opOperacao= 0;
	    
	    do
	    {
	    	op = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção \n1 - Livro \n2 - CD \n3 - DVD \n4 - Totalizar Estoque \n5 - Gerenciador Do Estoque  \n0 - Sair"));

	    	switch (op)
	    	{
		
	    	case 1: //Livro

			//Desvio condicional para definição da operação escolhida
			if(opOperacao == 1) {  //Consultar
			l1.listaProduto();
			}

			if(opOperacao == 2 ){ // Comprar
			// Realiza chamada ao método comprar e passa o objeto l1 por parâmetro
			controle.comprar(l1);
			}

			if(opOperacao == 3 ){ // Vender
			// Realiza chamada ao método vender e passa o objeto l1 por parâmetro
			controle.vender(l1);
			}

			if(opOperacao == 4 ){ // Reajuste
			l1.calcularPrecoVenda();
			}

			if(opOperacao == 5){ // Encomenda de Livros
			// Realiza chamada ao método encomendar e passa o objeto l1 por parâmetro
			controle.encomendar(l1);
			}
			break;
	    	case 2: // CD
	    		if(opOperacao == 1) { // Consultar
	    		c1.listarProduto();
	    		}

	    		if(opOperacao == 2) { // Comprar
	    		// Realiza chamada ao método comprar e passa o objeto c1 por parâmetro
	    		controle.comprar(c1);
	    		}

	    		if(opOperacao == 3) { // Vender
	    		// Realiza chamada ao método vender e passa o objeto c1 por parâmetro
	    		controle.vender(c1);
	    		}

	    		if(opOperacao == 4) { // Reajuste
	    		c1.calcularPrecoVenda();
	    		}

	    		if(opOperacao == 5) { // Encomenda de Livros
	    		// Realiza chamada ao método encomendar e passa o objeto c1 por parâmetro
	    		controle.encomendar(c1);
	    		}
	    		break;



	    		case 3: // DVD
	    		if(opOperacao == 1 ){ // Consultar
	    		d1.listarProduto();
	    		}

	    		if(opOperacao == 2) { // Comprar
	    		// Realiza chamada ao método comprar e passa o objeto d1 por parâmetro
	    		controle.comprar(d1);
	    		}

	    		if(opOperacao == 3) { // Vender
	    		// Realiza chamada ao método vender e passa o objeto d1 por parâmetro
	    		controle.vender(d1);
	    		}

	    		if(opOperacao == 4) { // Reajuste
	    		Double Dolar = Double.parseDouble(JOptionPane.showInputDialog("Digite a cotação do dólar:"));
	    		d1.calcularPrecoVenda(Dolar);
	    		}

	    		if(opOperacao == 5) { // Encomenda de Livros
	    		// Realiza chamada ao método encomendar e passa o objeto d1 por parâmetro
	    		controle.encomendar(d1);
	    		}
	    		break;
	    		
	    		case 4 ://totalizar Estoque
	    		
	    			Produto prod[] = new Produto [3];
	    			prod[0] = l1;
	    			prod[1] = c1;
	    			prod[2] = d1;
	    			
	    		controle.totalizadorEstoque(prod);
	    		
              break;	
              
	    		case 5 : //Criar Lista de Produtos
            controle.criarListaProdutos();
	    			break;
 
	    	}
	    }while(op!=0);
	}

}
