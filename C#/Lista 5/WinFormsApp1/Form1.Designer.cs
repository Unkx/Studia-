namespace WinFormsApp1
{
    partial class Form1
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
            SuspendLayout();
            // 
            // buttonBook
            // 
            buttonBook.Location = new Point(145, 261);
            buttonBook.Name = "buttonBook";
            buttonBook.Size = new Size(162, 59);
            buttonBook.TabIndex = 0;
            buttonBook.Text = "button1";
            buttonBook.UseVisualStyleBackColor = true;
            buttonBook.Click += buttonBook_Click;
            // 
            // buttonStore
            // 
            buttonStore.Location = new Point(515, 259);
            buttonStore.Name = "buttonStore";
            buttonStore.Size = new Size(180, 61);
            buttonStore.TabIndex = 1;
            buttonStore.Text = "button1";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonStore);
            Controls.Add(buttonBook);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBook;
        private Button buttonStore;
        private Label label1;
        private Label label2;
    }
}