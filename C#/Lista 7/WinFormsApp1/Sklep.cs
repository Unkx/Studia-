using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Sklep : Form
    {
        public Sklep()
        {
            InitializeComponent();
        }
        private void ClearTextBoxes()
        {
            txtNazwisko.Clear();
            txtImie.Clear();
            txtKoszyk.Clear();

        }

        private void buttonZatwierdz_Click(object sender, EventArgs e)
        {

            Store s1 = new Store(txtImie.Text, txtNazwisko.Text, Convert.ToInt32(this.txtWiek.Text), txtAdres.Text, Convert.ToInt32(this.txtKoszyk.Text), txtUlubionyAutor.Text, txtUlubionaKsiazka.Text, txtKupionaKsiazka.Text, Convert.ToInt32(this.txtRokWydania.Text), Convert.ToInt32(this.txtPrzeczytaneStrony.Text),dateCzas.Value, Convert.ToInt32(txtKsiazki.Text), Convert.ToInt32(txtPracownicy.Text), txtSklep.Text, txtEmail.Text);
            //listBoxStore.Items.AddRange(o1.Wypisz());

            Okno.listP.Add(s1); //dodanie obiektu do listy
            listBoxStore.Items.Clear(); //wyczyszczenie listBoxa
            listBoxStore.Items.Add("NOWY STUDENT ZOSTAŁ DODANY DO LISTY: ");
            Okno.listP[Okno.listP.Count - 1].Wypisz(listBoxStore);
            ClearTextBoxes(); //wyczyszczenie pól tekstowych i innych elementów
        }





    }
}
