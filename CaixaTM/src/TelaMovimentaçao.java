import java.awt.*;
import java.awt.event.*;
import java.text.DecimalFormat;
import javax.swing.JOptionPane;

@SuppressWarnings("serial")
public class TelaMovimentaçao extends Frame implements WindowListener, ActionListener
{
	Caixa cx = new Caixa();
	
	protected Dimension dFrame, dLabel, dTextField, dButton;
	protected Button cmdEntrada, cmdConsulta, cmdRetirada, cmdSair;
	protected TextField txtValor, txtSaldo;
	protected Label lblValor, lblSaldo;
	protected TextArea txtMensagens;

	//Construtor da Tela Login
	public TelaMovimentaçao()
	{
		//Definição dos Tamanhos dos Componentes
		Dimension dFrame = new Dimension(260, 350);
		Dimension dLabel = new Dimension(40, 20);
		Dimension dTextField = new Dimension(150, 20);
		Dimension dButton = new Dimension(95, 20);
		Dimension dTextArea = new Dimension(220, 100);
		
		//Definição do Formato do Frame
		setTitle("Controle de Caixa");
		setResizable(false);
		setSize(dFrame);
		setLocation(400, 200);
		setBackground(Color.green);
		//Layout Nulo
		setLayout(null);
		
		//Atributos do Label
		lblValor = new Label("Valor: ");
		lblValor.setSize(dLabel);
		lblValor.setLocation(25, 50);
		
		lblSaldo = new Label("Saldo: ");
		lblSaldo.setSize(dLabel);
		lblSaldo.setLocation(25, 100);
		
		//Atributos do TextField
		txtValor = new TextField();
		txtValor.setSize(dTextField);
		txtValor.setLocation(75, 50);

		txtSaldo = new TextField();
		txtSaldo.setSize(dTextField);
		txtSaldo.setLocation(75, 100);
		
		//Atributos do TextArea
		txtMensagens = new TextArea(240, 60);
		txtMensagens.setSize(dTextArea);
		txtMensagens.setLocation(25, 220);
		
		//Botão Entrada
		cmdEntrada = new Button("Entrada");
		cmdEntrada.setSize(dButton);
		cmdEntrada.setLocation(25, 150);
		cmdEntrada.addActionListener(this);

		//Botão Retirada
		cmdRetirada = new Button("Retirada");
		cmdRetirada.setSize(dButton);
		cmdRetirada.setLocation(140, 150);
		cmdRetirada.addActionListener(this);
		
		//Botão Consulta
		cmdConsulta = new Button("Consulta");
		cmdConsulta.setSize(dButton);
		cmdConsulta.setLocation(25, 185);
		cmdConsulta.addActionListener(this);

		//Botão Sair
		cmdSair = new Button("Sair");
		cmdSair.setSize(dButton);
		cmdSair.setLocation(140, 185);
		cmdSair.addActionListener(this);
		
		//Adiciona os objetos ao Frame
		add(lblValor);
		add(txtValor);
		add(lblSaldo);
		add(txtSaldo);
		add(cmdEntrada);
		add(cmdRetirada);
		add(cmdConsulta);
		add(cmdSair);
		add(txtMensagens);
		
		//Adiciona ao Listener
		addWindowListener(this);
	}
		public void windowActivated(WindowEvent e){}
		public void windowDectivated(WindowEvent e){}
		public void windowIconified(WindowEvent e){}
		public void windowDeiconified(WindowEvent e){}
		public void windowOpened(WindowEvent e){}
		public void windowClosed(WindowEvent e){}
		public void windowClosing(WindowEvent e)
		{
			System.exit(0);
		}
		public void windowDeactivated(WindowEvent arg0) {}
		
		DecimalFormat df = new DecimalFormat("R$ ###,##0.00");
		
		public void actionPerformed(ActionEvent e)
		{			
			if (e.getSource()==cmdEntrada)
			{
				try
				{
					txtMensagens.append(cx.entrada(Double.parseDouble(txtValor.getText())) + "\n");
					txtValor.setText("");
				}
				catch (NumberFormatException erro)
				{
					JOptionPane.showMessageDialog(null, "Digite apenas Números!","Tipo Inválido",0);
				}
			}
			
			if (e.getSource()==cmdRetirada)
			{
				try
				{
					txtMensagens.append(cx.retirada(Double.parseDouble(txtValor.getText()))+"\n");
					txtValor.setText("");
				}
				catch (NumberFormatException erro)
				{
					JOptionPane.showMessageDialog(null, "Digite apenas Números!","Tipo Inválido",0);
				}
			}
			
			if (e.getSource()==cmdConsulta)
			{
				txtSaldo.setText(Double.toString(cx.getSaldo()));
			}
			
			if (e.getSource()==cmdSair)
			{
				JOptionPane.showMessageDialog(null, "Obrigado, Volte Sempre","ATENÇÃO",3);
				System.exit(0);
			}
			
		}
}