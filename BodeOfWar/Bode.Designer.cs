
namespace BodeOfWar
{
    partial class Bode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblJogadorVez = new System.Windows.Forms.Label();
            this.lblVerificarVez = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.btnImg = new System.Windows.Forms.Button();
            this.pnlMao = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtEscolha = new System.Windows.Forms.TextBox();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.lblEscolherIlha = new System.Windows.Forms.Label();
            this.lblIlha = new System.Windows.Forms.Label();
            this.lblValorIlha = new System.Windows.Forms.Label();
            this.lblQtdBodes = new System.Windows.Forms.Label();
            this.lblBodes = new System.Windows.Forms.Label();
            this.pnlMesa = new System.Windows.Forms.Panel();
            this.btnJogarCarta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJogadorVez
            // 
            this.lblJogadorVez.AutoSize = true;
            this.lblJogadorVez.Location = new System.Drawing.Point(45, 9);
            this.lblJogadorVez.Name = "lblJogadorVez";
            this.lblJogadorVez.Size = new System.Drawing.Size(0, 13);
            this.lblJogadorVez.TabIndex = 23;
            // 
            // lblVerificarVez
            // 
            this.lblVerificarVez.AutoSize = true;
            this.lblVerificarVez.BackColor = System.Drawing.Color.Transparent;
            this.lblVerificarVez.Location = new System.Drawing.Point(12, 9);
            this.lblVerificarVez.Name = "lblVerificarVez";
            this.lblVerificarVez.Size = new System.Drawing.Size(28, 13);
            this.lblVerificarVez.TabIndex = 22;
            this.lblVerificarVez.Text = "Vez:";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(48, 418);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(101, 23);
            this.btnIniciar.TabIndex = 21;
            this.btnIniciar.Text = "Iniciar Partida";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtHistorico
            // 
            this.txtHistorico.Location = new System.Drawing.Point(12, 611);
            this.txtHistorico.Multiline = true;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.ReadOnly = true;
            this.txtHistorico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistorico.Size = new System.Drawing.Size(205, 138);
            this.txtHistorico.TabIndex = 26;
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Location = new System.Drawing.Point(9, 595);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(48, 13);
            this.lblHistorico.TabIndex = 27;
            this.lblHistorico.Text = "Historico";
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(223, 522);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(75, 23);
            this.btnImg.TabIndex = 29;
            this.btnImg.Text = "IMG";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // pnlMao
            // 
            this.pnlMao.Location = new System.Drawing.Point(223, 551);
            this.pnlMao.Name = "pnlMao";
            this.pnlMao.Size = new System.Drawing.Size(1037, 198);
            this.pnlMao.TabIndex = 30;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(97, 365);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 31;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtEscolha
            // 
            this.txtEscolha.Location = new System.Drawing.Point(72, 339);
            this.txtEscolha.Name = "txtEscolha";
            this.txtEscolha.Size = new System.Drawing.Size(100, 20);
            this.txtEscolha.TabIndex = 32;
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Location = new System.Drawing.Point(15, 339);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(45, 13);
            this.lblEscolha.TabIndex = 33;
            this.lblEscolha.Text = "Escolha";
            // 
            // lblEscolherIlha
            // 
            this.lblEscolherIlha.AutoSize = true;
            this.lblEscolherIlha.Location = new System.Drawing.Point(69, 305);
            this.lblEscolherIlha.Name = "lblEscolherIlha";
            this.lblEscolherIlha.Size = new System.Drawing.Size(68, 13);
            this.lblEscolherIlha.TabIndex = 34;
            this.lblEscolherIlha.Text = "Escolher Ilha";
            // 
            // lblIlha
            // 
            this.lblIlha.AutoSize = true;
            this.lblIlha.Location = new System.Drawing.Point(12, 48);
            this.lblIlha.Name = "lblIlha";
            this.lblIlha.Size = new System.Drawing.Size(30, 13);
            this.lblIlha.TabIndex = 35;
            this.lblIlha.Text = "Ilha: ";
            // 
            // lblValorIlha
            // 
            this.lblValorIlha.AutoSize = true;
            this.lblValorIlha.Location = new System.Drawing.Point(45, 48);
            this.lblValorIlha.Name = "lblValorIlha";
            this.lblValorIlha.Size = new System.Drawing.Size(13, 13);
            this.lblValorIlha.TabIndex = 36;
            this.lblValorIlha.Text = "0";
            // 
            // lblQtdBodes
            // 
            this.lblQtdBodes.AutoSize = true;
            this.lblQtdBodes.Location = new System.Drawing.Point(204, 48);
            this.lblQtdBodes.Name = "lblQtdBodes";
            this.lblQtdBodes.Size = new System.Drawing.Size(13, 13);
            this.lblQtdBodes.TabIndex = 38;
            this.lblQtdBodes.Text = "0";
            // 
            // lblBodes
            // 
            this.lblBodes.AutoSize = true;
            this.lblBodes.Location = new System.Drawing.Point(88, 48);
            this.lblBodes.Name = "lblBodes";
            this.lblBodes.Size = new System.Drawing.Size(116, 13);
            this.lblBodes.TabIndex = 37;
            this.lblBodes.Text = "Quantidade de Bodes: ";
            // 
            // pnlMesa
            // 
            this.pnlMesa.Location = new System.Drawing.Point(373, 81);
            this.pnlMesa.Name = "pnlMesa";
            this.pnlMesa.Size = new System.Drawing.Size(639, 436);
            this.pnlMesa.TabIndex = 31;
            // 
            // btnJogarCarta
            // 
            this.btnJogarCarta.Location = new System.Drawing.Point(304, 522);
            this.btnJogarCarta.Name = "btnJogarCarta";
            this.btnJogarCarta.Size = new System.Drawing.Size(75, 23);
            this.btnJogarCarta.TabIndex = 39;
            this.btnJogarCarta.Text = "Jogar";
            this.btnJogarCarta.UseVisualStyleBackColor = true;
            this.btnJogarCarta.Click += new System.EventHandler(this.btnJogarCarta_Click);
            // 
            // Bode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1289, 759);
            this.Controls.Add(this.btnJogarCarta);
            this.Controls.Add(this.pnlMesa);
            this.Controls.Add(this.lblQtdBodes);
            this.Controls.Add(this.lblBodes);
            this.Controls.Add(this.lblValorIlha);
            this.Controls.Add(this.lblIlha);
            this.Controls.Add(this.lblEscolherIlha);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.txtEscolha);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.pnlMao);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.lblHistorico);
            this.Controls.Add(this.txtHistorico);
            this.Controls.Add(this.lblJogadorVez);
            this.Controls.Add(this.lblVerificarVez);
            this.Controls.Add(this.btnIniciar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1305, 800);
            this.Name = "Bode";
            this.Text = "Bode";
            this.Load += new System.EventHandler(this.Bode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJogadorVez;
        private System.Windows.Forms.Label lblVerificarVez;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Panel pnlMao;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtEscolha;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.Label lblEscolherIlha;
        private System.Windows.Forms.Label lblIlha;
        private System.Windows.Forms.Label lblValorIlha;
        private System.Windows.Forms.Label lblQtdBodes;
        private System.Windows.Forms.Label lblBodes;
        private System.Windows.Forms.Panel pnlMesa;
        private System.Windows.Forms.Button btnJogarCarta;
    }
}