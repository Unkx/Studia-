namespace WinFormsApp1
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
            txtImie = new TextBox();
            txtNazwisko = new TextBox();
            txtWiek = new TextBox();
            txtAdres = new TextBox();
            listBoxStore = new ListBox();
            button1 = new Button();
            txtUlubionaKsiazka = new TextBox();
            txtKupionaKsiazka = new TextBox();
            txtRokWydania = new TextBox();
            txtPrzeczytaneStrony = new TextBox();
            txtUlubionyAutor = new TextBox();
            txtKoszyk = new TextBox();
            SuspendLayout();
            // 
            // txtImie
            // 
            txtImie.Location = new Point(76, 36);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(100, 23);
            txtImie.TabIndex = 0;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(76, 80);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(100, 23);
            txtNazwisko.TabIndex = 0;
            // 
            // txtWiek
            // 
            txtWiek.Location = new Point(76, 130);
            txtWiek.Name = "txtWiek";
            txtWiek.Size = new Size(100, 23);
            txtWiek.TabIndex = 0;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(76, 182);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(100, 23);
            txtAdres.TabIndex = 0;
            // 
            // listBoxStore
            // 
            listBoxStore.FormattingEnabled = true;
            listBoxStore.ItemHeight = 15;
            listBoxStore.Location = new Point(725, 36);
            listBoxStore.Name = "listBoxStore";
            listBoxStore.Size = new Size(516, 514);
            listBoxStore.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(281, 354);
            button1.Name = "button1";
            button1.Size = new Size(162, 60);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtUlubionaKsiazka
            // 
            txtUlubionaKsiazka.Location = new Point(343, 80);
            txtUlubionaKsiazka.Name = "txtUlubionaKsiazka";
            txtUlubionaKsiazka.Size = new Size(100, 23);
            txtUlubionaKsiazka.TabIndex = 0;
            // 
            // txtKupionaKsiazka
            // 
            txtKupionaKsiazka.Location = new Point(343, 130);
            txtKupionaKsiazka.Name = "txtKupionaKsiazka";
            txtKupionaKsiazka.Size = new Size(100, 23);
            txtKupionaKsiazka.TabIndex = 0;
            // 
            // txtRokWydania
            // 
            txtRokWydania.Location = new Point(343, 182);
            txtRokWydania.Name = "txtRokWydania";
            txtRokWydania.Size = new Size(100, 23);
            txtRokWydania.TabIndex = 0;
            // 
            // txtPrzeczytaneStrony
            // 
            txtPrzeczytaneStrony.Location = new Point(343, 243);
            txtPrzeczytaneStrony.Name = "txtPrzeczytaneStrony";
            txtPrzeczytaneStrony.Size = new Size(100, 23);
            txtPrzeczytaneStrony.TabIndex = 0;
            // 
            // txtUlubionyAutor
            // 
            txtUlubionyAutor.Location = new Point(343, 36);
            txtUlubionyAutor.Name = "txtUlubionyAutor";
            txtUlubionyAutor.Size = new Size(100, 23);
            txtUlubionyAutor.TabIndex = 0;
            // 
            // txtKoszyk
            // 
            txtKoszyk.Location = new Point(76, 243);
            txtKoszyk.Name = "txtKoszyk";
            txtKoszyk.Size = new Size(100, 23);
            txtKoszyk.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 610);
            Controls.Add(button1);
            Controls.Add(listBoxStore);
            Controls.Add(txtPrzeczytaneStrony);
            Controls.Add(txtKoszyk);
            Controls.Add(txtAdres);
            Controls.Add(txtRokWydania);
            Controls.Add(txtWiek);
            Controls.Add(txtKupionaKsiazka);
            Controls.Add(txtNazwisko);
            Controls.Add(txtUlubionyAutor);
            Controls.Add(txtUlubionaKsiazka);
            Controls.Add(txtImie);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtImie;
        private TextBox txtNazwisko;
        private TextBox txtWiek;
        private TextBox txtAdres;
        private ListBox listBoxStore;
        private Button button1;
        private TextBox txtUlubionaKsiazka;
        private TextBox txtKupionaKsiazka;
        private TextBox txtRokWydania;
        private TextBox txtPrzeczytaneStrony;
        private TextBox txtUlubionyAutor;
        private TextBox txtKoszyk;
    }
}