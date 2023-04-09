using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookStore
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }

        private void buttonWypisz_Click(object sender, EventArgs e)
        {
            string Imie = textBoxImie.Text;
            listBoxDane.Items.Add("Imię:\t" + Imie);
            string Nazwisko = textBoxNazwisko.Text;
            listBoxDane.Items.Add(Nazwisko);
            string Tytul = textBoxTytul.Text;
            listBoxDane.Items.Add(Tytul);
            string Strony = textBoxStrony.Text;
            listBoxDane.Items.Add(Strony);
            string Kolor = textBoxKolor.Text;
            listBoxDane.Items.Add(Kolor);




            labelDane.Visible = true;
            listBoxDane.Visible = true;

        }


    }
}
