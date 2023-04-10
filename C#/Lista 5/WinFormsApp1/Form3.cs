using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Store o1 = new Store(textBox1.Text, textBox2.Text, Convert.ToInt32(this.textBox3.Text), textBox4.Text, 200, "Księgarnia Maciej", "insert_email@mailbox.com");
            listBoxStore.Items.AddRange(o1.Wypisz());
        }
    }
}
