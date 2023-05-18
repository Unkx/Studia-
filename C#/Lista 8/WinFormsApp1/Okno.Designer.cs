namespace WinFormsApp1
{
    partial class Okno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Okno));
            buttonBook = new Button();
            buttonStore = new Button();
            label1 = new Label();
            label2 = new Label();
            buttonZdjecie = new Button();
            dateCzas = new DateTimePicker();
            pictureBoxZdjecie = new PictureBox();
            buttonLista = new Button();
            buttonPorownanie = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxZdjecie).BeginInit();
            SuspendLayout();
            // 
            // buttonBook
            // 
            buttonBook.Location = new Point(145, 261);
            buttonBook.Name = "buttonBook";
            buttonBook.Size = new Size(162, 59);
            buttonBook.TabIndex = 0;
            buttonBook.Text = "Kliknij";
            buttonBook.UseVisualStyleBackColor = true;
            buttonBook.Click += buttonBook_Click;
            // 
            // buttonStore
            // 
            buttonStore.Location = new Point(515, 259);
            buttonStore.Name = "buttonStore";
            buttonStore.Size = new Size(180, 61);
            buttonStore.TabIndex = 1;
            buttonStore.Text = "Kliknij";
            buttonStore.UseVisualStyleBackColor = true;
            buttonStore.Click += buttonStore_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 213);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 2;
            label1.Text = "Dane o Książce";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(587, 213);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 3;
            label2.Text = "Sklep";
            // 
            // buttonZdjecie
            // 
            buttonZdjecie.Location = new Point(83, 101);
            buttonZdjecie.Margin = new Padding(3, 2, 3, 2);
            buttonZdjecie.Name = "buttonZdjecie";
            buttonZdjecie.Size = new Size(109, 48);
            buttonZdjecie.TabIndex = 0;
            buttonZdjecie.Text = "Wyświetl zdj";
            buttonZdjecie.Click += buttonZdjecie_Click;
            // 
            // dateCzas
            // 
            dateCzas.Format = DateTimePickerFormat.Custom;
            dateCzas.Location = new Point(284, 9);
            dateCzas.Margin = new Padding(3, 2, 3, 2);
            dateCzas.Name = "dateCzas";
            dateCzas.Size = new Size(233, 23);
            dateCzas.TabIndex = 5;
            dateCzas.Value = new DateTime(2023, 4, 19, 0, 0, 0, 0);
            // 
            // pictureBoxZdjecie
            // 
            pictureBoxZdjecie.BackColor = SystemColors.ActiveCaptionText;
            pictureBoxZdjecie.Image = (Image)resources.GetObject("pictureBoxZdjecie.Image");
            pictureBoxZdjecie.Location = new Point(284, 83);
            pictureBoxZdjecie.Name = "pictureBoxZdjecie";
            pictureBoxZdjecie.Size = new Size(245, 127);
            pictureBoxZdjecie.TabIndex = 6;
            pictureBoxZdjecie.TabStop = false;
            pictureBoxZdjecie.Visible = false;
            // 
            // buttonLista
            // 
            buttonLista.Location = new Point(247, 359);
            buttonLista.Margin = new Padding(3, 2, 3, 2);
            buttonLista.Name = "buttonLista";
            buttonLista.Size = new Size(156, 44);
            buttonLista.TabIndex = 7;
            buttonLista.Text = "Lista";
            buttonLista.UseVisualStyleBackColor = false;
            buttonLista.Click += buttonLista_Click;
            // 
            // buttonPorownanie
            // 
            buttonPorownanie.Location = new Point(537, 351);
            buttonPorownanie.Name = "buttonPorownanie";
            buttonPorownanie.Size = new Size(121, 60);
            buttonPorownanie.TabIndex = 8;
            buttonPorownanie.Text = "Porownanie";
            buttonPorownanie.UseVisualStyleBackColor = true;
            buttonPorownanie.Click += buttonPorownanie_Click;
            // 
            // Okno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonPorownanie);
            Controls.Add(buttonLista);
            Controls.Add(pictureBoxZdjecie);
            Controls.Add(dateCzas);
            Controls.Add(buttonZdjecie);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonStore);
            Controls.Add(buttonBook);
            Name = "Okno";
            Text = "Okno Wyboru";
            ((System.ComponentModel.ISupportInitialize)pictureBoxZdjecie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBook;
        private Button buttonStore;
        private Label label1;
        private Label label2;
        private Button buttonZdjecie;
        private DateTimePicker dateCzas;
        private PictureBox pictureBoxZdjecie;
        private Button buttonLista;
        private Button buttonPorownanie;
    }
}