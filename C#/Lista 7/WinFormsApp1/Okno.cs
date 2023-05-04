using System;
using static Bookstore;

namespace WinFormsApp1
{
    public partial class Okno : Form
    {
        BookForm formBookForm = new BookForm(); //tworzymy OBIEKT formatki s³u¿¹cej do dodawania
                                                //nowych studentów do listy listP
        Sklep formBook = new Sklep(); //tworzymy OBIEKT formatki s³u¿¹cej do dodawania

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
            PhotoClass photoObj = new PhotoClass("http://i.imgur.com/7ikw7ye.png");

            // Create a PictureBox control to display the photo
            pictureBox3 = new PictureBox();
            pictureBox3.Image = photoObj.Photo;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.Dock = DockStyle.Fill;

            // Add the PictureBox control to the form
            Controls.Add(pictureBox3);
        }

        static void Photo()
        {
            Application.EnableVisualStyles();
            Application.Run(new Okno());
        }


    }
}








