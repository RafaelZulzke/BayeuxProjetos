import javax.swing.JOptionPane;



public class Principal {

	public static void main(String[] args) {

		
		Vendedor objVendedor = new Vendedor();
		
		/* 1- Entrada de Dados		2 - Calcular Comiss�o
		3 - Mostrar Informa��es	0 - Sair */
		
		int opcao;
		double passagemvv;
		
		do
		{
			opcao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Op��o:" +
					"\n1 - Entrada de Dados\n2 - Calcular Comiss�o\n3 - Mostrar Informa��es\n0 - SAIR"));
			switch (opcao)
			{
		
			case 1 :
				objVendedor.EntradaDados();
			break;
			
			//calculo de comissao
			case 2:
				passagemvv = Double.parseDouble(JOptionPane.showInputDialog("Digite o Valor de Venda do Vendedor."));
				double retornoCalculoComissao = objVendedor.CalculoComissao(passagemvv);
				JOptionPane.showMessageDialog(null, "Comiss�o do Vendedor: " + retornoCalculoComissao);
			break; 
			
			case 3:
				objVendedor.MostrarInfos();
			
			case 0:
				JOptionPane.showMessageDialog(null, "Programa Terminado.");
			break;
				
			default:
				JOptionPane.showMessageDialog(null, "Op��o Inv�lida...");
			break;
			}
		}while(opcao!=0); 
	}
	}
