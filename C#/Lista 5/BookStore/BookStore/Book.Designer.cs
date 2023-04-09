namespace BookStore
{
    partial class Book
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
            buttonWypisz = new Button();
            textBoxImie = new TextBox();
            listBoxDane = new ListBox();
            textBoxNazwisko = new TextBox();
            textBoxStrony = new TextBox();
            textBoxKolor = new TextBox();
            textBoxTytul = new TextBox();
            labelDane = new Label();
            SuspendLayout();
            // 
            // buttonWypisz
            // 
            buttonWypisz.Location = new Point(161, 279);
            buttonWypisz.Name = "buttonWypisz";
            buttonWypisz.Size = new Size(211, 69);
            buttonWypisz.TabIndex = 0;
            buttonWypisz.Text = "button1";
            buttonWypisz.UseVisualStyleBackColor = true;
            buttonWypisz.Click += buttonWypisz_Click;
            // 
            // textBoxImie
            // 
            textBoxImie.Location = new Point(202, 22);
            textBoxImie.Name = "textBoxImie";
            textBoxImie.Size = new Size(100, 23);
            textBoxImie.TabIndex = 1;
            // 
            // listBoxDane
            // 
            listBoxDane.FormattingEnabled = true;
            listBoxDane.ItemHeight = 15;
            listBoxDane.Location = new Point(518, 74);
            listBoxDane.Name = "listBoxDane";
            listBoxDane.Size = new Size(185, 289);
            listBoxDane.TabIndex = 2;
            listBoxDane.Visible = false;
            // 
            // textBoxNazwisko
            // 
            textBoxNazwisko.Location = new Point(202, 74);
            textBoxNazwisko.Name = "textBoxNazwisko";
            textBoxNazwisko.Size = new Size(100, 23);
            textBoxNazwisko.TabIndex = 3;
            // 
            // textBoxStrony
            // 
            textBoxStrony.Location = new Point(202, 171);
            textBoxStrony.Name = "textBoxStrony";
            textBoxStrony.Size = new Size(100, 23);
            textBoxStrony.TabIndex = 1;
            // 
            // textBoxKolor
            // 
            textBoxKolor.Location = new Point(202, 223);
            textBoxKolor.Name = "textBoxKolor";
            textBoxKolor.Size = new Size(100, 23);
            textBoxKolor.TabIndex = 3;
            // 
            // textBoxTytul
            // 
            textBoxTytul.Location = new Point(202, 124);
            textBoxTytul.Name = "textBoxTytul";
            textBoxTytul.Size = new Size(100, 23);
            textBoxTytul.TabIndex = 3;
            // 
            // labelDane
            // 
            labelDane.AutoSize = true;
            labelDane.Location = new Point(561, 30);
            labelDane.Name = "labelDane";
            labelDane.Size = new Size(105, 15);
            labelDane.TabIndex = 4;
            labelDane.Text = "Twoje dane chuju :";
            labelDane.Visible = false;
            // 
            // Book
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelDane);
            Controls.Add(textBoxTytul);
            Controls.Add(textBoxKolor);
            Controls.Add(textBoxNazwisko);
            Controls.Add(textBoxStrony);
            Controls.Add(listBoxDane);
            Controls.Add(textBoxImie);
            Controls.Add(buttonWypisz);
            Name = "Book";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonWypisz;
        private TextBox textBoxImie;
        private ListBox listBoxDane;
        private TextBox textBoxNazwisko;
        private TextBox textBoxStrony;
        private TextBox textBoxKolor;
        private TextBox textBoxTytul;
        private Label labelDane;
    }
}