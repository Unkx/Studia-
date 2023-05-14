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
            pictureZdjecie2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureZdjecie2).BeginInit();
            SuspendLayout();
            // 
            // listBoxBook
            // 
            listBoxBook.FormattingEnabled = true;
            listBoxBook.ItemHeight = 20;
            listBoxBook.Location = new Point(977, 81);
            listBoxBook.Margin = new Padding(3, 4, 3, 4);
            listBoxBook.Name = "listBoxBook";
            listBoxBook.Size = new Size(507, 564);
            listBoxBook.TabIndex = 0;
            // 
            // txtImie
            // 
            txtImie.Location = new Point(190, 68);
            txtImie.Margin = new Padding(3, 4, 3, 4);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(114, 27);
            txtImie.TabIndex = 1;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(190, 133);
            txtNazwisko.Margin = new Padding(3, 4, 3, 4);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(114, 27);
            txtNazwisko.TabIndex = 1;
            // 
            // txtWiek
            // 
            txtWiek.Location = new Point(190, 205);
            txtWiek.Margin = new Padding(3, 4, 3, 4);
            txtWiek.Name = "txtWiek";
            txtWiek.Size = new Size(114, 27);
            txtWiek.TabIndex = 1;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(190, 275);
            txtAdres.Margin = new Padding(3, 4, 3, 4);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(114, 27);
            txtAdres.TabIndex = 1;
            // 
            // buttonZaladuj
            // 
            buttonZaladuj.Location = new Point(405, 133);
            buttonZaladuj.Margin = new Padding(3, 4, 3, 4);
            buttonZaladuj.Name = "buttonZaladuj";
            buttonZaladuj.Size = new Size(182, 87);
            buttonZaladuj.TabIndex = 2;
            buttonZaladuj.Text = "Potwierdź";
            buttonZaladuj.UseVisualStyleBackColor = true;
            buttonZaladuj.Click += buttonZaladuj_Click;
            // 
            // txtKoszyk
            // 
            txtKoszyk.Location = new Point(190, 345);
            txtKoszyk.Margin = new Padding(3, 4, 3, 4);
            txtKoszyk.Name = "txtKoszyk";
            txtKoszyk.Size = new Size(114, 27);
            txtKoszyk.TabIndex = 1;
            // 
            // txtUlubionyAutor
            // 
            txtUlubionyAutor.Location = new Point(778, 68);
            txtUlubionyAutor.Margin = new Padding(3, 4, 3, 4);
            txtUlubionyAutor.Name = "txtUlubionyAutor";
            txtUlubionyAutor.Size = new Size(114, 27);
            txtUlubionyAutor.TabIndex = 1;
            // 
            // txtUlubionaKsiazka
            // 
            txtUlubionaKsiazka.Location = new Point(778, 133);
            txtUlubionaKsiazka.Margin = new Padding(3, 4, 3, 4);
            txtUlubionaKsiazka.Name = "txtUlubionaKsiazka";
            txtUlubionaKsiazka.Size = new Size(114, 27);
            txtUlubionaKsiazka.TabIndex = 1;
            // 
            // txtKupionaKsiazka
            // 
            txtKupionaKsiazka.Location = new Point(778, 205);
            txtKupionaKsiazka.Margin = new Padding(3, 4, 3, 4);
            txtKupionaKsiazka.Name = "txtKupionaKsiazka";
            txtKupionaKsiazka.Size = new Size(114, 27);
            txtKupionaKsiazka.TabIndex = 1;
            // 
            // txtRokWydania
            // 
            txtRokWydania.Location = new Point(778, 275);
            txtRokWydania.Margin = new Padding(3, 4, 3, 4);
            txtRokWydania.Name = "txtRokWydania";
            txtRokWydania.Size = new Size(114, 27);
            txtRokWydania.TabIndex = 1;
            // 
            // txtPrzeczytaneStrony
            // 
            txtPrzeczytaneStrony.Location = new Point(778, 345);
            txtPrzeczytaneStrony.Margin = new Padding(3, 4, 3, 4);
            txtPrzeczytaneStrony.Name = "txtPrzeczytaneStrony";
            txtPrzeczytaneStrony.Size = new Size(114, 27);
            txtPrzeczytaneStrony.TabIndex = 1;
            // 
            // txtImieAutora
            // 
            txtImieAutora.Location = new Point(447, 345);
            txtImieAutora.Margin = new Padding(3, 4, 3, 4);
            txtImieAutora.Name = "txtImieAutora";
            txtImieAutora.Size = new Size(114, 27);
            txtImieAutora.TabIndex = 3;
            // 
            // txtNazwiskoAutora
            // 
            txtNazwiskoAutora.Location = new Point(447, 425);
            txtNazwiskoAutora.Margin = new Padding(3, 4, 3, 4);
            txtNazwiskoAutora.Name = "txtNazwiskoAutora";
            txtNazwiskoAutora.Size = new Size(114, 27);
            txtNazwiskoAutora.TabIndex = 3;
            // 
            // txtRokWyd
            // 
            txtRokWyd.Location = new Point(447, 559);
            txtRokWyd.Margin = new Padding(3, 4, 3, 4);
            txtRokWyd.Name = "txtRokWyd";
            txtRokWyd.Size = new Size(114, 27);
            txtRokWyd.TabIndex = 3;
            // 
            // txtPrzeczytaneKs
            // 
            txtPrzeczytaneKs.Location = new Point(447, 619);
            txtPrzeczytaneKs.Margin = new Padding(3, 4, 3, 4);
            txtPrzeczytaneKs.Name = "txtPrzeczytaneKs";
            txtPrzeczytaneKs.Size = new Size(114, 27);
            txtPrzeczytaneKs.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 72);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 4;
            label1.Text = "Podaj Imię :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 137);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 4;
            label2.Text = "Podaj Nazwisko :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 209);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 4;
            label3.Text = "Podaj Wiek :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 275);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 4;
            label4.Text = "Adres :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 349);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 4;
            label5.Text = "Książki w Koszyku :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(643, 79);
            label6.Name = "label6";
            label6.Size = new Size(116, 20);
            label6.TabIndex = 4;
            label6.Text = "Ulubiony Autor :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(634, 137);
            label7.Name = "label7";
            label7.Size = new Size(129, 20);
            label7.TabIndex = 4;
            label7.Text = "Ulubiona Książka :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(639, 209);
            label8.Name = "label8";
            label8.Size = new Size(124, 20);
            label8.TabIndex = 4;
            label8.Text = "Kupiona Książka :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(643, 275);
            label9.Name = "label9";
            label9.Size = new Size(103, 20);
            label9.TabIndex = 4;
            label9.Text = "Rok Wydania :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(634, 349);
            label10.Name = "label10";
            label10.Size = new Size(140, 20);
            label10.TabIndex = 4;
            label10.Text = "Przeczytane Strony :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(346, 349);
            label11.Name = "label11";
            label11.Size = new Size(94, 20);
            label11.TabIndex = 5;
            label11.Text = "Imie Autora :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(419, 303);
            label12.Name = "label12";
            label12.Size = new Size(197, 20);
            label12.TabIndex = 6;
            label12.Text = "Książka która jest w koszyku ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(312, 429);
            label13.Name = "label13";
            label13.Size = new Size(128, 20);
            label13.TabIndex = 5;
            label13.Text = "Nazwisko Autora :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(337, 563);
            label14.Name = "label14";
            label14.Size = new Size(103, 20);
            label14.TabIndex = 5;
            label14.Text = "Rok Wydania :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(258, 621);
            label15.Name = "label15";
            label15.Size = new Size(182, 20);
            label15.TabIndex = 5;
            label15.Text = "Ilość przeczytanych Stron :";
            // 
            // txtTytul
            // 
            txtTytul.Location = new Point(447, 493);
            txtTytul.Name = "txtTytul";
            txtTytul.Size = new Size(114, 27);
            txtTytul.TabIndex = 7;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(333, 500);
            label16.Name = "label16";
            label16.Size = new Size(96, 20);
            label16.TabIndex = 8;
            label16.Text = "Tytuł Książki :";
            // 
            // dateCzas
            // 
            dateCzas.Format = DateTimePickerFormat.Custom;
            dateCzas.Location = new Point(333, 12);
            dateCzas.Name = "dateCzas";
            dateCzas.Size = new Size(283, 27);
            dateCzas.TabIndex = 9;
            dateCzas.Value = new DateTime(2023, 4, 19, 0, 0, 0, 0);
            // 
            // buttonUzupelnij
            // 
            buttonUzupelnij.Location = new Point(734, 468);
            buttonUzupelnij.Margin = new Padding(3, 4, 3, 4);
            buttonUzupelnij.Name = "buttonUzupelnij";
            buttonUzupelnij.Size = new Size(171, 84);
            buttonUzupelnij.TabIndex = 10;
            buttonUzupelnij.Text = "Uzupełnij";
            buttonUzupelnij.UseMnemonic = false;
            buttonUzupelnij.UseVisualStyleBackColor = true;
            buttonUzupelnij.Click += buttonUzupelnij_Click;
            // 
            // pictureZdjecie2
            // 
            pictureZdjecie2.Location = new Point(1289, 563);
            pictureZdjecie2.Name = "pictureZdjecie2";
            pictureZdjecie2.Size = new Size(125, 62);
            pictureZdjecie2.TabIndex = 11;
            pictureZdjecie2.TabStop = false;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1563, 864);
            Controls.Add(pictureZdjecie2);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "BookForm";
            Text = "Dane o Książce";
            ((System.ComponentModel.ISupportInitialize)pictureZdjecie2).EndInit();
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
        private PictureBox pictureZdjecie2;
    }
}