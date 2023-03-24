using System;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private int _liczba;

        public int liczba
        {
            get { return _liczba; }
            set { _liczba = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int Liczba;
            if (Int32.TryParse(txtLiczba.Text, out Liczba))
            {

                for (int i = 1; i <= Liczba; i++)
                {
                    if (Liczba % i == 0)
                    {
                        Console.Write(i + " ");
                        MessageBox.Show(i + " ");
                    }
                }
            }
            else
            {
                MessageBox.Show("Podaj liczbê");
            }

        }


    }
}