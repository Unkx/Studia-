namespace WinFormsApp1
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
            listBoxBook = new ListBox();
            txtImie = new TextBox();
            txtNazwisko = new TextBox();
            txtWiek = new TextBox();
            txtAdres = new TextBox();
            button1 = new Button();
            txtKoszyk = new TextBox();
            txtUlubionyAutor = new TextBox();
            txtUlubionaKsiazka = new TextBox();
            txtKupionaKsiazka = new TextBox();
            txtRokWydania = new TextBox();
            txtPrzeczytaneStrony = new TextBox();
            SuspendLayout();
            // 
            // listBoxBook
            // 
            listBoxBook.FormattingEnabled = true;
            listBoxBook.ItemHeight = 15;
            listBoxBook.Location = new Point(611, 52);
            listBoxBook.Name = "listBoxBook";
            listBoxBook.Size = new Size(720, 484);
            listBoxBook.TabIndex = 0;
            // 
            // txtImie
            // 
            txtImie.Location = new Point(76, 52);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(100, 23);
            txtImie.TabIndex = 1;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(76, 101);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(100, 23);
            txtNazwisko.TabIndex = 1;
            // 
            // txtWiek
            // 
            txtWiek.Location = new Point(76, 155);
            txtWiek.Name = "txtWiek";
            txtWiek.Size = new Size(100, 23);
            txtWiek.TabIndex = 1;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(76, 207);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(100, 23);
            txtAdres.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(202, 370);
            button1.Name = "button1";
            button1.Size = new Size(159, 65);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtKoszyk
            // 
            txtKoszyk.Location = new Point(76, 260);
            txtKoszyk.Name = "txtKoszyk";
            txtKoszyk.Size = new Size(100, 23);
            txtKoszyk.TabIndex = 1;
            // 
            // txtUlubionyAutor
            // 
            txtUlubionyAutor.Location = new Point(393, 52);
            txtUlubionyAutor.Name = "txtUlubionyAutor";
            txtUlubionyAutor.Size = new Size(100, 23);
            txtUlubionyAutor.TabIndex = 1;
            // 
            // txtUlubionaKsiazka
            // 
            txtUlubionaKsiazka.Location = new Point(393, 101);
            txtUlubionaKsiazka.Name = "txtUlubionaKsiazka";
            txtUlubionaKsiazka.Size = new Size(100, 23);
            txtUlubionaKsiazka.TabIndex = 1;
            // 
            // txtKupionaKsiazka
            // 
            txtKupionaKsiazka.Location = new Point(393, 155);
            txtKupionaKsiazka.Name = "txtKupionaKsiazka";
            txtKupionaKsiazka.Size = new Size(100, 23);
            txtKupionaKsiazka.TabIndex = 1;
            // 
            // txtRokWydania
            // 
            txtRokWydania.Location = new Point(393, 207);
            txtRokWydania.Name = "txtRokWydania";
            txtRokWydania.Size = new Size(100, 23);
            txtRokWydania.TabIndex = 1;
            // 
            // txtPrzeczytaneStrony
            // 
            txtPrzeczytaneStrony.Location = new Point(393, 260);
            txtPrzeczytaneStrony.Name = "txtPrzeczytaneStrony";
            txtPrzeczytaneStrony.Size = new Size(100, 23);
            txtPrzeczytaneStrony.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 648);
            Controls.Add(button1);
            Controls.Add(txtPrzeczytaneStrony);
            Controls.Add(txtKoszyk);
            Controls.Add(txtRokWydania);
            Controls.Add(txtAdres);
            Controls.Add(txtKupionaKsiazka);
            Controls.Add(txtWiek);
            Controls.Add(txtUlubionaKsiazka);
            Controls.Add(txtNazwisko);
            Controls.Add(txtUlubionyAutor);
            Controls.Add(txtImie);
            Controls.Add(listBoxBook);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxBook;
        private TextBox txtImie;
        private TextBox txtNazwisko;
        private TextBox txtWiek;
        private TextBox txtAdres;
        private Button button1;
        private TextBox txtKoszyk;
        private TextBox txtUlubionyAutor;
        private TextBox txtUlubionaKsiazka;
        private TextBox txtKupionaKsiazka;
        private TextBox txtRokWydania;
        private TextBox txtPrzeczytaneStrony;
    }
}