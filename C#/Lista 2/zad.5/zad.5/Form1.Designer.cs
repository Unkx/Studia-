namespace zad._5
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
            txtLiczba = new TextBox();
            buttonLiczba = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtLiczba
            // 
            txtLiczba.Location = new Point(384, 195);
            txtLiczba.Margin = new Padding(3, 4, 3, 4);
            txtLiczba.Name = "txtLiczba";
            txtLiczba.Size = new Size(114, 27);
            txtLiczba.TabIndex = 0;
            // 
            // buttonLiczba
            // 
            buttonLiczba.Location = new Point(393, 267);
            buttonLiczba.Margin = new Padding(3, 4, 3, 4);
            buttonLiczba.Name = "buttonLiczba";
            buttonLiczba.Size = new Size(86, 31);
            buttonLiczba.TabIndex = 1;
            buttonLiczba.Text = "(click)";
            buttonLiczba.UseVisualStyleBackColor = true;
            buttonLiczba.Click += buttonLiczba_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(393, 144);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 2;
            label1.Text = "Podaj liczbę :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(buttonLiczba);
            Controls.Add(txtLiczba);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLiczba;
        private Button buttonLiczba;
        private Label label1;
    }
}