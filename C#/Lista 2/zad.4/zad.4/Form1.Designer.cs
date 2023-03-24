namespace zad._4
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



        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonLiczba = new Button();
            txtPodajLiczbe = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonLiczba
            // 
            buttonLiczba.Location = new Point(373, 216);
            buttonLiczba.Margin = new Padding(3, 4, 3, 4);
            buttonLiczba.Name = "buttonLiczba";
            buttonLiczba.Size = new Size(110, 31);
            buttonLiczba.TabIndex = 0;
            buttonLiczba.Text = "(click)";
            buttonLiczba.UseVisualStyleBackColor = true;
            buttonLiczba.Click += buttonLiczba_Click;
            // 
            // txtPodajLiczbe
            // 
            txtPodajLiczbe.Location = new Point(373, 159);
            txtPodajLiczbe.Margin = new Padding(3, 4, 3, 4);
            txtPodajLiczbe.Name = "txtPodajLiczbe";
            txtPodajLiczbe.Size = new Size(114, 27);
            txtPodajLiczbe.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(388, 115);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 3;
            label1.Text = "Podaj liczby :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(txtPodajLiczbe);
            Controls.Add(buttonLiczba);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button buttonLiczba;
        private TextBox txtPodajLiczbe;
        private TextBox txtWynik;
        private Label label1;
        private Label label2;
    }
}