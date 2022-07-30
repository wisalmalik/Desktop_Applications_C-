namespace _18_SimpleApp_Move_cursor_toNextBox
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
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AgetextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MaleradioButton = new System.Windows.Forms.RadioButton();
            this.femaleradioButton = new System.Windows.Forms.RadioButton();
            this.Savebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(203, 37);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(187, 27);
            this.NametextBox.TabIndex = 0;
            this.NametextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.NametextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Enter_key);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(203, 118);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(187, 27);
            this.EmailtextBox.TabIndex = 1;
            this.EmailtextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.EmailtextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Enter_key);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // AgetextBox
            // 
            this.AgetextBox.Location = new System.Drawing.Point(203, 202);
            this.AgetextBox.Name = "AgetextBox";
            this.AgetextBox.Size = new System.Drawing.Size(187, 27);
            this.AgetextBox.TabIndex = 2;
            this.AgetextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.AgetextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Enter_key);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gender:";
            // 
            // MaleradioButton
            // 
            this.MaleradioButton.AutoSize = true;
            this.MaleradioButton.Location = new System.Drawing.Point(203, 292);
            this.MaleradioButton.Name = "MaleradioButton";
            this.MaleradioButton.Size = new System.Drawing.Size(63, 24);
            this.MaleradioButton.TabIndex = 3;
            this.MaleradioButton.TabStop = true;
            this.MaleradioButton.Text = "Male";
            this.MaleradioButton.UseVisualStyleBackColor = true;
            this.MaleradioButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Enter_key);
            // 
            // femaleradioButton
            // 
            this.femaleradioButton.AutoSize = true;
            this.femaleradioButton.Location = new System.Drawing.Point(312, 292);
            this.femaleradioButton.Name = "femaleradioButton";
            this.femaleradioButton.Size = new System.Drawing.Size(78, 24);
            this.femaleradioButton.TabIndex = 4;
            this.femaleradioButton.TabStop = true;
            this.femaleradioButton.Text = "Female";
            this.femaleradioButton.UseVisualStyleBackColor = true;
            this.femaleradioButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Enter_key);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(230, 369);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(114, 34);
            this.Savebutton.TabIndex = 5;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Enter_key);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 433);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.femaleradioButton);
            this.Controls.Add(this.MaleradioButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgetextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.NametextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NametextBox;
        private Label label1;
        private TextBox EmailtextBox;
        private Label label2;
        private TextBox AgetextBox;
        private Label label3;
        private Label label4;
        private RadioButton MaleradioButton;
        private RadioButton femaleradioButton;
        private Button Savebutton;
    }
}