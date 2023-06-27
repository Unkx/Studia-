namespace Lista_5
{
    partial class Porownanie
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
            dateCzas = new DateTimePicker();
            buttonPorownanie = new Button();
            SuspendLayout();
            // 
            // dateCzas
            // 
            dateCzas.Location = new Point(303, 82);
            dateCzas.Name = "dateCzas";
            dateCzas.Size = new Size(200, 23);
            dateCzas.TabIndex = 0;
            // 
            // buttonPorownanie
            // 
            buttonPorownanie.Location = new Point(327, 230);
            buttonPorownanie.Name = "buttonPorownanie";
            buttonPorownanie.Size = new Size(143, 89);
            buttonPorownanie.TabIndex = 1;
            buttonPorownanie.Text = "Porownaj dane";
            buttonPorownanie.UseVisualStyleBackColor = true;
            buttonPorownanie.Click += buttonPorownanie_Click;
            // 
            // Porownanie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonPorownanie);
            Controls.Add(dateCzas);
            Name = "Porownanie";
            Text = "Porownanie";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateCzas;
        private Button buttonPorownanie;
    }
}