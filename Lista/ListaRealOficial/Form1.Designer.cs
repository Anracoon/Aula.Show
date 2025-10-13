namespace ListaRealOficial
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
            this.label1 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.botão = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe item novo:";
            // 
            // lista
            // 
            this.lista.BackColor = System.Drawing.SystemColors.Info;
            this.lista.Location = new System.Drawing.Point(77, 91);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(165, 20);
            this.lista.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Info;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(107, 145);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(184, 229);
            this.checkedListBox1.TabIndex = 2;
            // 
            // botão
            // 
            this.botão.BackColor = System.Drawing.Color.NavajoWhite;
            this.botão.ForeColor = System.Drawing.Color.DarkRed;
            this.botão.Location = new System.Drawing.Point(248, 89);
            this.botão.Name = "botão";
            this.botão.Size = new System.Drawing.Size(75, 23);
            this.botão.TabIndex = 3;
            this.botão.Text = "ADICIONAR";
            this.botão.UseVisualStyleBackColor = false;
            this.botão.Click += new System.EventHandler(this.button1_Click);
            // 
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ListaRealOficial.Properties.Resources._0958e43a84e452b6d813da2cd2c33d3f;
            this.ClientSize = new System.Drawing.Size(340, 398);

            this.Controls.Add(this.botão);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lista;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button botão;
    }
}

