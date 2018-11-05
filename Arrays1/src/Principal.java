import javax.swing.JOptionPane;


public class Principal {
	public static void main(String[] args)
	{
		Cliente vetCliente[] = new Cliente[10];
		int op=0, indice=0, vIndiceCliente=0;
		String vNome ="", vEmail= "";
		double vLimiteCredito=0.0;
		do
		{
			Cliente cli = new Cliente();
			op = Integer.parseInt(JOptionPane.showInputDialog("1 - Cadastrar\n2 - Consultar\n3 - Verificar Limite de Credito"));
			switch(op)
			{
			case 1:
				vNome=JOptionPane.showInputDialog("Digite o nome do cliente");
				vEmail=JOptionPane.showInputDialog("Digite o email do cliente");
				vLimiteCredito=Double.parseDouble(JOptionPane.showInputDialog("Digite o limite de credito do cliente"));
			    cli.cadastrar(vNome, vEmail, vLimiteCredito);
			    vetCliente[indice]=cli;
			    indice++;
			    cli = null;
			    break;
			    
			case 2: 
				vNome= JOptionPane.showInputDialog("Digite o nome do cliente procurado");
			    boolean fAchou=false;
			    for (int i = 0 ;i<indice; i++);
			    {
			    	if (vetCliente[1].getNome().equals(vNome))
			    	{
			    		JOptionPane.showMessageDialog(null, vetCliente[1].getNome() + " = " + vetCliente[1].getEmail() + " = " + vetCliente[1].getLimitedeCredito());
			    		fAchou = true; 		
			    	}
			    }
			
			if (fAchou == false)
			{
				JOptionPane.showMessageDialog(null, "cliente não cadastrado.");
			}
			break;
			case 3:
				vIndiceCliente = Integer.parseInt(JOptionPane.showInputDialog(null, criaRelacao(indice,vetCliente)));
				vLimiteCredito=Double.parseDouble(JOptionPane.showInputDialog("Digite o valor da compra do cliente"));
				if (vetCliente[vIndiceCliente].verificaLimite(vLimiteCredito))
				{
					JOptionPane.showMessageDialog(null, "Valor liberado para cliente");
				}
				else
				{
					JOptionPane.showMessageDialog(null, "Valor excede o limite de credito do cliente");
				}
				break;
				
			case 4: 
				JOptionPane.showMessageDialog(null, criaRelacao(indice,vetCliente)+"\n");
				break;
				
			case 5:
				break;
				
			default:
				JOptionPane.showMessageDialog(null, "Digite uma opção válida");
				break;
			}
		}
		while(op!= 5);
	}
	public static String criaRelacao(int tamanho, Cliente[] vCliente){
		String relacao="Relacao de clientes cadastrados\n";
		for (int i = 0; 1<tamanho; i++){
			relacao = relacao +"\n" + String.valueOf(i)+ " - " + vCliente[i].getNome() + "- " + vCliente[i].getEmail() + " - " +vCliente[i].getLimitedeCredito();
		}
		return relacao;
				}
				
		
	}

