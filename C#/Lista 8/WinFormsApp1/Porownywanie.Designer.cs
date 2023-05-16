namespace WinFormsApp1
{
    partial class Porownywanie
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
            buttonFormatka1 = new Button();
            buttonFormatka2 = new Button();
            buttonClick = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            buttonOkno = new Button();
            SuspendLayout();
            // 
            // buttonFormatka1
            // 
            buttonFormatka1.Location = new Point(53, 105);
            buttonFormatka1.Margin = new Padding(3, 4, 3, 4);
            buttonFormatka1.Name = "buttonFormatka1";
            buttonFormatka1.Size = new Size(213, 88);
            buttonFormatka1.TabIndex = 0;
            buttonFormatka1.Text = "buttonFormatka1";
            buttonFormatka1.UseVisualStyleBackColor = true;
            buttonFormatka1.Click += button1_Click;
            // 
            // buttonFormatka2
            // 
            buttonFormatka2.Location = new Point(53, 287);
            buttonFormatka2.Margin = new Padding(3, 4, 3, 4);
            buttonFormatka2.Name = "buttonFormatka2";
            buttonFormatka2.Size = new Size(213, 88);
            buttonFormatka2.TabIndex = 1;
            buttonFormatka2.Text = "Oponeo";
            buttonFormatka2.UseVisualStyleBackColor = true;
            buttonFormatka2.Click += buttonFormatka2_Click;
            // 
            // buttonClick
            // 
            buttonClick.Location = new Point(438, 447);
            buttonClick.Margin = new Padding(3, 4, 3, 4);
            buttonClick.Name = "buttonClick";
            buttonClick.Size = new Size(86, 31);
            buttonClick.TabIndex = 2;
            buttonClick.Text = "Click";
            buttonClick.UseVisualStyleBackColor = true;
            buttonClick.Click += buttonClick_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(291, 28);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(260, 384);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(591, 53);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(203, 344);
            listBox2.TabIndex = 5;
            // 
            // buttonOkno
            // 
            buttonOkno.Location = new Point(808, 226);
            buttonOkno.Name = "buttonOkno";
            buttonOkno.Size = new Size(94, 29);
            buttonOkno.TabIndex = 6;
            buttonOkno.Text = "button1";
            buttonOkno.UseVisualStyleBackColor = true;
            buttonOkno.Click += button1_Click_1;
            // 
            // Porownywanie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonOkno);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(buttonClick);
            Controls.Add(buttonFormatka2);
            Controls.Add(buttonFormatka1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Porownywanie";
            Text = "Porownywanie";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonFormatka1;
        private Button buttonFormatka2;
        private Button buttonClick;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button buttonOkno;
    }
}