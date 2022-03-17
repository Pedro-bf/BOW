using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
