﻿namespace WinFormsApp1
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
            buttonBook.Location = new Point(166, 348);
            buttonBook.Margin = new Padding(3, 4, 3, 4);
            buttonBook.Name = "buttonBook";
            buttonBook.Size = new Size(185, 79);
            buttonBook.TabIndex = 0;
            buttonBook.Text = "Kliknij";
            buttonBook.UseVisualStyleBackColor = true;
            buttonBook.Click += buttonBook_Click;
            // 
            // buttonStore
            // 
            buttonStore.Location = new Point(589, 345);
            buttonStore.Margin = new Padding(3, 4, 3, 4);
            buttonStore.Name = "buttonStore";
            buttonStore.Size = new Size(206, 81);
            buttonStore.TabIndex = 1;
            buttonStore.Text = "Kliknij";
            buttonStore.UseVisualStyleBackColor = true;
            buttonStore.Click += buttonStore_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 284);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 2;
            label1.Text = "Dane o Książce";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(671, 284);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 3;
            label2.Text = "Sklep";
            // 
            // buttonZdjecie
            // 
            buttonZdjecie.Location = new Point(95, 135);
            buttonZdjecie.Name = "buttonZdjecie";
            buttonZdjecie.Size = new Size(125, 64);
            buttonZdjecie.TabIndex = 0;
            buttonZdjecie.Text = "Wyświetl zdj";
            buttonZdjecie.Click += buttonZdjecie_Click;
            // 
            // dateCzas
            // 
            dateCzas.Format = DateTimePickerFormat.Custom;
            dateCzas.Location = new Point(325, 12);
            dateCzas.Name = "dateCzas";
            dateCzas.Size = new Size(266, 27);
            dateCzas.TabIndex = 5;
            dateCzas.Value = new DateTime(2023, 4, 19, 0, 0, 0, 0);
            // 
            // pictureBoxZdjecie
            // 
            pictureBoxZdjecie.BackColor = SystemColors.ActiveCaptionText;
            pictureBoxZdjecie.Image = (Image)resources.GetObject("pictureBoxZdjecie.Image");
            pictureBoxZdjecie.Location = new Point(325, 111);
            pictureBoxZdjecie.Margin = new Padding(3, 4, 3, 4);
            pictureBoxZdjecie.Name = "pictureBoxZdjecie";
            pictureBoxZdjecie.Size = new Size(280, 169);
            pictureBoxZdjecie.TabIndex = 6;
            pictureBoxZdjecie.TabStop = false;
            pictureBoxZdjecie.Visible = false;
            // 
            // buttonLista
            // 
            buttonLista.Location = new Point(282, 479);
            buttonLista.Name = "buttonLista";
            buttonLista.Size = new Size(178, 59);
            buttonLista.TabIndex = 7;
            buttonLista.Text = "Lista";
            buttonLista.UseVisualStyleBackColor = false;
            buttonLista.Click += buttonLista_Click;
            // 
            // buttonPorownanie
            // 
            buttonPorownanie.Location = new Point(544, 479);
            buttonPorownanie.Margin = new Padding(3, 4, 3, 4);
            buttonPorownanie.Name = "buttonPorownanie";
            buttonPorownanie.Size = new Size(178, 59);
            buttonPorownanie.TabIndex = 8;
            buttonPorownanie.Text = "Porownanie";
            buttonPorownanie.UseVisualStyleBackColor = true;
            buttonPorownanie.Click += buttonPorownanie_Click;
            // 
            // Okno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonPorownanie);
            Controls.Add(buttonLista);
            Controls.Add(pictureBoxZdjecie);
            Controls.Add(dateCzas);
            Controls.Add(buttonZdjecie);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonStore);
            Controls.Add(buttonBook);
            Margin = new Padding(3, 4, 3, 4);
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