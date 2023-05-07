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
            buttonBook = new Button();
            buttonStore = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            buttonZdjecie = new Button();
            dateCzas = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(254, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(432, 216);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
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
            dateCzas.Location = new Point(324, 12);
            dateCzas.Name = "dateCzas";
            dateCzas.Size = new Size(266, 27);
            dateCzas.TabIndex = 5;
            dateCzas.Value = new DateTime(2023, 4, 19, 0, 0, 0, 0);
            // 
            // Okno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dateCzas);
            Controls.Add(buttonZdjecie);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonStore);
            Controls.Add(buttonBook);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Okno";
            Text = "Okno Wyboru";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBook;
        private Button buttonStore;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button buttonZdjecie;
        private DateTimePicker dateCzas;
    }
}