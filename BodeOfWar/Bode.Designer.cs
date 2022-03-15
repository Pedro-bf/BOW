
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
            this.lstVezEstado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblJogadorVez
            // 
            this.lblJogadorVez.AutoSize = true;
            this.lblJogadorVez.Location = new System.Drawing.Point(336, 185);
            this.lblJogadorVez.Name = "lblJogadorVez";
            this.lblJogadorVez.Size = new System.Drawing.Size(0, 15);
            this.lblJogadorVez.TabIndex = 23;
            // 
            // lblVerificarVez
            // 
            this.lblVerificarVez.AutoSize = true;
            this.lblVerificarVez.Location = new System.Drawing.Point(303, 185);
            this.lblVerificarVez.Name = "lblVerificarVez";
            this.lblVerificarVez.Size = new System.Drawing.Size(30, 15);
            this.lblVerificarVez.TabIndex = 22;
            this.lblVerificarVez.Text = "Vez:";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(294, 136);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(101, 23);
            this.btnIniciar.TabIndex = 21;
            this.btnIniciar.Text = "Iniciar Partida";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lstVezEstado
            // 
            this.lstVezEstado.FormattingEnabled = true;
            this.lstVezEstado.Location = new System.Drawing.Point(12, 26);
            this.lstVezEstado.Name = "lstVezEstado";
            this.lstVezEstado.Size = new System.Drawing.Size(173, 95);
            this.lstVezEstado.TabIndex = 25;
            // 
            // Bode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 337);
            this.Controls.Add(this.lstVezEstado);
            this.Controls.Add(this.lblJogadorVez);
            this.Controls.Add(this.lblVerificarVez);
            this.Controls.Add(this.btnIniciar);
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
        private System.Windows.Forms.ListBox lstVezEstado;
    }
}