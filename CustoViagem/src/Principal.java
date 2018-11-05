import javax.swing.JOptionPane;


public class Principal 
{
	public static void main(String[] args) {
		
		Custos objCustos = new Custos();
		Percurso objPercurso = new Percurso();
		int Op;
		
		do
		{
			Op = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção:" +
					"\n1 - Cadastrar Percurso \n2 - Calcular Viagem\n3 -Listar Percurso\n0 - SAIR"));
		//calcperc.CalcViagem(p);
			
		switch (Op)
		{
		case 1:
		objPercurso.cadastrarPercurso();
		break;
		case 2 :

		objCustos.CalcViagem(objPercurso);
		break;
		case 3 : 
			objPercurso.listarPercurso();
		break;
		
		case 0:
			JOptionPane.showMessageDialog(null, "Programa Encerrado.");
			break;
			
			default:
				JOptionPane.showMessageDialog(null, "Opcão Inválida.");
				break;
		}
		}while(Op!=0);
		
	}
	
	}


