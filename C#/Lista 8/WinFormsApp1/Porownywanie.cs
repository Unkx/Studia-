using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Porownywanie : Form
    {
        public static List<string> listBoxData { get; set; }
        public static List<string> listBoxData2 { get; set; }
        public Porownywanie()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxData != null)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(listBoxData.ToArray());

            }
            else if (listBoxData == null)
            {
                MessageBox.Show("Nic tu nie ma ", "Wypierdalaj kutasie krzywy");
            }

        }


        private void buttonFormatka2_Click(object sender, EventArgs e)
        {

            if (listBoxData2 != null)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(listBoxData2.ToArray());

            }
            else if (listBoxData2 == null)
            {
                MessageBox.Show("Nic nie ma ", "Chuj ci w dupe kurwo");
            }
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            Sklep form3 = new Sklep();

            // Show Form2 as a dialog
            DialogResult result = form3.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormPor form5 = new FormPor();
            form5.ShowDialog();
        }
    }
}

