import javax.swing.JOptionPane;

import java.text.DecimalFormat;



public class Principal {
	
	public static void main(String[] args) {
	
		
		Comanda comandaFecha = new Comanda();
		Caixa caixaFinaliza = new Caixa();

		
		int op;
		double retornoTotalizaComanda;
		
		DecimalFormat df = new DecimalFormat("###,##0.00");
		
		do
		{
			op = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção:" +
		                                                       "\n1 - Lançar Gastos \n2 - Verificar Promoção \n3 - Fechar Mesa \n4 - Listar Comanda \n0 - Sair"));
			
			switch (op)
			{
			case 1:
				comandaFecha.lancarGastos();
				break;
				
			case 2:
				comandaFecha.verificarPromocao();
				break;
				
			case 3:
				retornoTotalizaComanda = caixaFinaliza.totalizarComanda(comandaFecha);
				JOptionPane.showMessageDialog(null, "Total Comanda: R$ " + df.format(retornoTotalizaComanda));
				break;
				
			case 4:
				comandaFecha.listarComanda();
				break;
				
			case 0:
				JOptionPane.showMessageDialog(null, "Programa Encerrado.");
				break;
				
				default:
					JOptionPane.showMessageDialog(null, "Opção Inválida.");
					break;
			}}while(op!=0);
		
	}

}

