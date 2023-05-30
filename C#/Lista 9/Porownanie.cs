using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_5
{
    public partial class Porownanie : Form
    {
        public Porownanie()
        {
            InitializeComponent();
        }

        private void buttonPorownanie_Click(object sender, EventArgs e)
        {
            Book book1 = new Book("Jan" ,"XY", 18,"Opole",3,"Kamil","Kraina","Harry",2002,233,dateCzas.Value,"Andrzej","XTS","Mlecz",2010,244);
            Book book2 = new Book("Jan", "XY", 18, "Opole", 3, "Kamil", "Kraina", "Harry", 2002, 233, dateCzas.Value, "Marek", "FWQ", "Mlecz", 2010, 244);
            if (book1 == book2)
            {
                // Books are equal
                MessageBox.Show("The books are equal.");
            }
            else
            {
                // Books are not equal
                MessageBox.Show("The books are not equal.");
            }
        }
    }
}
