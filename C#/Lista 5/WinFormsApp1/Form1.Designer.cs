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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStore);
            Controls.Add(buttonBook);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBook;
        private Button buttonStore;
    }
}