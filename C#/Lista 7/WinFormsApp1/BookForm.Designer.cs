namespace WinFormsApp1
{
    partial class BookForm
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
            buttonZaladuj = new Button();
            txtKoszyk = new TextBox();
            txtUlubionyAutor = new TextBox();
            txtUlubionaKsiazka = new TextBox();
            txtKupionaKsiazka = new TextBox();
            txtRokWydania = new TextBox();
            txtPrzeczytaneStrony = new TextBox();
            txtImieAutora = new TextBox();
            txtNazwiskoAutora = new TextBox();
            txtRokWyd = new TextBox();
            txtPrzeczytaneKs = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtTytul = new TextBox();
            label16 = new Label();
            dateCzas = new DateTimePicker();
            buttonUzupelnij = new Button();
            SuspendLayout();
            // 
            // listBoxBook
            // 
            listBoxBook.FormattingEnabled = true;
            listBoxBook.ItemHeight = 15;
            listBoxBook.Location = new Point(855, 61);
            listBoxBook.Name = "listBoxBook";
            listBoxBook.Size = new Size(444, 424);
            listBoxBook.TabIndex = 0;
            // 
            // txtImie
            // 
            txtImie.Location = new Point(166, 51);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(100, 23);
            txtImie.TabIndex = 1;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(166, 100);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(100, 23);
            txtNazwisko.TabIndex = 1;
            // 
            // txtWiek
            // 
            txtWiek.Location = new Point(166, 154);
            txtWiek.Name = "txtWiek";
            txtWiek.Size = new Size(100, 23);
            txtWiek.TabIndex = 1;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(166, 206);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(100, 23);
            txtAdres.TabIndex = 1;
            // 
            // buttonZaladuj
            // 
            buttonZaladuj.Location = new Point(354, 100);
            buttonZaladuj.Name = "buttonZaladuj";
            buttonZaladuj.Size = new Size(159, 65);
            buttonZaladuj.TabIndex = 2;
            buttonZaladuj.Text = "Potwierdź";
            buttonZaladuj.UseVisualStyleBackColor = true;
            buttonZaladuj.Click += buttonZaladuj_Click;
            // 
            // txtKoszyk
            // 
            txtKoszyk.Location = new Point(166, 259);
            txtKoszyk.Name = "txtKoszyk";
            txtKoszyk.Size = new Size(100, 23);
            txtKoszyk.TabIndex = 1;
            // 
            // txtUlubionyAutor
            // 
            txtUlubionyAutor.Location = new Point(681, 51);
            txtUlubionyAutor.Name = "txtUlubionyAutor";
            txtUlubionyAutor.Size = new Size(100, 23);
            txtUlubionyAutor.TabIndex = 1;
            // 
            // txtUlubionaKsiazka
            // 
            txtUlubionaKsiazka.Location = new Point(681, 100);
            txtUlubionaKsiazka.Name = "txtUlubionaKsiazka";
            txtUlubionaKsiazka.Size = new Size(100, 23);
            txtUlubionaKsiazka.TabIndex = 1;
            // 
            // txtKupionaKsiazka
            // 
            txtKupionaKsiazka.Location = new Point(681, 154);
            txtKupionaKsiazka.Name = "txtKupionaKsiazka";
            txtKupionaKsiazka.Size = new Size(100, 23);
            txtKupionaKsiazka.TabIndex = 1;
            // 
            // txtRokWydania
            // 
            txtRokWydania.Location = new Point(681, 206);
            txtRokWydania.Name = "txtRokWydania";
            txtRokWydania.Size = new Size(100, 23);
            txtRokWydania.TabIndex = 1;
            // 
            // txtPrzeczytaneStrony
            // 
            txtPrzeczytaneStrony.Location = new Point(681, 259);
            txtPrzeczytaneStrony.Name = "txtPrzeczytaneStrony";
            txtPrzeczytaneStrony.Size = new Size(100, 23);
            txtPrzeczytaneStrony.TabIndex = 1;
            // 
            // txtImieAutora
            // 
            txtImieAutora.Location = new Point(391, 259);
            txtImieAutora.Name = "txtImieAutora";
            txtImieAutora.Size = new Size(100, 23);
            txtImieAutora.TabIndex = 3;
            // 
            // txtNazwiskoAutora
            // 
            txtNazwiskoAutora.Location = new Point(391, 319);
            txtNazwiskoAutora.Name = "txtNazwiskoAutora";
            txtNazwiskoAutora.Size = new Size(100, 23);
            txtNazwiskoAutora.TabIndex = 3;
            // 
            // txtRokWyd
            // 
            txtRokWyd.Location = new Point(391, 419);
            txtRokWyd.Name = "txtRokWyd";
            txtRokWyd.Size = new Size(100, 23);
            txtRokWyd.TabIndex = 3;
            // 
            // txtPrzeczytaneKs
            // 
            txtPrzeczytaneKs.Location = new Point(391, 464);
            txtPrzeczytaneKs.Name = "txtPrzeczytaneKs";
            txtPrzeczytaneKs.Size = new Size(100, 23);
            txtPrzeczytaneKs.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 54);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 4;
            label1.Text = "Podaj Imię :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 103);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 4;
            label2.Text = "Podaj Nazwisko :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 157);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "Podaj Wiek :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 206);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 4;
            label4.Text = "Adres :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 262);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 4;
            label5.Text = "Książki w Koszyku :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(563, 59);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 4;
            label6.Text = "Ulubiony Autor :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(555, 103);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 4;
            label7.Text = "Ulubiona Książka :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(559, 157);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 4;
            label8.Text = "Kupiona Książka :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(563, 206);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 4;
            label9.Text = "Rok Wydania :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(555, 262);
            label10.Name = "label10";
            label10.Size = new Size(112, 15);
            label10.TabIndex = 4;
            label10.Text = "Przeczytane Strony :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(303, 262);
            label11.Name = "label11";
            label11.Size = new Size(75, 15);
            label11.TabIndex = 5;
            label11.Text = "Imie Autora :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(367, 227);
            label12.Name = "label12";
            label12.Size = new Size(156, 15);
            label12.TabIndex = 6;
            label12.Text = "Książka która jest w koszyku ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(273, 322);
            label13.Name = "label13";
            label13.Size = new Size(102, 15);
            label13.TabIndex = 5;
            label13.Text = "Nazwisko Autora :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(295, 422);
            label14.Name = "label14";
            label14.Size = new Size(82, 15);
            label14.TabIndex = 5;
            label14.Text = "Rok Wydania :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(226, 466);
            label15.Name = "label15";
            label15.Size = new Size(146, 15);
            label15.TabIndex = 5;
            label15.Text = "Ilość przeczytanych Stron :";
            // 
            // txtTytul
            // 
            txtTytul.Location = new Point(391, 370);
            txtTytul.Margin = new Padding(3, 2, 3, 2);
            txtTytul.Name = "txtTytul";
            txtTytul.Size = new Size(100, 23);
            txtTytul.TabIndex = 7;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(291, 375);
            label16.Name = "label16";
            label16.Size = new Size(76, 15);
            label16.TabIndex = 8;
            label16.Text = "Tytuł Książki :";
            // 
            // dateCzas
            // 
            dateCzas.Format = DateTimePickerFormat.Custom;
            dateCzas.Location = new Point(291, 9);
            dateCzas.Margin = new Padding(3, 2, 3, 2);
            dateCzas.Name = "dateCzas";
            dateCzas.Size = new Size(248, 23);
            dateCzas.TabIndex = 9;
            dateCzas.Value = new DateTime(2023, 4, 19, 0, 0, 0, 0);
            // 
            // buttonUzupelnij
            // 
            buttonUzupelnij.Location = new Point(642, 351);
            buttonUzupelnij.Name = "buttonUzupelnij";
            buttonUzupelnij.Size = new Size(150, 63);
            buttonUzupelnij.TabIndex = 10;
            buttonUzupelnij.Text = "Uzupełnij";
            buttonUzupelnij.UseMnemonic = false;
            buttonUzupelnij.UseVisualStyleBackColor = true;
            buttonUzupelnij.Click += buttonUzupelnij_Click;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 648);
            Controls.Add(buttonUzupelnij);
            Controls.Add(dateCzas);
            Controls.Add(label16);
            Controls.Add(txtTytul);
            Controls.Add(label12);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(txtPrzeczytaneKs);
            Controls.Add(txtRokWyd);
            Controls.Add(txtNazwiskoAutora);
            Controls.Add(txtImieAutora);
            Controls.Add(buttonZaladuj);
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
            Name = "BookForm";
            Text = "Dane o Książce";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxBook;
        private TextBox txtImie;
        private TextBox txtNazwisko;
        private TextBox txtWiek;
        private TextBox txtAdres;
        private Button buttonZaladuj;
        private TextBox txtKoszyk;
        private TextBox txtUlubionyAutor;
        private TextBox txtUlubionaKsiazka;
        private TextBox txtKupionaKsiazka;
        private TextBox txtRokWydania;
        private TextBox txtPrzeczytaneStrony;
        private TextBox txtImieAutora;
        private TextBox txtNazwiskoAutora;
        private TextBox txtRokWyd;
        private TextBox txtPrzeczytaneKs;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox txtTytul;
        private Label label16;
        private DateTimePicker dateCzas;
        private Button buttonUzupelnij;
    }
}