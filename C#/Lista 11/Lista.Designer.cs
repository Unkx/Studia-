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
            ((System.ComponentModel.ISupportInitialize)pictureZdjecie2).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(215, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(470, 324);
            listBox1.TabIndex = 0;
            // 
            // buttonNastępny
            // 
            buttonNastępny.Location = new Point(400, 397);
            buttonNastępny.Name = "buttonNastępny";
            buttonNastępny.Size = new Size(94, 29);
            buttonNastępny.TabIndex = 1;
            buttonNastępny.Text = "Następny";
            buttonNastępny.UseVisualStyleBackColor = true;
            buttonNastępny.Click += buttonPoprzedni_Click;
            // 
            // pictureZdjecie2
            // 
            pictureZdjecie2.Location = new Point(547, 293);
            pictureZdjecie2.Name = "pictureZdjecie2";
            pictureZdjecie2.Padding = new Padding(450, 51, 0, 40);
            pictureZdjecie2.Size = new Size(125, 61);
            pictureZdjecie2.TabIndex = 2;
            pictureZdjecie2.TabStop = false;
            // 
            // buttonPoprzedni
            // 
            buttonPoprzedni.Location = new Point(261, 397);
            buttonPoprzedni.Name = "buttonPoprzedni";
            buttonPoprzedni.Size = new Size(94, 29);
            buttonPoprzedni.TabIndex = 3;
            buttonPoprzedni.Text = "Poprzedni";
            buttonPoprzedni.UseVisualStyleBackColor = true;
            buttonPoprzedni.Click += buttonNastepny_Click;
            // 
            // buttonZapisz
            // 
            buttonZapisz.Location = new Point(72, 67);
            buttonZapisz.Margin = new Padding(3, 4, 3, 4);
            buttonZapisz.Name = "buttonZapisz";
            buttonZapisz.Size = new Size(86, 31);
            buttonZapisz.TabIndex = 4;
            buttonZapisz.Text = "Zapisz";
            buttonZapisz.UseVisualStyleBackColor = true;
            buttonZapisz.Click += buttonZapisz_Click;
            // 
            // buttonWczytaj
            // 
            buttonWczytaj.Location = new Point(72, 125);
            buttonWczytaj.Margin = new Padding(3, 4, 3, 4);
            buttonWczytaj.Name = "buttonWczytaj";
            buttonWczytaj.Size = new Size(86, 31);
            buttonWczytaj.TabIndex = 4;
            buttonWczytaj.Text = "Wczytaj";
            buttonWczytaj.UseVisualStyleBackColor = true;
            buttonWczytaj.Click += buttonWczytaj_Click;
            // 
            // buttonWyswietl
            // 
            buttonWyswietl.Location = new Point(72, 187);
            buttonWyswietl.Margin = new Padding(3, 4, 3, 4);
            buttonWyswietl.Name = "buttonWyswietl";
            buttonWyswietl.Size = new Size(86, 31);
            buttonWyswietl.TabIndex = 4;
            buttonWyswietl.Text = "Wyświetl";
            buttonWyswietl.UseVisualStyleBackColor = true;
            buttonWyswietl.Click += buttonWyswietl_Click;
            // 
            // buttonUsun
            // 
            buttonUsun.Location = new Point(533, 396);
            buttonUsun.Margin = new Padding(3, 4, 3, 4);
            buttonUsun.Name = "buttonUsun";
            buttonUsun.Size = new Size(86, 31);
            buttonUsun.TabIndex = 5;
            buttonUsun.Text = "Usuń";
            buttonUsun.UseVisualStyleBackColor = true;
            buttonUsun.Click += buttonUsun_Click;
            // 
            // Lista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(buttonUsun);
            Controls.Add(buttonWyswietl);
            Controls.Add(buttonWczytaj);
            Controls.Add(buttonZapisz);
            Controls.Add(buttonPoprzedni);
            Controls.Add(pictureZdjecie2);
            Controls.Add(buttonNastępny);
            Controls.Add(listBox1);
            Name = "Lista";
            Text = "Lista";
            ((System.ComponentModel.ISupportInitialize)pictureZdjecie2).EndInit();
            ResumeLayout(false);
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
    }
}