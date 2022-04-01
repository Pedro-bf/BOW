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

        private string idJogador;
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
            this.idJogador = idJogador;
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
            var retorno = Jogo.IniciarPartida(Int32.Parse(this.idJogador), this.senha);
            update(sender, e);
        }

        private void update(object sender, EventArgs e)
        {

            string verificarVez = Jogo.VerificarVez(this.idPartida);
            if (verificarVez.Contains("J"))
            {
                string[] iten = verificarVez.Split(',');
                lblJogadorVez.Text = iten[1];
            }

            txtHistorico.Text = Jogo.ExibirNarracao(this.idPartida);
            
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            string mao = Jogo.VerificarMao(Int32.Parse(this.idJogador), this.senha);
            mao = mao.Replace('\r', ' ');
            string[] iten = mao.Split('\n');

            string cartas = Jogo.ListarCartas();
            cartas = cartas.Replace('\r', ' ');
            string[] cartasValores = cartas.Split('\n');
            

            int x = 20;
            int y = 20;
            int alturaMax = -1;

            for(int i = 0; i < iten.Length-1; i++)
            {
                PictureBox img = new PictureBox();
                img.Size = new Size(115, 165);

                //pega a img correta da carta
                for (int j = 0; j < cartasValores.Length-1; j++)
                {
                    string[] aux = cartasValores[j].Split(',');
                    int valorCarta = Int32.Parse(aux[0]);
                    int valorMao = Int32.Parse(iten[i]);
                    if (valorCarta == valorMao)
                    {
                        img.Image = (Image)Properties.Resources.ResourceManager.GetObject("b" + aux[2].Trim());
                        break;
                    }
                }
                
                img.Location = new Point(x, y);
                img.SizeMode = PictureBoxSizeMode.StretchImage;
                
                /*
                 * TODO: Mostrar o valor e quantida de bodes de cada carta
                 */

                x += img.Width + 10;
                alturaMax = img.Height;
                if(x > pnlMao.Width - 100)
                {
                    x = 20;
                    y += alturaMax + 10;
                }
                this.pnlMao.Controls.Add(img);
            }
        }
    }
}
