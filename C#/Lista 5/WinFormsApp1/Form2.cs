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

        private void buttonZaladuj_Click(object sender, System.EventArgs e)
        {

            Book o1 = new Book(txtImie.Text, txtNazwisko.Text, Convert.ToInt32(this.txtWiek.Text), txtAdres.Text, Convert.ToInt32(this.txtKoszyk.Text), txtUlubionyAutor.Text, txtUlubionaKsiazka.Text, txtKupionaKsiazka.Text, Convert.ToInt32(this.txtRokWydania.Text), Convert.ToInt32(this.txtPrzeczytaneStrony.Text), txtImieAutora.Text, txtNazwiskoAutora.Text, txtTytul.Text, Convert.ToInt32(this.txtRokWyd.Text), Convert.ToInt32(this.txtPrzeczytaneKs.Text));
            listBoxBook.Items.AddRange(o1.Wypisz());
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            listBoxBook.Items.Add(DateTime.Now.ToString("dd,MM,yy,hh,mm,ss"));
            //listBoxBook.Add(dateTimePicker1.Value = DateTime.Now);
            dateTimePicker1.CustomFormat = "dd,MM,yy,hh,mm,ss";
            //załaduj date do listBoxa 
        }
    }
}
