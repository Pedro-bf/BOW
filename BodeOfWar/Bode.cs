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
            string cartas = Jogo.VerificarMao(Int32.Parse(this.idJogador), this.senha);
            cartas = cartas.Replace('\r', ' ');
            string[] iten = cartas.Split('\n');

            int x = 20;
            int y = 20;
            int alturaMax = -1;

            for(int i = 0; i < 8; i++)
            {
                PictureBox img = new PictureBox();
                img.Size = new Size(115, 165);

                //se tudo estiver correto o caminho agora se adapta para o computador de onde esta sendo rodado
                string currPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                currPath = currPath.Replace("\\bin\\Debug", ""); //apaga a parte \bin\Debug do path para voltar a pasta "raiz"
                currPath = currPath = currPath.Insert(currPath.Length, "\\imagens\\cartas\\b1.PNG"); //adiciona ao final do caminho a img da que queremos mostrar
                
                img.Image = Image.FromFile(@currPath);
                img.Location = new Point(x, y);
                img.SizeMode = PictureBoxSizeMode.StretchImage;
                
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
