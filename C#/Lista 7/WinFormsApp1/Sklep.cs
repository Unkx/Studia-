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
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class Sklep : Form
    {
        public Sklep()
        {
            InitializeComponent();
        }
        private void buttonUzupelnij_Click(object sender, EventArgs e)
        {
            txtImie.Text = "Jan";
            txtNazwisko.Text = "Masło";
            txtWiek.Text = "18";
            txtAdres.Text = "Oleska, Opole";
            txtKoszyk.Text = "20";

            txtUlubionyAutor.Text = "Adam Mickiewicz";
            txtUlubionaKsiazka.Text = "Pan Tadeusz";
            txtKupionaKsiazka.Text = "Auta BmVV";
            txtRokWydania.Text = "2021";
            txtPrzeczytaneStrony.Text = "21";
            txtKsiazki.Text = "2000";
            txtPracownicy.Text = "100";
            txtSklep.Text = "Księgarnia X";
            txtEmail.Text = "KsięgarniaX.com";


        }
        private void ClearTextBoxes()
        {
            txtImie.Clear();
            txtNazwisko.Clear();
            txtWiek.Clear();
            txtAdres.Clear();
            txtKoszyk.Clear();

            txtUlubionyAutor.Clear();
            txtUlubionaKsiazka.Clear();
            txtKupionaKsiazka.Clear();
            txtRokWydania.Clear();
            txtPrzeczytaneStrony.Clear();
            txtKsiazki.Clear();
            txtPracownicy.Clear();
            txtSklep.Clear();
            txtEmail.Clear();

        }

        private void buttonZatwierdz_Click(object sender, EventArgs e)
        {

            Store s1 = new Store(txtImie.Text, txtNazwisko.Text, Convert.ToInt32(this.txtWiek.Text), txtAdres.Text, Convert.ToInt32(this.txtKoszyk.Text), txtUlubionyAutor.Text, txtUlubionaKsiazka.Text, txtKupionaKsiazka.Text, Convert.ToInt32(this.txtRokWydania.Text), Convert.ToInt32(this.txtPrzeczytaneStrony.Text), dateCzas.Value, Convert.ToInt32(txtKsiazki.Text), Convert.ToInt32(txtPracownicy.Text), txtPracownicy.Text, txtEmail.Text);
            //listBoxStore.Items.AddRange(o1.Wypisz());

            Okno.listP.Add(s1); //dodanie obiektu do listy
            listBoxStore.Items.Clear(); //wyczyszczenie listBoxa
            //listBoxStore.Items.Add("NOWY STUDENT ZOSTAŁ DODANY DO LISTY: ");
            Okno.listP[Okno.listP.Count - 1].Wypisz(listBoxStore);
            ClearTextBoxes(); //wyczyszczenie pól tekstowych i innych elementów

            Lista.listBoxData = new List<string>();
            foreach (var item in listBoxStore.Items)
            {
                Lista.listBoxData.Add(item.ToString());
            }

            Lista form4 = new Lista();
            pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureZdjecie2.Image = new Bitmap("C:\\Users\\mi140\\OneDrive\\Pulpit\\Bez nazwy-1.jpg");
        }
    }
}

