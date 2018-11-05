import javax.swing.JOptionPane;


public class Principal {


	public static void main(String[] args) {

		Livro l1 = new Livro(); //Livro("Livro 1", "G�nero 1", 10, 50.00, "Autor 1" , "Editora 1", "Edi��o 1");
        CD c1 = new CD();//("Cd 1", "G�nero 1", 20, 30.00, "Artista 1", "RCA", "Pa�s 1");
	    DVD d1 = new DVD();//("DVD 1", "Genero 1", 23, 40.00, "Diretor 1", "120 minutos", "18 anos");
	    GerenciadorEstoque controle = new GerenciadorEstoque();
        
	    int op=0, opOperacao= 0;
	    
	    do
	    {
	    	op = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Op��o \n1 - Livro \n2 - CD \n3 - DVD \n4 - Totalizar Estoque \n5 - Gerenciador Do Estoque  \n0 - Sair"));

	    	switch (op)
	    	{
		
	    	case 1: //Livro

			//Desvio condicional para defini��o da opera��o escolhida
			if(opOperacao == 1) {  //Consultar
			l1.listaProduto();
			}

			if(opOperacao == 2 ){ // Comprar
			// Realiza chamada ao m�todo comprar e passa o objeto l1 por par�metro
			controle.comprar(l1);
			}

			if(opOperacao == 3 ){ // Vender
			// Realiza chamada ao m�todo vender e passa o objeto l1 por par�metro
			controle.vender(l1);
			}

			if(opOperacao == 4 ){ // Reajuste
			l1.calcularPrecoVenda();
			}

			if(opOperacao == 5){ // Encomenda de Livros
			// Realiza chamada ao m�todo encomendar e passa o objeto l1 por par�metro
			controle.encomendar(l1);
			}
			break;
	    	case 2: // CD
	    		if(opOperacao == 1) { // Consultar
	    		c1.listarProduto();
	    		}

	    		if(opOperacao == 2) { // Comprar
	    		// Realiza chamada ao m�todo comprar e passa o objeto c1 por par�metro
	    		controle.comprar(c1);
	    		}

	    		if(opOperacao == 3) { // Vender
	    		// Realiza chamada ao m�todo vender e passa o objeto c1 por par�metro
	    		controle.vender(c1);
	    		}

	    		if(opOperacao == 4) { // Reajuste
	    		c1.calcularPrecoVenda();
	    		}

	    		if(opOperacao == 5) { // Encomenda de Livros
	    		// Realiza chamada ao m�todo encomendar e passa o objeto c1 por par�metro
	    		controle.encomendar(c1);
	    		}
	    		break;



	    		case 3: // DVD
	    		if(opOperacao == 1 ){ // Consultar
	    		d1.listarProduto();
	    		}

	    		if(opOperacao == 2) { // Comprar
	    		// Realiza chamada ao m�todo comprar e passa o objeto d1 por par�metro
	    		controle.comprar(d1);
	    		}

	    		if(opOperacao == 3) { // Vender
	    		// Realiza chamada ao m�todo vender e passa o objeto d1 por par�metro
	    		controle.vender(d1);
	    		}

	    		if(opOperacao == 4) { // Reajuste
	    		Double Dolar = Double.parseDouble(JOptionPane.showInputDialog("Digite a cota��o do d�lar:"));
	    		d1.calcularPrecoVenda(Dolar);
	    		}

	    		if(opOperacao == 5) { // Encomenda de Livros
	    		// Realiza chamada ao m�todo encomendar e passa o objeto d1 por par�metro
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
