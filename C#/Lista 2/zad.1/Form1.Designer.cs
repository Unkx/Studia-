namespace zad1
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
        public Form1()
        {
            InitializeComponent();
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBok = new TextBox();
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            lblPole = new TextBox();
            lblObjetosc = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtBok
            // 
            txtBok.Location = new Point(313, 86);
            txtBok.Margin = new Padding(3, 2, 3, 2);
            txtBok.Name = "txtBok";
            txtBok.Size = new Size(110, 23);
            txtBok.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 53);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 1;
            label1.Text = "Bok sześciokąta :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 208);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 3;
            label3.Text = "Pole sześciokonta :";
            // 
            // button1
            // 
            button1.Location = new Point(322, 133);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(95, 22);
            button1.TabIndex = 4;
            button1.Text = "(click)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblPole
            // 
            lblPole.Location = new Point(194, 244);
            lblPole.Margin = new Padding(3, 2, 3, 2);
            lblPole.Name = "lblPole";
            lblPole.Size = new Size(110, 23);
            lblPole.TabIndex = 5;
            // 
            // lblObjetosc
            // 
            lblObjetosc.Location = new Point(463, 244);
            lblObjetosc.Margin = new Padding(3, 2, 3, 2);
            lblObjetosc.Name = "lblObjetosc";
            lblObjetosc.Size = new Size(110, 23);
            lblObjetosc.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(452, 208);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 7;
            label2.Text = "Objętość Sześciokonta :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label2);
            Controls.Add(lblObjetosc);
            Controls.Add(lblPole);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtBok);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBok;
        private Label label1;
        private Label label3;
        private Button button1;
        private TextBox lblPole;
        private TextBox lblObjetosc;
        private Label label2;
    }
}