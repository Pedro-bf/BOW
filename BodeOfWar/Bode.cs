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

        private int valorBode;
        private string[] cartasMao;
        private string[] cartasMesa;
        private int idJogador;
        private string senha;
        private int idPartida;
        private int idRodada;
        private int qtdJogadores;

        private bool checarQtdBode = true;
        private bool jogando = true;
        private bool escolheIlha = false;

        private string[] UltimoCartaMesa;

        public void InitTimer()
        {
            TimerChecarVez = new Timer();
            TimerChecarVez.Tick += new EventHandler(update);
            TimerChecarVez.Interval = 2500; //1s 
            TimerChecarVez.Start();
        }

        public Bode(string idJogador, string senha, int idPartida, int qtdBode)
        {
            this.idJogador = Int32.Parse(idJogador);
            this.senha = senha;
            this.idPartida = idPartida;
            this.UltimoCartaMesa = new string[4];
            this.valorBode = 0;
            this.valorBode = qtdBode;
            this.idRodada = 1;
            this.qtdJogadores = 0;
            InitializeComponent();
            lblQtdBodes.Text = valorBode.ToString();
        }

        private void Bode_Load(object sender, EventArgs e)
        {
            InitTimer();
            txtHistorico.Text = Jogo.ExibirNarracao(this.idPartida);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            var retorno = Jogo.IniciarPartida(idJogador, this.senha);
            btnImg_Click(sender, e);
            update(sender, e);

            string[] jogadores = Jogo.ListarJogadores(idPartida).Split('\r');
            this.qtdJogadores = 0;
            this.qtdJogadores = jogadores.Length - 1;
        }

        private void update(object sender, EventArgs e)
        {
            string[] jogadores = Jogo.ListarJogadores(idPartida).Split('\r');
            this.qtdJogadores = jogadores.Length - 1;

            TimerChecarVez.Enabled = false;
            string verificarVez = Jogo.VerificarVez(this.idPartida);
            if (ToolBox.ErroSemMensagem(verificarVez) == true) return; //checa se a partida não iniciou
            string[] partida = verificarVez.Split(',');
            
            //checa se a partida termino
            if (partida[3].Contains('E'))
            {
                string temp = Jogo.ListarJogadores(this.idRodada);
                temp = temp.Replace('\n', ' ');
                temp = temp.Replace('\r', ' ');
                temp = temp.Trim();

                string[] listjogadores = temp.Split(',');
                //Partidade encerrada
                for(int i = 0; i < listjogadores.Length; i += 2)
                {
                    if (listjogadores[i].Equals(partida[1]))
                    {
                        MessageBox.Show($"Partida encerrada! \n Jogador {listjogadores[i+1]} venceu.");
                        i = listjogadores.Length;
                    }
                }
                return;
            }

            int idJogadorVez = 0;

            if (ToolBox.ErroSemMensagem(verificarVez) == false)
            {
                idJogadorVez = Int32.Parse(partida[1]);
            }
            
            txtHistorico.Text = Jogo.ExibirNarracao(this.idPartida);

            if (partida[0].Contains('J'))
            {
                btnImg_Click(sender, e);
                int qtdBode;
                if (Int32.TryParse(lblQtdBodes.Text, out qtdBode) == false)
                {
                    qtdBode = 0;
                }
                
                lblJogadorVez.Text = partida[1];
                string temp = partida[3].Replace('\r', ' ');
                temp = temp.Replace('\n', ' ');
                estadoJogo = temp.Trim();

                string valores = Jogo.VerificarIlha(idJogador, senha);

                if (valores.Contains("ERRO:") == false)
                {
                    lblEscolherIlha.Text = valores;
                    btnEscolherIlha_Click(sender, e);
                    escolheIlha = true;
                }
                else
                {
                    escolheIlha = false;
                }

                string mesaIlha = Jogo.VerificarMesa(idPartida, idRodada);
                ToolBox.Erro(mesaIlha);
                mesaIlha = mesaIlha.Replace('\r', ' ');
                mesaIlha = mesaIlha.Trim();
                string[] mesa = mesaIlha.Split('\n');

                cartasMesa = new string[4];
                int i = 0;
                bool desenharMesa = false;
                foreach ( string carta in mesa)
                {
                    if (carta.Contains('I'))
                    {
                        string tamanhoIlha = carta;
                        lblValorIlha.Text = mesaIlha.Replace(tamanhoIlha[0], ' ');//tira o l inicial
                        
                    }
                    else if (carta.Equals("") == false)
                    {
                        desenharMesa = true;
                        string[] bode = carta.Split(',');
                        string[] cartaBode = EncontreCarta(bode, 1);
                        string auxCarta = "";
                        int cont = 0;
                        foreach (string elemento in cartaBode)
                        {
                            if (cont < 2)
                            {
                                auxCarta += elemento + ",";
                                cont++;
                            }
                            else
                            {
                                auxCarta += elemento;
                            }
                        }
                        cartasMesa[i] = auxCarta;
                        i++;
                    }
                }

                int contador = 0;
                foreach (string item in cartasMesa)
                {

                    if (item == null || UltimoCartaMesa[contador] == null)
                    {
                        if(item != UltimoCartaMesa[contador])
                        {
                            desenharMesa = true;
                        }
                        break;
                    }

                    if (UltimoCartaMesa[contador].Equals(item))
                    {
                        desenharMesa = false;
                    }
                    
                    contador++;
                }

                if (desenharMesa == true)
                {
                    DesenharCarta(cartasMesa, pnlMesa);
                    UltimoCartaMesa = cartasMesa;
                }

                if (lblJogadorVez.Text.Equals(this.idJogador.ToString()) && estadoJogo.Contains('B'))
                {
                    jogarCarta(cartasMesa);
                }

                #region
                int cartasJogadas = 0;//cartas na mesa
                foreach (string cartaJogada in cartasMesa)
                {
                    if(cartaJogada != null)
                    {
                        cartasJogadas += 1;
                    }
                    else
                    {
                        break;
                    }
                }
                #endregion

                if ((qtdJogadores == cartasJogadas && estadoJogo.Contains('B')) ||
                     estadoJogo.Contains('I') || estadoJogo.Contains('F') || estadoJogo.Contains('E')) 
                {
                    if (checarQtdBode)
                    {
                        QtdBode(qtdBode);
                        this.idRodada += 1; //atualiza a rodada para o proximo uso
                    }
                    this.checarQtdBode = false;

                }
                else
                {
                    this.checarQtdBode = true;
                }

            }
            if (false == jogando)
            {
                return;
            }
            TimerChecarVez.Enabled = true;
        }

        private void QtdBode(int quantidadeBode)
        {
            for (int i = 0; i < cartasMesa.Length-1; i++)
            {
                if (cartasMesa[i] == null)
                {
                    break;
                }

                string[] bodeJogado = cartasMesa[i].Split(',');
                //se o nosso valor do nosso bode for menor que outro jogado sai, pos perdemos a partida
                if (valorBode < Int32.Parse(bodeJogado[0]) && valorBode != Int32.Parse(bodeJogado[0]))
                {
                    return;
                }
                quantidadeBode += Int32.Parse(bodeJogado[1]);
            }
            ToolBox.SalvaLogin(idJogador.ToString(), senha, idPartida, quantidadeBode);
            lblQtdBodes.Text = quantidadeBode.ToString();
        }
        private void btnImg_Click(object sender, EventArgs e)
        {
            string mao = Jogo.VerificarMao(this.idJogador, this.senha);//volta o que tem na mao
            if (ToolBox.Erro(mao))
            {
                return;
            }
            mao = mao.Replace('\r', ' ');
            mao = mao.Trim();
            cartasMao = mao.Split('\n');

            this.pnlMao.Controls.Clear();

            if (cartasMao != null)
            {
                DesenharCarta(cartasMao, pnlMao);
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
            int valorBod = 0;// = Int32.Parse(valorBode);
            if (false == int.TryParse(valorBode,out valorBod))
            {
                MessageBox.Show("ERRO: Valor invalido");
                return;
            }
            for (int i = 0; i < cartasMao.Length-1; i++)
            {
                int valor = Int32.Parse(cartasMao[i]);
                
                if (valor == valorBod)
                {
                    string[] carta = EncontreCarta(cartasMao[i].Split(','), 0);
                    string mensagem = Jogo.Jogar(idJogador, senha, Int32.Parse(carta[0]));
                    //salva o valor do bode que foi jogado
                    this.valorBode = valor;
                    if (ToolBox.Erro(mensagem))
                    {
                        return;
                    }
                    
                    btnImg_Click( sender, e);
                    return;
                }
            }
            MessageBox.Show("ERRO: Valor não encontrado");
        }

        private void EscolhaIlha(string valorIlha)
        {
            string valores = Jogo.VerificarIlha(idJogador, senha);
            valores = valores.Replace('\r', ' ');
            valores = valores.Replace('\n', ' ');
            valores = valores.Trim();
            string[] valoresIlhas = valores.Split(',');

            int valorIlha1, valorIlha2,entradaValorIlha;

            if (false == Int32.TryParse(valoresIlhas[0], out valorIlha1))
            {
                return;
            }
            if (false == Int32.TryParse(valoresIlhas[1], out valorIlha2))
            {
                return;
            }
            if (false == Int32.TryParse(valorIlha, out entradaValorIlha))
            {
                return;
            }

            if (valorIlha1 == entradaValorIlha ||
                valorIlha2 == entradaValorIlha)
            {
                Jogo.DefinirIlha(idJogador, senha, Int32.Parse(valorIlha));
                string mesaIlha = Jogo.VerificarMesa(idPartida);
                lblValorIlha.Text = mesaIlha.Replace(mesaIlha[0], ' ');//tira o l inicial
                lblEscolherIlha.Text = " ";

                return;
            }
            MessageBox.Show("Valor de Ilha Invalido");
        }

        private string[] EncontreCarta(string[] cartaMao, int idChecagem)
        {

            string cartas = Jogo.ListarCartas();//todas as cartas do jogo -> valor, quantidade bode, idImagem
            cartas = cartas.Replace('\r', ' ');
            string[] cartasValores = cartas.Split('\n');

            if (cartaMao.Length <= 0 || cartaMao[0].Contains("ERRO:"))
            {
                return null;
            }
            for (int i = 0; i < cartasValores.Length-1; i++)
            {
                string[] aux = cartasValores[i].Split(',');
                int valorCarta = Int32.Parse(aux[0]);
                int valorMao = Int32.Parse(cartaMao[idChecagem]);

                if (valorCarta == valorMao)
                {
                    return aux;
                }
                
            }
            return null;
        }

        private void DesenharCarta(string[] cartas, Panel panel)
        {
            int x = 20;
            int y = 20;
            int alturaMax = -1;

            string nomeFont = "Microsoft Sans Serif";
            int tamanhoFont = 10;

            panel.Controls.Clear();

            foreach (string item in cartas)
            {
                if (item == null)
                {
                    break;
                }
                if (item.Equals("") == true)
                {
                    break;
                }
                PictureBox img = new PictureBox();

                Label lblValorCarta = new Label();
                Label lblQuantidadeBode = new Label();
                img.Size = new Size(115, 165);

                string[] carta = EncontreCarta(item.Split(','), 0);

                img.Image = (Image)Properties.Resources.ResourceManager.GetObject("b" + carta[2].Trim());

                lblValorCarta.Text = carta[0];
                lblQuantidadeBode.Text = carta[1];

                lblValorCarta.Location = new Point(img.Width - 40, 10);
                lblValorCarta.AutoSize = true;
                lblValorCarta.Font = new Font(nomeFont, tamanhoFont);
                lblValorCarta.ForeColor = Color.Black;
                lblValorCarta.BackColor = Color.Transparent;

                lblQuantidadeBode.Location = new Point(20, img.Height - 30);
                lblQuantidadeBode.AutoSize = true;
                lblQuantidadeBode.Font = new Font(nomeFont, tamanhoFont);
                lblQuantidadeBode.ForeColor = Color.Red;
                lblQuantidadeBode.BackColor = Color.Transparent;

                img.SizeMode = PictureBoxSizeMode.StretchImage;

                Panel pnlCarta = new Panel();
                pnlCarta.Location = new Point(x, y);
                img.Controls.Add(lblQuantidadeBode);
                img.Controls.Add(lblValorCarta);
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

                panel.Controls.Add(pnlCarta);
            }
        }

        private void jogarCarta(string[] cartasMesa)
        {
            int menorCartaMesa = 51;
            foreach(string carta in cartasMesa)//achar a menor carta da mesa
            {
                if(carta != null)
                {
                    string[] elemento = carta.Split(',');
                    int valorCarta = Int32.Parse(elemento[0]);
                    if(valorCarta < menorCartaMesa)
                    {
                        menorCartaMesa = valorCarta;
                    }
                }
            }
            if (menorCartaMesa == 51)//jogar a menor carta se a mesa estiver vazia
            {
                Jogo.Jogar(idJogador, senha, Int32.Parse(cartasMao[0]));
                this.valorBode = Int32.Parse(cartasMao[0]);
                return;
            }
            
            List<int> menorValoresMao= new List<int>();
            List<int> maiorValoresMao= new List<int>();
            foreach(string carta in cartasMao)//separar as cartas na mao em dois grupos
            {
                int valorCarta = Int32.Parse(carta);
                if (valorCarta < menorCartaMesa)
                {
                    menorValoresMao.Add(valorCarta);
                }
                else
                {
                    maiorValoresMao.Add(valorCarta);
                }
            }

            if (menorValoresMao.Count > 0)
            {
                int cartaJogar = menorValoresMao.Last<int>();
                Jogo.Jogar(idJogador,senha,cartaJogar);
                this.valorBode = cartaJogar;
                return;
            }
            else
            {
                int cartaJogar = maiorValoresMao.First<int>();
                Jogo.Jogar(idJogador, senha, cartaJogar);
                this.valorBode = cartaJogar;
                return;
            }
        }

        private void btnJogarCarta_Click(object sender, EventArgs e)
        {
            btnImg_Click(sender, e);
            jogarCarta(cartasMesa);
            btnImg_Click(sender, e);
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            ToolBox.Erro("ERRO: " + estadoJogo);
        }

        private void btnEscolherIlha_Click(object sender, EventArgs e)
        {
            string valores = Jogo.VerificarIlha(idJogador, senha);
            if (escolheIlha == true)
            {
                string[] valorIlha = valores.Split(',');
                if (ToolBox.Erro(valores) == false)
                {
                    if (Int32.Parse(valorIlha[0]) > Int32.Parse(valorIlha[1]))
                    {
                        EscolhaIlha(valorIlha[1]);
                    }
                    else
                    {
                        EscolhaIlha(valorIlha[0]);
                    }
                }
            }
        }
    }
}
