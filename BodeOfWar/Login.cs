using System;
using System.IO;
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
    public partial class Login : Form
    {
        private string idPartida;
        public Login(String id)
        {
            this.idPartida = id;
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Location = MousePosition;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string senha = txtSenha.Text;
            string nome = txtNome.Text;
            int id = Int32.Parse(idPartida);

            //checa se esta re entrando em uma partida
            string[] info = carregaLogin(id);
            if (info == null) //partida nova
            {
                //salva o login
                string idJogador = Jogo.EntrarPartida(id, nome, senha);
                if (Erro(idJogador))
                {
                    return;
                }
                string[] iten = idJogador.Split(',');

                salveLogin(iten[0], iten[1], id);
                Bode bode = new Bode(iten[0], iten[1], Int32.Parse(this.idPartida));
                bode.Show();
                this.Close();
            }
            else //logando de novo na partida
            {
                Bode bode = new Bode(info[0], info[1], Int32.Parse(info[2]));
                bode.Show();
                this.Close();
            }
            
        }

        private bool Erro(string erro)
        {
            if (erro.Contains("ERRO:"))
            {
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        //salva em um arquivo login.txt as sequintes informações, e dessa maneira idJogador,senhaJogador,idPartida
        private void salveLogin(string idJogador, string senhaJogador, int idPartida)
        {
            try
            {
                string text = idJogador + "," + senhaJogador + "," + idPartida.ToString();
                string file = AppDomain.CurrentDomain.BaseDirectory.ToString() + "login.txt";
                StreamWriter escreve = new StreamWriter(file);
                escreve.WriteLine(text);
                escreve.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Não foi possivel escrever no arquivo");
                Console.WriteLine(e.Message);
            }
        }

        private string[] carregaLogin(int idPartida)
        {
            try
            {
                string file = AppDomain.CurrentDomain.BaseDirectory.ToString() + "login.txt";
                StreamReader ler = new StreamReader(file);
                string text = ler.ReadToEnd().Trim();
                ler.Close();
                string[] iten = text.Split(',');
                if(Int32.Parse(iten[2]) == idPartida)
                {
                    Console.WriteLine("Logando na partida");
                    return iten;
                }
                else
                {
                    Console.WriteLine("Nâo é a mesma partida");
                    return null;
                }
            }catch (Exception e)
            {
                Console.WriteLine("Não foi possivel ler o arquivo");
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}
