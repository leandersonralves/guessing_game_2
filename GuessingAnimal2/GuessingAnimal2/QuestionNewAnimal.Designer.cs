namespace GuessingAnimal2
{
    partial class QuestionNewAnimal
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
            this.label = new System.Windows.Forms.Label();
            this.yes = new System.Windows.Forms.Button();
            this.textBoxNewAnimal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(530, 26);
            this.label.TabIndex = 2;
            this.label.Text = "Qual foi o animal que você pensou?";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // yes
            // 
            this.yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.yes.Location = new System.Drawing.Point(224, 70);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(95, 29);
            this.yes.TabIndex = 1;
            this.yes.Text = "Ok";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // textBoxNewAnimal
            // 
            this.textBoxNewAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxNewAnimal.Location = new System.Drawing.Point(12, 36);
            this.textBoxNewAnimal.Name = "textBoxNewAnimal";
            this.textBoxNewAnimal.Size = new System.Drawing.Size(530, 27);
            this.textBoxNewAnimal.TabIndex = 3;
            // 
            // QuestionNewAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 111);
            this.Controls.Add(this.textBoxNewAnimal);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.label);
            this.Name = "QuestionNewAnimal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Guessing Animal 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button yes;
        private System.Windows.Forms.TextBox textBoxNewAnimal;
    }
}