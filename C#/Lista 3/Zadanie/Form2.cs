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
        int a = 1;
        int b = 0;
        private void LiczbaCalkowita_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (Int32.TryParse(txtLiczba.Text, out int x))
            {
                //MessageBox.Show("Podano nieprawidłowe dane");
                //}

                string wierszabc = "";

                for (int wiersze = 0; wiersze <= x; wiersze++)
                {
                    for (int kolumny = 0; kolumny <= x; kolumny++)
                    {
                        wierszabc = wierszabc + Convert.ToString(a);
                        Zamien();
                    }
                    if (x % 2 != 0)
                    {
                        Zamien();
                    }
                    listBox1.Items.Add(wierszabc);
                    listBox1.Visible = true;
                    wierszabc = "";
                }
            }


            void Zamien()
            {
                int c;
                c = a;
                a = b;
                b = c;
            }

        }


    }

}
