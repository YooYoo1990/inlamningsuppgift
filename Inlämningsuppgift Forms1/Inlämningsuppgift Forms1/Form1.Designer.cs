namespace Inlämningsuppgift_Forms1
{
    partial class Form1
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
            this.Gissa = new System.Windows.Forms.Button();
            this.Meddelande = new System.Windows.Forms.Label();
            this.gissningBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Gissa
            // 
            this.Gissa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Gissa.Location = new System.Drawing.Point(222, 176);
            this.Gissa.Name = "Gissa";
            this.Gissa.Size = new System.Drawing.Size(75, 37);
            this.Gissa.TabIndex = 0;
            this.Gissa.Text = "Gissa!";
            this.Gissa.UseVisualStyleBackColor = true;
            this.Gissa.Click += new System.EventHandler(this.Gissa_Click);
            // 
            // Meddelande
            // 
            this.Meddelande.AutoSize = true;
            this.Meddelande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Meddelande.Location = new System.Drawing.Point(163, 258);
            this.Meddelande.Name = "Meddelande";
            this.Meddelande.Size = new System.Drawing.Size(97, 20);
            this.Meddelande.TabIndex = 1;
            this.Meddelande.Text = "Meddelande";
            // 
            // gissningBox
            // 
            this.gissningBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gissningBox.Location = new System.Drawing.Point(167, 87);
            this.gissningBox.Name = "gissningBox";
            this.gissningBox.Size = new System.Drawing.Size(189, 26);
            this.gissningBox.TabIndex = 2;
            this.gissningBox.Text = "Skriv ett tal mellan 1 - 100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.gissningBox);
            this.Controls.Add(this.Meddelande);
            this.Controls.Add(this.Gissa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Gissa;
        private System.Windows.Forms.Label Meddelande;
        private System.Windows.Forms.TextBox gissningBox;
    }
}

