namespace Zadanie
{
    partial class Form2
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
            LiczbaCalkowita = new Button();
            txtLiczba = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // LiczbaCalkowita
            // 
            LiczbaCalkowita.Location = new Point(415, 213);
            LiczbaCalkowita.Margin = new Padding(3, 4, 3, 4);
            LiczbaCalkowita.Name = "LiczbaCalkowita";
            LiczbaCalkowita.Size = new Size(86, 31);
            LiczbaCalkowita.TabIndex = 0;
            LiczbaCalkowita.Text = "(click)";
            LiczbaCalkowita.UseVisualStyleBackColor = true;
            LiczbaCalkowita.Click += LiczbaCalkowita_Click;
            // 
            // txtLiczba
            // 
            txtLiczba.Location = new Point(399, 140);
            txtLiczba.Margin = new Padding(3, 4, 3, 4);
            txtLiczba.Name = "txtLiczba";
            txtLiczba.Size = new Size(114, 27);
            txtLiczba.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(414, 88);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 2;
            label1.Text = "Podaj liczbę :";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(279, 273);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(370, 184);
            listBox1.TabIndex = 3;
            listBox1.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(txtLiczba);
            Controls.Add(LiczbaCalkowita);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LiczbaCalkowita;
        private TextBox txtLiczba;
        private Label label1;
        private ListBox listBox1;
    }
}