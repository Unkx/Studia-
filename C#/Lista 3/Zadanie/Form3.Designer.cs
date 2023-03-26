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
            buttonRysuj = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // txtLiczba
            // 
            txtLiczba.Location = new Point(368, 86);
            txtLiczba.Name = "txtLiczba";
            txtLiczba.Size = new Size(100, 23);
            txtLiczba.TabIndex = 0;
            // 
            // buttonRysuj
            // 
            buttonRysuj.Location = new Point(382, 149);
            buttonRysuj.Name = "buttonRysuj";
            buttonRysuj.Size = new Size(75, 23);
            buttonRysuj.TabIndex = 1;
            buttonRysuj.Text = "button";
            buttonRysuj.UseVisualStyleBackColor = true;
            buttonRysuj.Click += buttonPodajLiczbe_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(357, 222);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 2;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(buttonRysuj);
            Controls.Add(txtLiczba);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLiczba;
        private Button buttonRysuj;
        private ListBox listBox1;
    }
}