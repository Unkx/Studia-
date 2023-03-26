using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie
{
    public partial class Form3 : Form
    {


        public Form3()
        {
            InitializeComponent();
        }

        private void buttonPodajLiczbe_Click(object sender, EventArgs e)
        {
            int Liczba;


                if (Int32.TryParse(txtLiczba.Text, out Liczba))
                {
                    for (int i = 1; i <= Liczba; i++)
                    {
                        string wiersz = new string(Liczba, i).PadLeft(Liczba + i - 1);
                        listBox1.Items.Add(wiersz);
                    }
                }
                else
                {
                    MessageBox.Show("Niepoprawna wartość.");
                }
            }



        }
}

