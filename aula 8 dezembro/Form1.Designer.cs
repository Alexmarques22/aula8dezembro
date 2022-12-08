namespace aula_8_dezembro
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
            this.pergunta = new System.Windows.Forms.TextBox();
            this.digitar = new System.Windows.Forms.Label();
            this.resposta = new System.Windows.Forms.Label();
            this.botaoenviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pergunta
            // 
            this.pergunta.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pergunta.Location = new System.Drawing.Point(331, 182);
            this.pergunta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pergunta.Multiline = true;
            this.pergunta.Name = "pergunta";
            this.pergunta.Size = new System.Drawing.Size(319, 22);
            this.pergunta.TabIndex = 0;
            // 
            // digitar
            // 
            this.digitar.AutoSize = true;
            this.digitar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.digitar.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitar.ForeColor = System.Drawing.Color.White;
            this.digitar.Location = new System.Drawing.Point(327, 143);
            this.digitar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.digitar.Name = "digitar";
            this.digitar.Size = new System.Drawing.Size(173, 23);
            this.digitar.TabIndex = 1;
            this.digitar.Text = "digite um nome:";
            // 
            // resposta
            // 
            this.resposta.AutoSize = true;
            this.resposta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resposta.Font = new System.Drawing.Font("Lucida Bright", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resposta.ForeColor = System.Drawing.Color.White;
            this.resposta.Location = new System.Drawing.Point(327, 294);
            this.resposta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resposta.Name = "resposta";
            this.resposta.Size = new System.Drawing.Size(225, 24);
            this.resposta.TabIndex = 2;
            this.resposta.Text = "o nome digitado foi:";
            // 
            // botaoenviar
            // 
            this.botaoenviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoenviar.Location = new System.Drawing.Point(331, 210);
            this.botaoenviar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.botaoenviar.Name = "botaoenviar";
            this.botaoenviar.Size = new System.Drawing.Size(100, 46);
            this.botaoenviar.TabIndex = 3;
            this.botaoenviar.Text = "enviar";
            this.botaoenviar.UseVisualStyleBackColor = true;
            this.botaoenviar.Click += new System.EventHandler(this.botaoenviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1067, 519);
            this.Controls.Add(this.botaoenviar);
            this.Controls.Add(this.resposta);
            this.Controls.Add(this.digitar);
            this.Controls.Add(this.pergunta);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pergunta;
        private System.Windows.Forms.Label digitar;
        private System.Windows.Forms.Label resposta;
        private System.Windows.Forms.Button botaoenviar;
    }
}

