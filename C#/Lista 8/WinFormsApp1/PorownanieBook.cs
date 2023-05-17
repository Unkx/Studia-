using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static WinFormsApp1.BookForm;

namespace WinFormsApp1
{
    public partial class PorownanieBook : Form
    {
        private BookForm bookForm;

        public PorownanieBook()
        {
            InitializeComponent();

            this.bookForm = bookForm;

            //this.bookForm.DataComparisonRequested += CompareData;
        }

        private void buttonPotwierdz_Click(object sender, EventArgs e)
        {
            /*if (txtImie1.Text == txtImie2.Text)
            {
                MessageBox.Show("Sklep objects are equal.");
            }
            else if (txtImie1.Text != txtImie2.Text)
            {
                MessageBox.Show("Sklep objects are not equal.");
            }*/
            Load data from listBoxBook and compare it ....

            string textBoxText = txtImie.Text;

            if ( txtImie.Text == textBoxText)
            {
                // The data matches
                MessageBox.Show("The data matches!");
            }
            else
            {
                // The data does not match
                MessageBox.Show("The data does not match!");
            }



        }



        private BookForm BookForm;


        // Event handler for data comparison
        public void buttonCompareData_Click(object sender, DataComparisonEventArgs e)
        {
            string textBoxText = txtImie.Text;

            if (e.SelectedItem == textBoxText)
            {
                // The data matches
                MessageBox.Show("The data matches!");
            }
            else
            {
                // The data does not match
                MessageBox.Show("The data does not match!");
            }
        }



    }
}
