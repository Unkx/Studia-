using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Net.Mime.MediaTypeNames;

namespace Zadanie
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void LiczbaCalkowita_Click(object sender, EventArgs e)
        {
            int Liczba;
            if (Int32.TryParse(txtLiczba.Text, out Liczba))
            {
                for (int i = 1; i <= Liczba; i++)
                {
                    if (Liczba >= i)
                    {
                        listBox1.Visible = true;
                        listBox1.Items.Add("0" + "x" + "1");

                    }
                }

            }
            else
            {
                MessageBox.Show("Podaj liczbę");
            }


        }
    }
}
