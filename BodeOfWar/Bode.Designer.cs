
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
            this.lblVerificarVez.Location = new System.Drawing.Point(12, 9);
            this.lblVerificarVez.Name = "lblVerificarVez";
            this.lblVerificarVez.Size = new System.Drawing.Size(28, 13);
            this.lblVerificarVez.TabIndex = 22;
            this.lblVerificarVez.Text = "Vez:";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(587, 261);
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
            // Bode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1289, 761);
            this.Controls.Add(this.pnlMao);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.lblHistorico);
            this.Controls.Add(this.txtHistorico);
            this.Controls.Add(this.lblJogadorVez);
            this.Controls.Add(this.lblVerificarVez);
            this.Controls.Add(this.btnIniciar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1305, 800);
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
    }
}