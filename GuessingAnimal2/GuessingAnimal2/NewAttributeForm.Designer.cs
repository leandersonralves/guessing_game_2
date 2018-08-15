namespace GuessingAnimal2
{
    partial class NewAttributeForm
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
            this.textBoxNewAttribute = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNewAttribute
            // 
            this.textBoxNewAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxNewAttribute.Location = new System.Drawing.Point(12, 37);
            this.textBoxNewAttribute.Name = "textBoxNewAttribute";
            this.textBoxNewAttribute.Size = new System.Drawing.Size(530, 27);
            this.textBoxNewAttribute.TabIndex = 0;
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ok.Location = new System.Drawing.Point(224, 71);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(95, 29);
            this.ok.TabIndex = 1;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label.Location = new System.Drawing.Point(12, 10);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(530, 26);
            this.label.TabIndex = 2;
            this.label.Text = "Talk about an attribute of this animal ...";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NewAttributeForm
            // 
            this.AcceptButton = this.ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 111);
            this.Controls.Add(this.textBoxNewAttribute);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.label);
            this.Name = "NewAttributeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guessing Animal 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewAttribute;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label label;
    }
}