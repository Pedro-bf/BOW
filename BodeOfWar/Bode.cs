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
            TimerChecarVez.Tick += new EventHandler(updateVez);
            TimerChecarVez.Interval = 10000; 
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
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            var retorno = Jogo.IniciarPartida(Int32.Parse(this.idJogador), this.senha);
        }

        private void updateVez(object sender, EventArgs e)
        {
            string verificarVez = Jogo.VerificarVez(this.idPartida);
            string[] iten = verificarVez.Split(',');
            lblJogadorVez.Text = iten[1];

            lstVezEstado.Items.Add(Jogo.VerificarVez(this.idPartida));
        }
    }
}
