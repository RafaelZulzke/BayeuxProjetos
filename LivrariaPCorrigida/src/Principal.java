import javax.swing.JOptionPane;

public class Principal
{
	public static void main(String[] args)
	{
		
		Livro objLivro = new Livro();
		CD objCd = new CD();
		DVD objDvd = new DVD();
		GerenciadorEstoque objGE = new GerenciadorEstoque();
		
		int opcao, opcaoProduto;
		
		do //opcaoProduto
		{
			opcaoProduto = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção de Produto" +
											"\n1 - Livro" +
											"\n2 - CD" + 
											"\n3 - DVD" +
											"\n0 - Sair"));
			if (opcaoProduto == 1) //Livro
			{
		
				do //opcao
				{
					opcao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção" +
											"\n1 - Cadastrar" +
											"\n2 - Listar Produto" + 
											"\n3 - Calcular Preço de Venda" +
											"\n4 - Comprar" +
											"\n5 - Vender" +
											"\n6 - Encomendar" +
											"\n0 - Voltar ao Menu Principal"));
					switch (opcao)
					{
					case 1://Cadastrar
						objLivro.cadastrar();
						break;
					case 2://Listar Produto
						objLivro.listarProduto();
						break;
					case 3://Calcular Preço de Venda
						objLivro.calcularPrecoVenda();
						break;
					case 4://Comprar
						objGE.comprar(objLivro);
						break;
					case 5://Vender
						objGE.vender(objLivro);
						break;
					case 6://Encomendar
						objGE.encomendar(objLivro);
						break;
					case 0:
						JOptionPane.showMessageDialog(null, "Voltar...");
						break;
					default:
						JOptionPane.showMessageDialog(null, "Opção Inválida!!!");
						break;
					}
			
				}while(opcao!=0); //opcao
		
			}//fim if Livro
			
			else
				if (opcaoProduto == 2) //CD
				{
					do //opcao
					{
						opcao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção" +
												"\n1 - Cadastrar" +
												"\n2 - Listar Produto" + 
												"\n3 - Calcular Preço de Venda" +
												"\n4 - Comprar" +
												"\n5 - Vender" +
												"\n6 - Encomendar" +
												"\n0 - Voltar ao Menu Principal"));
						switch (opcao)
						{
						case 1://Cadastrar
							objCd.cadastrar();
							break;
						case 2://Listar Produto
							objCd.listarProduto();
							break;
						case 3://Calcular Preço de Venda
							objCd.calcularPrecoVenda();
							break;
						case 4://Comprar
							objGE.comprar(objCd);
							break;
						case 5://Vender
							objGE.vender(objCd);
							break;
						case 6://Encomendar
							objGE.encomendar(objCd);
							break;
						case 0:
							JOptionPane.showMessageDialog(null, "Voltar...");
							break;
						default:
							JOptionPane.showMessageDialog(null, "Opção Inválida!!!");
							break;
						}
				
					}while(opcao!=0); //opcao
				}//fim if CD
			
				else
					if (opcaoProduto == 3) //DVD
					{
						do //opcao
						{
							opcao = Integer.parseInt(JOptionPane.showInputDialog("Escolha a Opção" +
													"\n1 - Cadastrar" +
													"\n2 - Listar Produto" + 
													"\n3 - Calcular Preço de Venda" +
													"\n4 - Comprar" +
													"\n5 - Vender" +
													"\n6 - Encomendar" +
													"\n0 - Voltar ao Menu Principal"));
							switch (opcao)
							{
							case 1://Cadastrar
								objDvd.cadastrar();
								break;
							case 2://Listar Produto
								objDvd.listarProduto();
								break;
							case 3://Calcular Preço de Venda
								String resp = JOptionPane.showInputDialog("DVD é Importado ? S/N");
								if (resp.equals("S") || resp.equals("s"))
								{
									double dolar = Double.parseDouble(JOptionPane.showInputDialog("Digite o valor do Dolar do Dia de Hoje"));
									objDvd.calcularPrecoVenda(dolar);
								}
								else
									objDvd.calcularPrecoVenda();
								break;
							case 4://Comprar
								objGE.comprar(objDvd);
								break;
							case 5://Vender
								objGE.vender(objDvd);
								break;
							case 6://Encomendar
								objGE.encomendar(objDvd);
								break;
							case 0:
								JOptionPane.showMessageDialog(null, "Voltar...");
								break;
							default:
								JOptionPane.showMessageDialog(null, "Opção Inválida!!!");
								break;
							}
					
						}while(opcao!=0); //opcao
					}//fim if DVD
					
					else
						
					if (opcaoProduto == 4)
					{
						Produto  prod[] = new Produto[3];
						
						prod[0] = objLivro;
						prod[1] = objCd;
						prod[2] = objDvd;
						
						objGE.totalizadorEstoque(prod);
					}
					else
					
					if (opcaoProduto == 5) objGE.criarListaProduto();
						
						
						
						if ((opcaoProduto != 1) && (opcaoProduto != 2) && (opcaoProduto != 3) && (opcaoProduto != 0)) 
							JOptionPane.showMessageDialog(null, "Opcão Inválida!");
						else
							JOptionPane.showMessageDialog(null, "Programa Terminado!");
		
		}while(opcaoProduto!=0); //opcaoProduto
	}
}





