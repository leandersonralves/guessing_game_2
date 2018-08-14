namespace GuessingAnimal2
{
    partial class QuestionAttributeForm
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
            this.yes = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yes
            // 
            this.yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.yes.Location = new System.Drawing.Point(88, 70);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(95, 29);
            this.yes.TabIndex = 0;
            this.yes.Text = "Sim";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // no
            // 
            this.no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.no.Location = new System.Drawing.Point(394, 70);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(95, 29);
            this.no.TabIndex = 1;
            this.no.Text = "Não";
            this.no.UseVisualStyleBackColor = true;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // labelQuestion
            // 
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelQuestion.Location = new System.Drawing.Point(12, 9);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(530, 38);
            this.labelQuestion.TabIndex = 2;
            this.labelQuestion.Text = "O animal ...?";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QuestionAttributeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 111);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Name = "QuestionAttributeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guessing Animal 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yes;
        private System.Windows.Forms.Button no;
        private System.Windows.Forms.Label labelQuestion;
    }
}