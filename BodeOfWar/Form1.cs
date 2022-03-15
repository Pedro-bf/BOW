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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblVersao.Text = Jogo.Versao;
        }

        private void btnPartida_Click(object sender, EventArgs e)
        {
            lstPartida.Items.Clear(); //limpa a lstBox
            string retorno = Jogo.ListarPartidas("T");

            if (retorno.Contains("ERRO:")) mostraErro(retorno);
            else
            {
                retorno = retorno.Replace("\r", "");
                retorno = retorno.Substring(0, retorno.Length - 1);
                string[] partidas = retorno.Split('\n');

                for (int i = 0; i < partidas.Length; i++)
                {
                    lstPartida.Items.Add(partidas[i]);
                }
            }

        }

        private void btnExibirPartidade_Click(object sender, EventArgs e)
        {
            if (lstPartida.SelectedItem != null)
            {
                string partida = lstPartida.SelectedItem.ToString();
                string[] iten = partida.Split(',');

                txtIdPartida.Text = iten[0];
                string jogadores = Jogo.ListarJogadores(Int32.Parse(iten[0]));
                if (jogadores.Contains("ERRO:")) mostraErro(jogadores);
                else txtJogadores.Text = jogadores;
                
            }
            else mostraErro("ERRO: Nenhuma partida foi escolhida");
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nomeP = txtNomePartida.Text;
            string senhaP = txtSenhaPartida.Text;

            string erro = Jogo.CriarPartida(nomeP, senhaP);
            if(erro != null) mostraErro(erro);

        }

        private void mostraErro(string erro)
        {
            MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSelecionarPartida_Click(object sender, EventArgs e)
        {
            string partida = lstPartida.SelectedItem.ToString();
            string[] iten = partida.Split(',');
            var id = txtIdPartida.Text = iten[0];

            Login login = new Login(id);
            login.Show();
        }

        
    }
}
