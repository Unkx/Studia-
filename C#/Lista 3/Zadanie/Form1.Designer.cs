namespace Zadanie
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
            label1 = new Label();
            label2 = new Label();
            txtImie = new TextBox();
            txtNazwisko = new TextBox();
            buttonZatwierdz = new Button();
            Button1 = new Button();
            Button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(354, 50);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Login ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 124);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "Hasło :";
            // 
            // txtImie
            // 
            txtImie.Location = new Point(317, 80);
            txtImie.Margin = new Padding(3, 2, 3, 2);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(110, 23);
            txtImie.TabIndex = 1;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(317, 164);
            txtNazwisko.Margin = new Padding(3, 2, 3, 2);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(110, 23);
            txtNazwisko.TabIndex = 1;
            // 
            // buttonZatwierdz
            // 
            buttonZatwierdz.Location = new Point(253, 218);
            buttonZatwierdz.Margin = new Padding(3, 2, 3, 2);
            buttonZatwierdz.Name = "buttonZatwierdz";
            buttonZatwierdz.Size = new Size(226, 22);
            buttonZatwierdz.TabIndex = 2;
            buttonZatwierdz.Text = "Zatwierdź";
            buttonZatwierdz.UseVisualStyleBackColor = true;
            buttonZatwierdz.Click += buttonZatwierdz_Click_1;
            // 
            // Button1
            // 
            Button1.Location = new Point(223, 280);
            Button1.Margin = new Padding(3, 2, 3, 2);
            Button1.Name = "Button1";
            Button1.Size = new Size(82, 22);
            Button1.TabIndex = 3;
            Button1.Text = "Zadanie.1";
            Button1.UseVisualStyleBackColor = true;
            Button1.Visible = false;
            Button1.Click += Button1_Click;
            // 
            // Button2
            // 
            Button2.Location = new Point(438, 280);
            Button2.Margin = new Padding(3, 2, 3, 2);
            Button2.Name = "Button2";
            Button2.Size = new Size(82, 22);
            Button2.TabIndex = 4;
            Button2.Text = "Zadanie.2";
            Button2.UseVisualStyleBackColor = true;
            Button2.Visible = false;
            Button2.Click += Button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(buttonZatwierdz);
            Controls.Add(txtNazwisko);
            Controls.Add(txtImie);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtImie;
        private TextBox txtNazwisko;
        private Button buttonZatwierdz;
        private Button Button1;
        private Button Button2;
    }
}