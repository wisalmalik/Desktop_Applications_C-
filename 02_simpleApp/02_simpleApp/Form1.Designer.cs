namespace _02_simpleApp
{
    partial class MainForm
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
            this.FirstNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SecondNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Resulttextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SubtractionRadioButton = new System.Windows.Forms.RadioButton();
            this.AddationRadionButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNumber
            // 
            this.FirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNumber.Location = new System.Drawing.Point(197, 45);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(238, 32);
            this.FirstNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "FIrst Number:";
            // 
            // SecondNumber
            // 
            this.SecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondNumber.Location = new System.Drawing.Point(197, 151);
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(238, 32);
            this.SecondNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(11, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number:";
            // 
            // Resulttextbox
            // 
            this.Resulttextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resulttextbox.Location = new System.Drawing.Point(197, 292);
            this.Resulttextbox.Name = "Resulttextbox";
            this.Resulttextbox.ReadOnly = true;
            this.Resulttextbox.Size = new System.Drawing.Size(238, 32);
            this.Resulttextbox.TabIndex = 999;
            this.Resulttextbox.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(279, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "=";
            // 
            // CalculateButton
            // 
            this.CalculateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CalculateButton.Location = new System.Drawing.Point(46, 381);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(104, 40);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "&Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearButton.Location = new System.Drawing.Point(374, 381);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(104, 40);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "C&lear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SubtractionRadioButton);
            this.groupBox1.Controls.Add(this.AddationRadionButton);
            this.groupBox1.Location = new System.Drawing.Point(526, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 152);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arthamtic Operation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SubtractionRadioButton
            // 
            this.SubtractionRadioButton.AutoSize = true;
            this.SubtractionRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubtractionRadioButton.Location = new System.Drawing.Point(52, 89);
            this.SubtractionRadioButton.Name = "SubtractionRadioButton";
            this.SubtractionRadioButton.Size = new System.Drawing.Size(95, 20);
            this.SubtractionRadioButton.TabIndex = 3;
            this.SubtractionRadioButton.Text = "Subtraction";
            this.SubtractionRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddationRadionButton
            // 
            this.AddationRadionButton.AutoSize = true;
            this.AddationRadionButton.Checked = true;
            this.AddationRadionButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddationRadionButton.Location = new System.Drawing.Point(52, 37);
            this.AddationRadionButton.Name = "AddationRadionButton";
            this.AddationRadionButton.Size = new System.Drawing.Size(82, 20);
            this.AddationRadionButton.TabIndex = 2;
            this.AddationRadionButton.TabStop = true;
            this.AddationRadionButton.Text = "Addation";
            this.AddationRadionButton.UseVisualStyleBackColor = true;
            this.AddationRadionButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resulttextbox);
            this.Controls.Add(this.SecondNumber);
            this.Controls.Add(this.FirstNumber);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.Text = "IfElseStatment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SecondNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Resulttextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SubtractionRadioButton;
        private System.Windows.Forms.RadioButton AddationRadionButton;
    }
}

