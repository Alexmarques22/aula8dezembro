namespace aula_8_dezembro
{
    partial class Form2
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
            this.botaolimpa = new System.Windows.Forms.Button();
            this.inputTexto = new System.Windows.Forms.TextBox();
            this.tela = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botaolimpa
            // 
            this.botaolimpa.Location = new System.Drawing.Point(654, 12);
            this.botaolimpa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.botaolimpa.Name = "botaolimpa";
            this.botaolimpa.Size = new System.Drawing.Size(98, 47);
            this.botaolimpa.TabIndex = 0;
            this.botaolimpa.Text = "LIMPAR";
            this.botaolimpa.UseVisualStyleBackColor = true;
            this.botaolimpa.Click += new System.EventHandler(this.botaolimpa_Click);
            // 
            // inputTexto
            // 
            this.inputTexto.Location = new System.Drawing.Point(47, 12);
            this.inputTexto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputTexto.Multiline = true;
            this.inputTexto.Name = "inputTexto";
            this.inputTexto.Size = new System.Drawing.Size(339, 24);
            this.inputTexto.TabIndex = 2;
            this.inputTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // tela
            // 
            this.tela.Location = new System.Drawing.Point(47, 54);
            this.tela.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tela.Multiline = true;
            this.tela.Name = "tela";
            this.tela.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tela.Size = new System.Drawing.Size(600, 384);
            this.tela.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.tela);
            this.Controls.Add(this.inputTexto);
            this.Controls.Add(this.botaolimpa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaolimpa;
        private System.Windows.Forms.TextBox inputTexto;
        private System.Windows.Forms.TextBox tela;
    }
}