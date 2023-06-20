namespace WinFormsApp1
{
    partial class Lista
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
            listBox1 = new ListBox();
            buttonNastępny = new Button();
            pictureZdjecie2 = new PictureBox();
            buttonPoprzedni = new Button();
            buttonZapisz = new Button();
            buttonWczytaj = new Button();
            buttonWyswietl = new Button();
            buttonUsun = new Button();
            buttonSort = new Button();
            label1 = new Label();
            textBoxImie = new TextBox();
            label2 = new Label();
            textBoxNazwisko = new TextBox();
            label3 = new Label();
            textBoxPrzeczytaneStrony = new TextBox();
            buttonNazwisko = new Button();
            buttonWiek = new Button();
            buttonImie = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureZdjecie2).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(188, 32);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(412, 244);
            listBox1.TabIndex = 0;
            // 
            // buttonNastępny
            // 
            buttonNastępny.Location = new Point(299, 298);
            buttonNastępny.Margin = new Padding(3, 2, 3, 2);
            buttonNastępny.Name = "buttonNastępny";
            buttonNastępny.Size = new Size(82, 22);
            buttonNastępny.TabIndex = 1;
            buttonNastępny.Text = "Następny";
            buttonNastępny.UseVisualStyleBackColor = true;
            buttonNastępny.Click += buttonPoprzedni_Click;
            // 
            // pictureZdjecie2
            // 
            pictureZdjecie2.Location = new Point(479, 220);
            pictureZdjecie2.Margin = new Padding(3, 2, 3, 2);
            pictureZdjecie2.Name = "pictureZdjecie2";
            pictureZdjecie2.Padding = new Padding(394, 38, 0, 30);
            pictureZdjecie2.Size = new Size(109, 46);
            pictureZdjecie2.TabIndex = 2;
            pictureZdjecie2.TabStop = false;
            // 
            // buttonPoprzedni
            // 
            buttonPoprzedni.Location = new Point(188, 298);
            buttonPoprzedni.Margin = new Padding(3, 2, 3, 2);
            buttonPoprzedni.Name = "buttonPoprzedni";
            buttonPoprzedni.Size = new Size(82, 22);
            buttonPoprzedni.TabIndex = 3;
            buttonPoprzedni.Text = "Poprzedni";
            buttonPoprzedni.UseVisualStyleBackColor = true;
            buttonPoprzedni.Click += buttonNastepny_Click;
            // 
            // buttonZapisz
            // 
            buttonZapisz.Location = new Point(63, 50);
            buttonZapisz.Name = "buttonZapisz";
            buttonZapisz.Size = new Size(75, 23);
            buttonZapisz.TabIndex = 4;
            buttonZapisz.Text = "Zapisz";
            buttonZapisz.UseVisualStyleBackColor = true;
            buttonZapisz.Click += buttonZapisz_Click;
            // 
            // buttonWczytaj
            // 
            buttonWczytaj.Location = new Point(63, 94);
            buttonWczytaj.Name = "buttonWczytaj";
            buttonWczytaj.Size = new Size(75, 23);
            buttonWczytaj.TabIndex = 4;
            buttonWczytaj.Text = "Wczytaj";
            buttonWczytaj.UseVisualStyleBackColor = true;
            buttonWczytaj.Click += buttonWczytaj_Click;
            // 
            // buttonWyswietl
            // 
            buttonWyswietl.Location = new Point(63, 140);
            buttonWyswietl.Name = "buttonWyswietl";
            buttonWyswietl.Size = new Size(75, 23);
            buttonWyswietl.TabIndex = 4;
            buttonWyswietl.Text = "Wyświetl";
            buttonWyswietl.UseVisualStyleBackColor = true;
            buttonWyswietl.Click += buttonWyswietl_Click;
            // 
            // buttonUsun
            // 
            buttonUsun.Location = new Point(412, 297);
            buttonUsun.Name = "buttonUsun";
            buttonUsun.Size = new Size(75, 23);
            buttonUsun.TabIndex = 5;
            buttonUsun.Text = "Usuń";
            buttonUsun.UseVisualStyleBackColor = true;
            buttonUsun.Click += buttonUsun_Click;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(525, 297);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(75, 23);
            buttonSort.TabIndex = 6;
            buttonSort.Text = "Sortuj";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(669, 32);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 7;
            label1.Text = "Podaj Imię :";
            // 
            // textBoxImie
            // 
            textBoxImie.Location = new Point(655, 59);
            textBoxImie.Name = "textBoxImie";
            textBoxImie.Size = new Size(100, 23);
            textBoxImie.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(659, 126);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 7;
            label2.Text = "Podaj Nazwisko :";
            // 
            // textBoxNazwisko
            // 
            textBoxNazwisko.Location = new Point(655, 144);
            textBoxNazwisko.Name = "textBoxNazwisko";
            textBoxNazwisko.Size = new Size(100, 23);
            textBoxNazwisko.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(616, 204);
            label3.Name = "label3";
            label3.Size = new Size(178, 15);
            label3.TabIndex = 7;
            label3.Text = "Podaj ilość przeczytanych stron :";
            // 
            // textBoxPrzeczytaneStrony
            // 
            textBoxPrzeczytaneStrony.Location = new Point(655, 226);
            textBoxPrzeczytaneStrony.Name = "textBoxPrzeczytaneStrony";
            textBoxPrzeczytaneStrony.Size = new Size(100, 23);
            textBoxPrzeczytaneStrony.TabIndex = 8;
            // 
            // buttonNazwisko
            // 
            buttonNazwisko.Location = new Point(651, 173);
            buttonNazwisko.Name = "buttonNazwisko";
            buttonNazwisko.Size = new Size(118, 23);
            buttonNazwisko.TabIndex = 10;
            buttonNazwisko.Text = "Sprawdź";
            buttonNazwisko.UseVisualStyleBackColor = true;
            buttonNazwisko.Click += buttonNazwisko_Click;
            // 
            // buttonWiek
            // 
            buttonWiek.Location = new Point(651, 266);
            buttonWiek.Name = "buttonWiek";
            buttonWiek.Size = new Size(118, 23);
            buttonWiek.TabIndex = 11;
            buttonWiek.Text = "Sprawdź";
            buttonWiek.UseVisualStyleBackColor = true;
            buttonWiek.Click += buttonWiek_Click;
            // 
            // buttonImie
            // 
            buttonImie.Location = new Point(651, 94);
            buttonImie.Name = "buttonImie";
            buttonImie.Size = new Size(118, 23);
            buttonImie.TabIndex = 12;
            buttonImie.Text = "Sprawdź";
            buttonImie.UseVisualStyleBackColor = true;
            buttonImie.Click += buttonImie_Click;
            // 
            // Lista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 396);
            Controls.Add(buttonImie);
            Controls.Add(buttonWiek);
            Controls.Add(buttonNazwisko);
            Controls.Add(textBoxPrzeczytaneStrony);
            Controls.Add(label3);
            Controls.Add(textBoxNazwisko);
            Controls.Add(label2);
            Controls.Add(textBoxImie);
            Controls.Add(label1);
            Controls.Add(buttonSort);
            Controls.Add(buttonUsun);
            Controls.Add(buttonWyswietl);
            Controls.Add(buttonWczytaj);
            Controls.Add(buttonZapisz);
            Controls.Add(buttonPoprzedni);
            Controls.Add(pictureZdjecie2);
            Controls.Add(buttonNastępny);
            Controls.Add(listBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Lista";
            Text = "Lista";
            ((System.ComponentModel.ISupportInitialize)pictureZdjecie2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button buttonNastępny;
        private PictureBox pictureZdjecie2;
        private Button buttonPoprzedni;
        private Button buttonZapisz;
        private Button buttonWczytaj;
        private Button buttonWyswietl;
        private Button buttonUsun;
        private Button buttonSort;
        private Label label1;
        private TextBox textBoxImie;
        private Label label2;
        private TextBox textBoxNazwisko;
        private Label label3;
        private TextBox textBoxPrzeczytaneStrony;
        private Button buttonNazwisko;
        private Button buttonWiek;
        private Button buttonImie;
    }
}