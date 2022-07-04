namespace _01_simpleApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Showmassagebutton = new System.Windows.Forms.Button();
            this.massagelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Showmassagebutton
            // 
            this.Showmassagebutton.Location = new System.Drawing.Point(278, 297);
            this.Showmassagebutton.Name = "Showmassagebutton";
            this.Showmassagebutton.Size = new System.Drawing.Size(244, 57);
            this.Showmassagebutton.TabIndex = 0;
            this.Showmassagebutton.Text = "Show Massage";
            this.Showmassagebutton.UseVisualStyleBackColor = true;
            this.Showmassagebutton.Click += new System.EventHandler(this.Showmassagebutton_Click);
            // 
            // massagelabel
            // 
            this.massagelabel.AutoSize = true;
            this.massagelabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.massagelabel.Location = new System.Drawing.Point(191, 55);
            this.massagelabel.Name = "massagelabel";
            this.massagelabel.Size = new System.Drawing.Size(0, 41);
            this.massagelabel.TabIndex = 1;
            this.massagelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.massagelabel);
            this.Controls.Add(this.Showmassagebutton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple C# appliction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Showmassagebutton;
        private Label massagelabel;
    }
}