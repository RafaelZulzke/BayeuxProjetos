import javax.swing.JOptionPane;



public class Dvd extends Produto {

private String Diretor,Duracao,Censura;



public Dvd(String descricao, String genero, int estoqueDisponivel,
		double precoCusto, double precoVenda,String Duracao, String Diretor,String Censura) {
	super(descricao, genero, estoqueDisponivel, precoCusto, precoVenda);

}

public Dvd()
{
	this("","",0,0,0,"","","");
}


public String getDiretor() {
	return Diretor;
}

public void setDiretor(String diretor) {
	Diretor = diretor;
}

public String getDuracao() {
	return Duracao;
}

public void setDuracao(String duracao) {
	Duracao = duracao;
}

public String getCensura() {
	return Censura;
}

public void setCensura(String censura) {
	Censura = censura;
}


public void listarProduto()
{
	JOptionPane.showMessageDialog(null, "Descrição: " + getDescricao() +
			                      "\nGenero: " + getGenero() + "\nEstoque Disponível: " + getEstoqueDisponivel() +
			                       "\nPreço de Custo: R$" + getPrecoCusto() +
			                       "\nPreço Venda:R$" + getPrecoVenda()+
			                       "\nDiretor: "  + getDiretor()+ 
			                       "\nDuração: " + getDuracao() +
			                       "\nCensura: " + getCensura());
}

/*public void calcularPrecoVenda (double CotacaoDolar)
{
	JOptionPane.showMessageDialog(null,"Preço da Venda" + this.getPrecoVenda()+
			                            "Cotação Dollar" + CotacaoDolar +
			                            "Atual Preço de Venda"  + (this.getPrecoCusto()+ (this.getPrecoCusto() * CotacaoDolar)));
	
	this.setPrecoVenda(this.getPrecoCusto() + (this.getPrecoCusto()* CotacaoDolar));
 	
}*/
public void calcularPrecoVenda()
{
	setPrecoVenda(getPrecoCusto() * 1.23);
	JOptionPane.showMessageDialog(null, "Calculo Efetuado com Sucesso!!!");
}

public void calcularPrecoVenda(double cotacaoDolar)
{
	setPrecoVenda((getPrecoCusto() * 1.23) * cotacaoDolar);
	JOptionPane.showMessageDialog(null, "Calculo Efetuado com Sucesso!!!");
}

public void cadastrar()
{
	setDescricao(JOptionPane.showInputDialog("Digite a Descrição do DVD"));
	setGenero(JOptionPane.showInputDialog("Digite o Genero do DVD"));
	setEstoqueDisponivel(Integer.parseInt(JOptionPane.showInputDialog("Digite o Estoque Atual do DVD")));
	setPrecoCusto(Double.parseDouble(JOptionPane.showInputDialog("Digite o Preço de Custo do DVD")));
	setPrecoVenda(0);
	setDiretor(JOptionPane.showInputDialog("Digite o Diretor(a) do DVD"));
	setDuracao(JOptionPane.showInputDialog("Digite a Duração do DVD"));
	setCensura(JOptionPane.showInputDialog("Digite a Censura do DVD"));
}



}
