namespace WinFormsApp1
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
            button1 = new Button();
            txtLiczba1 = new TextBox();
            txtLiczba2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lblWynik = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(359, 149);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "(click)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txtLiczba1
            // 
            txtLiczba1.Location = new Point(266, 101);
            txtLiczba1.Name = "txtLiczba1";
            txtLiczba1.Size = new Size(100, 23);
            txtLiczba1.TabIndex = 3;
            // 
            // txtLiczba2
            // 
            txtLiczba2.Location = new Point(472, 101);
            txtLiczba2.Name = "txtLiczba2";
            txtLiczba2.Size = new Size(100, 23);
            txtLiczba2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 68);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 6;
            label2.Text = "Liczba 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(492, 68);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 7;
            label3.Text = "Liczba 2:";
            // 
            // lblWynik
            // 
            lblWynik.Location = new Point(343, 257);
            lblWynik.Name = "lblWynik";
            lblWynik.Size = new Size(100, 23);
            lblWynik.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 219);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 11;
            label4.Text = "Wynik if/else :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(lblWynik);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtLiczba2);
            Controls.Add(txtLiczba1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtLiczba1;
        private TextBox txtLiczba2;
        private Label label2;
        private Label label3;
        private TextBox lblWynik;
        private Label label4;
    }
}