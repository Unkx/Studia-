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
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // buttonFormatka1
            // 
            buttonFormatka1.Location = new Point(46, 79);
            buttonFormatka1.Name = "buttonFormatka1";
            buttonFormatka1.Size = new Size(186, 66);
            buttonFormatka1.TabIndex = 0;
            buttonFormatka1.Text = "buttonFormatka1";
            buttonFormatka1.UseVisualStyleBackColor = true;
            buttonFormatka1.Click += button1_Click;
            // 
            // buttonFormatka2
            // 
            buttonFormatka2.Location = new Point(46, 215);
            buttonFormatka2.Name = "buttonFormatka2";
            buttonFormatka2.Size = new Size(186, 66);
            buttonFormatka2.TabIndex = 1;
            buttonFormatka2.Text = "Oponeo";
            buttonFormatka2.UseVisualStyleBackColor = true;
            buttonFormatka2.Click += buttonFormatka2_Click;
            // 
            // buttonClick
            // 
            buttonClick.Location = new Point(383, 335);
            buttonClick.Name = "buttonClick";
            buttonClick.Size = new Size(75, 23);
            buttonClick.TabIndex = 2;
            buttonClick.Text = "Click";
            buttonClick.UseVisualStyleBackColor = true;
            buttonClick.Click += buttonClick_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(255, 21);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(228, 289);
            listBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(643, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // Porownywanie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(listBox1);
            Controls.Add(buttonClick);
            Controls.Add(buttonFormatka2);
            Controls.Add(buttonFormatka1);
            Name = "Porownywanie";
            Text = "Porownywanie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFormatka1;
        private Button buttonFormatka2;
        private Button buttonClick;
        private ListBox listBox1;
        private TextBox textBox2;
    }
}