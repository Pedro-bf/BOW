
namespace BodeOfWar
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPartida = new System.Windows.Forms.Button();
            this.lstPartida = new System.Windows.Forms.ListBox();
            this.btnExibirPartidade = new System.Windows.Forms.Button();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.lblJogadores = new System.Windows.Forms.Label();
            this.txtJogadores = new System.Windows.Forms.TextBox();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.lblSenhaPartida = new System.Windows.Forms.Label();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.lblVersao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPartida
            // 
            this.btnPartida.Location = new System.Drawing.Point(273, 178);
            this.btnPartida.Name = "btnPartida";
            this.btnPartida.Size = new System.Drawing.Size(94, 23);
            this.btnPartida.TabIndex = 0;
            this.btnPartida.Text = "Listar Partidas";
            this.btnPartida.UseVisualStyleBackColor = true;
            this.btnPartida.Click += new System.EventHandler(this.btnPartida_Click);
            // 
            // lstPartida
            // 
            this.lstPartida.FormattingEnabled = true;
            this.lstPartida.Location = new System.Drawing.Point(168, 12);
            this.lstPartida.Name = "lstPartida";
            this.lstPartida.Size = new System.Drawing.Size(199, 160);
            this.lstPartida.TabIndex = 1;
            // 
            // btnExibirPartidade
            // 
            this.btnExibirPartidade.Location = new System.Drawing.Point(438, 99);
            this.btnExibirPartidade.Name = "btnExibirPartidade";
            this.btnExibirPartidade.Size = new System.Drawing.Size(75, 23);
            this.btnExibirPartidade.TabIndex = 2;
            this.btnExibirPartidade.Text = "Exibir";
            this.btnExibirPartidade.UseVisualStyleBackColor = true;
            this.btnExibirPartidade.Click += new System.EventHandler(this.btnExibirPartidade_Click);
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Location = new System.Drawing.Point(438, 16);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.ReadOnly = true;
            this.txtIdPartida.Size = new System.Drawing.Size(60, 20);
            this.txtIdPartida.TabIndex = 3;
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Location = new System.Drawing.Point(411, 19);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(21, 13);
            this.lblIdPartida.TabIndex = 4;
            this.lblIdPartida.Text = "ID:";
            // 
            // lblJogadores
            // 
            this.lblJogadores.AutoSize = true;
            this.lblJogadores.Location = new System.Drawing.Point(373, 46);
            this.lblJogadores.Name = "lblJogadores";
            this.lblJogadores.Size = new System.Drawing.Size(59, 13);
            this.lblJogadores.TabIndex = 5;
            this.lblJogadores.Text = "Jogadores:";
            // 
            // txtJogadores
            // 
            this.txtJogadores.Location = new System.Drawing.Point(438, 42);
            this.txtJogadores.Multiline = true;
            this.txtJogadores.Name = "txtJogadores";
            this.txtJogadores.ReadOnly = true;
            this.txtJogadores.Size = new System.Drawing.Size(91, 51);
            this.txtJogadores.TabIndex = 6;
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(49, 12);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(100, 20);
            this.txtNomePartida.TabIndex = 7;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Location = new System.Drawing.Point(5, 16);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(38, 13);
            this.lblNomePartida.TabIndex = 8;
            this.lblNomePartida.Text = "Nome:";
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.Location = new System.Drawing.Point(2, 41);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaPartida.TabIndex = 9;
            this.lblSenhaPartida.Text = "Senha:";
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(49, 38);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaPartida.TabIndex = 10;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(49, 65);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(75, 23);
            this.btnCriarPartida.TabIndex = 11;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(12, 212);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(35, 13);
            this.lblVersao.TabIndex = 12;
            this.lblVersao.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 234);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.lblSenhaPartida);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.txtJogadores);
            this.Controls.Add(this.lblJogadores);
            this.Controls.Add(this.lblIdPartida);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.btnExibirPartidade);
            this.Controls.Add(this.lstPartida);
            this.Controls.Add(this.btnPartida);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "BodeOfWar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPartida;
        private System.Windows.Forms.ListBox lstPartida;
        private System.Windows.Forms.Button btnExibirPartidade;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.Label lblIdPartida;
        private System.Windows.Forms.Label lblJogadores;
        private System.Windows.Forms.TextBox txtJogadores;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label lblSenhaPartida;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label lblVersao;
    }
}

