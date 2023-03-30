namespace Zadanie
{
    partial class Form3
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
            txtLiczba = new TextBox();
            buttonPodajLiczbe = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtLiczba
            // 
            txtLiczba.Location = new Point(421, 115);
            txtLiczba.Margin = new Padding(3, 4, 3, 4);
            txtLiczba.Name = "txtLiczba";
            txtLiczba.Size = new Size(114, 27);
            txtLiczba.TabIndex = 0;
            // 
            // buttonPodajLiczbe
            // 
            buttonPodajLiczbe.Location = new Point(437, 199);
            buttonPodajLiczbe.Margin = new Padding(3, 4, 3, 4);
            buttonPodajLiczbe.Name = "buttonPodajLiczbe";
            buttonPodajLiczbe.Size = new Size(86, 31);
            buttonPodajLiczbe.TabIndex = 1;
            buttonPodajLiczbe.Text = "button";
            buttonPodajLiczbe.UseVisualStyleBackColor = true;
            buttonPodajLiczbe.Click += buttonPodajLiczbe_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(371, 271);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(225, 204);
            listBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(427, 77);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 3;
            label1.Text = "Podaj liczbę :";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(buttonPodajLiczbe);
            Controls.Add(txtLiczba);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLiczba;
        private Button buttonPodajLiczbe;
        private ListBox listBox1;
        private Label label1;
    }
}