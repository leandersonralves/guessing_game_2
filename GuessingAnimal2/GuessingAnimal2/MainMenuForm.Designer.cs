namespace GuessingAnimal2
{
    partial class MainMenuForm
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
            this.labelMainQuestion = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMainQuestion
            // 
            this.labelMainQuestion.AutoSize = true;
            this.labelMainQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainQuestion.Location = new System.Drawing.Point(156, 24);
            this.labelMainQuestion.Name = "labelMainQuestion";
            this.labelMainQuestion.Size = new System.Drawing.Size(255, 22);
            this.labelMainQuestion.TabIndex = 2;
            this.labelMainQuestion.Text = "Pense em um animal, pensou?";
            this.labelMainQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Location = new System.Drawing.Point(88, 70);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(95, 29);
            this.ok.TabIndex = 0;
            this.ok.Text = "Sim";
            this.ok.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(394, 70);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(95, 29);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // GuessingGame2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 111);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.labelMainQuestion);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(570, 150);
            this.MinimumSize = new System.Drawing.Size(570, 150);
            this.Name = "GuessingGame2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guessing Animal 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMainQuestion;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
    }
}

