using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BodeOfWarServer;


namespace BodeOfWar
{

    public partial class Bode : Form
    {
        private Timer TimerChecarVez;

        private string estadoJogo;

        private string[] cartasMao;
        private int idJogador;
        private string senha;
        private int idPartida;

        public void InitTimer()
        {
            TimerChecarVez = new Timer();
            TimerChecarVez.Tick += new EventHandler(update);
            TimerChecarVez.Interval = 5000; //5s 
            TimerChecarVez.Start();
        }

        public Bode(string idJogador, string senha, int idPartida)
        {
            this.idJogador = Int32.Parse(idJogador);
            this.senha = senha;
            this.idPartida = idPartida;
            InitializeComponent();
        }

        private void Bode_Load(object sender, EventArgs e)
        {
            InitTimer();
            txtHistorico.Text = Jogo.ExibirNarracao(this.idPartida);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            var retorno = Jogo.IniciarPartida(idJogador, this.senha);
            update(sender, e);
        }

        private void update(object sender, EventArgs e)
        {

            string verificarVez = Jogo.VerificarVez(this.idPartida);
            string[] iten = verificarVez.Split(',');

            

            if (verificarVez.Contains("J"))
            {
                lblJogadorVez.Text = iten[1];
                string temp = iten[3].Replace('\r', ' ');
                temp = temp.Replace('\n', ' ');
                estadoJogo = temp.Trim();

                string valores = Jogo.VerificarIlha(idJogador, senha);

                if (ToolBox.Erro(valores) == false)
                {
                    lblEscolherIlha.Text = valores;
                }


            }

            txtHistorico.Text = Jogo.ExibirNarracao(this.idPartida);
            
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            string nomeFont = "Microsoft Sans Serif";
            int tamanhoFont = 10;

            string mao = Jogo.VerificarMao(this.idJogador, this.senha);//volta o que tem na mao
            if (ToolBox.Erro(mao))
            {
                return;
            }
            mao = mao.Replace('\r', ' ');
            cartasMao = mao.Split('\n');

            this.pnlMao.Controls.Clear();

            int x = 20;
            int y = 20;
            int alturaMax = -1;

            for (int i = 0; i < cartasMao.Length - 1; i++)
            {
                PictureBox img = new PictureBox();
  
                Label lblValorCarta = new Label();
                Label lblQuantidadeBode = new Label();

                img.Size = new Size(115, 165);

                //pega a img correta da carta

                string[] carta = EncontreCarta(cartasMao[i].Split(','));

                if (carta != null)
                {
                    img.Image = (Image)Properties.Resources.ResourceManager.GetObject("b" + carta[2].Trim());

                    lblValorCarta.Text = carta[0];
                    lblQuantidadeBode.Text = carta[1];

                    lblValorCarta.Location = new Point(20, 10);
                    lblValorCarta.AutoSize = true;
                    lblValorCarta.Font = new Font(nomeFont, tamanhoFont);
                    lblValorCarta.ForeColor = Color.Black;
                    lblValorCarta.BackColor = Color.Transparent;

                    lblQuantidadeBode.Location = new Point(20, img.Height - 10);
                    lblQuantidadeBode.AutoSize = true;
                    lblQuantidadeBode.Font = new Font(nomeFont, tamanhoFont);
                    lblQuantidadeBode.ForeColor = Color.Black;
                    lblQuantidadeBode.BackColor = Color.Transparent;

                    img.SizeMode = PictureBoxSizeMode.StretchImage;

                    Panel pnlCarta = new Panel();
                    pnlCarta.Location = new Point(x, y);
                    img.Controls.Add(lblValorCarta);
                    img.Controls.Add(lblQuantidadeBode);
                    pnlCarta.Controls.Add(img);
                    pnlCarta.Width = img.Width;
                    pnlCarta.Height = img.Height;

                    pnlCarta.Size = new Size(img.Width, pnlMao.Height);

                    x += img.Width + 10;
                    alturaMax = img.Height;
                    if (x > pnlMao.Width - 100)
                    {
                        x = 20;
                        y += alturaMax + 10;
                    }

                    this.pnlMao.Controls.Add(pnlCarta);
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch (estadoJogo)
            {
                case "B":
                    EscolhaBode(txtEscolha.Text,  sender, e);
                    break;
                case "I":
                    EscolhaIlha(txtEscolha.Text);
                    break;
                default:
                    break;
            }
            txtEscolha.Clear();
        }

        private void EscolhaBode(string valorBode, object sender, EventArgs e)
        {
            for (int i = 0; i < cartasMao.Length-1; i++)
            {
                int valor = Int32.Parse(cartasMao[i]);
                int valorBod = Int32.Parse(valorBode);
                if (valor == valorBod)
                {
                    string[] carta = EncontreCarta(cartasMao[i].Split(','));
                    string mensagem = Jogo.Jogar(idJogador, senha, Int32.Parse(carta[0]));
                    if (ToolBox.Erro(mensagem))
                    {
                        return;
                    }

                    btnImg_Click( sender, e);
                }
            }
        }

        private void EscolhaIlha(string valorIlha)
        {
            string valores = Jogo.VerificarIlha(idJogador, senha);
            valores = valores.Replace('\r', ' ');
            valores = valores.Replace('\n', ' ');
            valores = valores.Trim();
            string[] valoresIlhas = valores.Split(',');
            

            if (Int32.Parse(valoresIlhas[0]) == Int32.Parse(valorIlha) || 
                Int32.Parse(valoresIlhas[1]) == Int32.Parse(valorIlha))
            {
                Jogo.DefinirIlha(idJogador, senha, Int32.Parse(valorIlha));
                string mesaIlha = Jogo.VerificarMesa(idPartida);
                lblValorIlha.Text = mesaIlha.Replace(mesaIlha[0], ' ');
                lblEscolherIlha.Text = " ";

                return;
            }
            MessageBox.Show("Valor de Ilha Invalido");
        }

        private string[] EncontreCarta(string[] cartaMao)
        {

            string cartas = Jogo.ListarCartas();//todas as cartas do jogo -> valor, quantidade bode, idImagem
            cartas = cartas.Replace('\r', ' ');
            string[] cartasValores = cartas.Split('\n');

            for (int i = 0; i < cartasValores.Length-1; i++)
            {
                string[] aux = cartasValores[i].Split(',');
                int valorCarta = Int32.Parse(aux[0]);
                int valorMao = Int32.Parse(cartaMao[0]);

                if (valorCarta == valorMao)
                {
                    return aux;
                }
                
            }
            return null;
        }
    }
}
