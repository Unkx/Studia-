using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Security.Cryptography.X509Certificates;
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

        private void buttonZatwierdz_Click(object sender, EventArgs e)
        {
            Store o1 = new Store(txtImie.Text, txtNazwisko.Text, Convert.ToInt32(this.txtWiek.Text), txtAdres.Text, Convert.ToInt32(this.txtKoszyk.Text), txtUlubionyAutor.Text, txtUlubionaKsiazka.Text, txtKupionaKsiazka.Text, Convert.ToInt32(this.txtRokWydania.Text), Convert.ToInt32(this.txtPrzeczytaneStrony.Text), Convert.ToInt32(txtKsiazki.Text), Convert.ToInt32(txtPracownicy.Text), txtSklep.Text, txtEmail.Text);
            listBoxStore.Items.AddRange(o1.Wypisz());
            listBoxStore.Items.Add(dateTimePicker1.ToString());
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            listBoxStore.Items.Add(DateTime.Now.ToString("dd.MM.yy.hh.mm.ss"));
           
            dateTimePicker1.CustomFormat = "dd,MM,yy,hh,mm,ss";
        }

    }
}
