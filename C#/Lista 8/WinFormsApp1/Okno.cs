using Lista_5;
using System;
using static Bookstore;

namespace WinFormsApp1
{
    public partial class Okno : Form
    {
        BookForm BookForm = new BookForm(); //tworzymy OBIEKT formatki s�u��cej do dodawania
                                            //nowych student�w do listy listP
        Sklep formBook = new Sklep(); //tworzymy OBIEKT formatki s�u��cej do dodawania

        Lista Lista = new Lista();
        
        Porownanie Porownanie = new Porownanie();  

<<<<<<< HEAD
        Porownywanie Porownywanie = new Porownywanie();
=======
>>>>>>> ecc2faf91635b10d71a1bcf475654a13e3091659

        public static List<Bookstore> listP = new List<Bookstore>();

        public Okno()
        {
            InitializeComponent();

        }
        private void buttonBook_Click(object sender, EventArgs e)
        {
            BookForm form2 = new BookForm();
            form2.ShowDialog();

        }


        private void buttonStore_Click(object sender, EventArgs e)
        {
            Sklep form3 = new Sklep();
            form3.ShowDialog();

        }


        private void buttonZdjecie_Click(object sender, EventArgs e)
        {
            // Create an instance of PhotoClass and load the photo

            PhotoClass photoObj = new PhotoClass("bez-nazwy1");
            Image myPhoto = photoObj.Photo;
            pictureBoxZdjecie.Visible = true;
            // Create a PictureBox control to display the photo
            pictureBoxZdjecie = new PictureBox();
            //pictureBoxZdjecie.Image = photoObj.Photo;
            pictureBoxZdjecie.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxZdjecie.Dock = DockStyle.Fill;

            // Add the PictureBox control to the form
            Controls.Add(pictureBoxZdjecie);


        }

        private void buttonLista_Click(object sender, EventArgs e)
        {
            Lista form4 = new Lista();
            form4.ShowDialog();
        }

<<<<<<< HEAD
        private void button1_Click(object sender, EventArgs e)
        {
            Porownywanie form5 = new Porownywanie();
=======
        private void buttonPorownanie_Click(object sender, EventArgs e)
        {
            Porownanie form5 = new Porownanie();
>>>>>>> ecc2faf91635b10d71a1bcf475654a13e3091659
            form5.ShowDialog();
        }
    }
}








