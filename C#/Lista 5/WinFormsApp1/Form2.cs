using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Store;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

            Book o1 = new Book(textBox1.Text, textBox2.Text, Convert.ToInt32(this.textBox3.Text), textBox4.Text, "Kuba", "Miki", 233, 45);
            listBoxBook.Items.AddRange(o1.Wypisz());
        }

    }
}
