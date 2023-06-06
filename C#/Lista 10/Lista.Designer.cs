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
            pictureZdjecie2 = new PictureBox();
            buttonPoprzedni = new Button();
            buttonZapisz = new Button();
            buttonWczytaj = new Button();
            buttonWyswietl = new Button();
            buttonUsun = new Button();
            buttonNastepny = new Button();
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
            buttonPoprzedni.Location = new Point(228, 298);
            buttonPoprzedni.Margin = new Padding(3, 2, 3, 2);
            buttonPoprzedni.Name = "buttonPoprzedni";
            buttonPoprzedni.Size = new Size(82, 22);
            buttonPoprzedni.TabIndex = 3;
            buttonPoprzedni.Text = "Poprzedni";
            buttonPoprzedni.UseVisualStyleBackColor = true;
            buttonPoprzedni.Click += buttonPoprzedni_Click;
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
            buttonUsun.Location = new Point(466, 297);
            buttonUsun.Name = "buttonUsun";
            buttonUsun.Size = new Size(75, 23);
            buttonUsun.TabIndex = 5;
            buttonUsun.Text = "Usuń";
            buttonUsun.UseVisualStyleBackColor = true;
            buttonUsun.Click += buttonUsun_Click;
            // 
            // buttonNastepny
            // 
            buttonNastepny.Location = new Point(351, 298);
            buttonNastepny.Name = "buttonNastepny";
            buttonNastepny.Size = new Size(75, 23);
            buttonNastepny.TabIndex = 6;
            buttonNastepny.Text = "Następny";
            buttonNastepny.UseVisualStyleBackColor = true;
            buttonNastepny.Click += buttonNastepny_Click;
            // 
            // Lista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonNastepny);
            Controls.Add(buttonUsun);
            Controls.Add(buttonWyswietl);
            Controls.Add(buttonWczytaj);
            Controls.Add(buttonZapisz);
            Controls.Add(buttonPoprzedni);
            Controls.Add(pictureZdjecie2);
            Controls.Add(listBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Lista";
            Text = "Za";
            ((System.ComponentModel.ISupportInitialize)pictureZdjecie2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private PictureBox pictureZdjecie2;
        private Button buttonPoprzedni;
        private Button buttonZapisz;
        private Button buttonWczytaj;
        private Button buttonWyswietl;
        private Button buttonUsun;
        private Button buttonNastepny;
    }
}