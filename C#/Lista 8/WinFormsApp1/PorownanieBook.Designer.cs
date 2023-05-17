namespace WinFormsApp1
{
    partial class PorownanieBook
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
            txtImie1 = new TextBox();
            txtImie2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonCompareData = new Button();
            txtImie = new TextBox();
            SuspendLayout();
            // 
            // txtImie1
            // 
            txtImie1.Location = new Point(251, 112);
            txtImie1.Name = "txtImie1";
            txtImie1.Size = new Size(100, 23);
            txtImie1.TabIndex = 0;
            // 
            // txtImie2
            // 
            txtImie2.Location = new Point(496, 112);
            txtImie2.Name = "txtImie2";
            txtImie2.Size = new Size(100, 23);
            txtImie2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 75);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 2;
            label1.Text = "Imie pierwsze :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(511, 76);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "Imie drugie :";
            // 
            // buttonCompareData
            // 
            buttonCompareData.Location = new Point(358, 232);
            buttonCompareData.Name = "buttonCompareData";
            buttonCompareData.Size = new Size(116, 61);
            buttonCompareData.TabIndex = 3;
            buttonCompareData.Text = "buttonPotwierdz";
            buttonCompareData.UseVisualStyleBackColor = true;
            buttonCompareData.Click += buttonPotwierdz_Click;
            // 
            // txtImie
            // 
            txtImie.Location = new Point(226, 207);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(100, 23);
            txtImie.TabIndex = 0;
            // 
            // PorownanieBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCompareData);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtImie2);
            Controls.Add(txtImie);
            Controls.Add(txtImie1);
            Name = "PorownanieBook";
            Text = "Porownanie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtImie1;
        private TextBox txtImie2;
        private Label label1;
        private Label label2;
        private Button buttonCompareData;
        private TextBox txtImie;
    }
}