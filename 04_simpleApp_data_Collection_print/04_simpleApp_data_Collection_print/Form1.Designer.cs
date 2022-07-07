namespace _04_simpleApp_data_Collection_print
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
            this.Age = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.CountrycomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.NoclaimdiscountYesradioButton = new System.Windows.Forms.RadioButton();
            this.NoclaimdiscountNoradioButton = new System.Windows.Forms.RadioButton();
            this.permiuminsuranceYesradioButton = new System.Windows.Forms.RadioButton();
            this.permiuminsuranceNoradioButton4 = new System.Windows.Forms.RadioButton();
            this.sickcoverYesradioButton = new System.Windows.Forms.RadioButton();
            this.sickcoverNoradioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalpermiumlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(124, 47);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(36, 20);
            this.Age.TabIndex = 0;
            this.Age.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "No claim discount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Permium insurance";
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(195, 40);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(115, 27);
            this.AgeBox.TabIndex = 4;
            this.AgeBox.TextChanged += new System.EventHandler(this.AgeBox_TextChanged);
            // 
            // CountrycomboBox
            // 
            this.CountrycomboBox.FormattingEnabled = true;
            this.CountrycomboBox.Items.AddRange(new object[] {
            "Pakistan ",
            "india",
            "turkey",
            "afghastan"});
            this.CountrycomboBox.Location = new System.Drawing.Point(195, 109);
            this.CountrycomboBox.Name = "CountrycomboBox";
            this.CountrycomboBox.Size = new System.Drawing.Size(151, 28);
            this.CountrycomboBox.TabIndex = 6;
            this.CountrycomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "sick conver";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(0, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 24);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // NoclaimdiscountYesradioButton
            // 
            this.NoclaimdiscountYesradioButton.AutoSize = true;
            this.NoclaimdiscountYesradioButton.Location = new System.Drawing.Point(47, 13);
            this.NoclaimdiscountYesradioButton.Name = "NoclaimdiscountYesradioButton";
            this.NoclaimdiscountYesradioButton.Size = new System.Drawing.Size(51, 24);
            this.NoclaimdiscountYesradioButton.TabIndex = 9;
            this.NoclaimdiscountYesradioButton.TabStop = true;
            this.NoclaimdiscountYesradioButton.Text = "Yes";
            this.NoclaimdiscountYesradioButton.UseVisualStyleBackColor = true;
            // 
            // NoclaimdiscountNoradioButton
            // 
            this.NoclaimdiscountNoradioButton.AutoSize = true;
            this.NoclaimdiscountNoradioButton.Location = new System.Drawing.Point(138, 21);
            this.NoclaimdiscountNoradioButton.Name = "NoclaimdiscountNoradioButton";
            this.NoclaimdiscountNoradioButton.Size = new System.Drawing.Size(50, 24);
            this.NoclaimdiscountNoradioButton.TabIndex = 10;
            this.NoclaimdiscountNoradioButton.TabStop = true;
            this.NoclaimdiscountNoradioButton.Text = "No";
            this.NoclaimdiscountNoradioButton.UseVisualStyleBackColor = true;
            // 
            // permiuminsuranceYesradioButton
            // 
            this.permiuminsuranceYesradioButton.AutoSize = true;
            this.permiuminsuranceYesradioButton.Location = new System.Drawing.Point(45, 19);
            this.permiuminsuranceYesradioButton.Name = "permiuminsuranceYesradioButton";
            this.permiuminsuranceYesradioButton.Size = new System.Drawing.Size(51, 24);
            this.permiuminsuranceYesradioButton.TabIndex = 11;
            this.permiuminsuranceYesradioButton.TabStop = true;
            this.permiuminsuranceYesradioButton.Text = "Yes";
            this.permiuminsuranceYesradioButton.UseVisualStyleBackColor = true;
            // 
            // permiuminsuranceNoradioButton4
            // 
            this.permiuminsuranceNoradioButton4.AutoSize = true;
            this.permiuminsuranceNoradioButton4.Location = new System.Drawing.Point(138, 21);
            this.permiuminsuranceNoradioButton4.Name = "permiuminsuranceNoradioButton4";
            this.permiuminsuranceNoradioButton4.Size = new System.Drawing.Size(50, 24);
            this.permiuminsuranceNoradioButton4.TabIndex = 12;
            this.permiuminsuranceNoradioButton4.TabStop = true;
            this.permiuminsuranceNoradioButton4.Text = "No";
            this.permiuminsuranceNoradioButton4.UseVisualStyleBackColor = true;
            // 
            // sickcoverYesradioButton
            // 
            this.sickcoverYesradioButton.AutoSize = true;
            this.sickcoverYesradioButton.Location = new System.Drawing.Point(45, 3);
            this.sickcoverYesradioButton.Name = "sickcoverYesradioButton";
            this.sickcoverYesradioButton.Size = new System.Drawing.Size(51, 24);
            this.sickcoverYesradioButton.TabIndex = 13;
            this.sickcoverYesradioButton.TabStop = true;
            this.sickcoverYesradioButton.Text = "Yes";
            this.sickcoverYesradioButton.UseVisualStyleBackColor = true;
            // 
            // sickcoverNoradioButton
            // 
            this.sickcoverNoradioButton.AutoSize = true;
            this.sickcoverNoradioButton.Location = new System.Drawing.Point(138, 12);
            this.sickcoverNoradioButton.Name = "sickcoverNoradioButton";
            this.sickcoverNoradioButton.Size = new System.Drawing.Size(50, 24);
            this.sickcoverNoradioButton.TabIndex = 14;
            this.sickcoverNoradioButton.TabStop = true;
            this.sickcoverNoradioButton.Text = "No";
            this.sickcoverNoradioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Calculate Insurance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 29);
            this.button2.TabIndex = 16;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalpermiumlabel);
            this.groupBox1.Location = new System.Drawing.Point(476, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 176);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculate Your Permium Insurance";
            // 
            // totalpermiumlabel
            // 
            this.totalpermiumlabel.AutoSize = true;
            this.totalpermiumlabel.Location = new System.Drawing.Point(83, 62);
            this.totalpermiumlabel.Name = "totalpermiumlabel";
            this.totalpermiumlabel.Size = new System.Drawing.Size(50, 20);
            this.totalpermiumlabel.TabIndex = 0;
            this.totalpermiumlabel.Text = "label5";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.permiuminsuranceYesradioButton);
            this.panel1.Controls.Add(this.permiuminsuranceNoradioButton4);
            this.panel1.Location = new System.Drawing.Point(178, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 51);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NoclaimdiscountYesradioButton);
            this.panel2.Controls.Add(this.NoclaimdiscountNoradioButton);
            this.panel2.Location = new System.Drawing.Point(178, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 48);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.sickcoverYesradioButton);
            this.panel3.Controls.Add(this.sickcoverNoradioButton);
            this.panel3.Location = new System.Drawing.Point(178, 293);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 39);
            this.panel3.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountrycomboBox);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Age);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Age;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox AgeBox;
        private ComboBox CountrycomboBox;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton NoclaimdiscountYesradioButton;
        private RadioButton NoclaimdiscountNoradioButton;
        private RadioButton permiuminsuranceYesradioButton;
        private RadioButton permiuminsuranceNoradioButton4;
        private RadioButton sickcoverYesradioButton;
        private RadioButton sickcoverNoradioButton;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label totalpermiumlabel;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}