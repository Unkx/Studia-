using System;
using static Bookstore;

namespace WinFormsApp1
{
    public partial class Okno : Form
    {
        BookForm formBookForm = new BookForm(); //tworzymy OBIEKT formatki s³u¿¹cej do dodawania
                                                //nowych studentów do listy listP
        Sklep formBook = new Sklep(); //tworzymy OBIEKT formatki s³u¿¹cej do dodawania

        Lista Lista = new Lista();

        Porownywanie Porownywanie = new Porownywanie();

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

        private void buttonPorownywanie_Click(object sender, EventArgs e)
        {
            Porownywanie form5 = new Porownywanie();
            form5.ShowDialog();
        }

        /*private void buttonZdjecie_Click(object sender, EventArgs e)
{
using (OpenFileDialog openFileDialog = new OpenFileDialog())
{
openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
openFileDialog.Title = "Select an image file";

if (openFileDialog.ShowDialog() == DialogResult.OK)
{
  try
  {
      photoObj = new PhotoClass(openFileDialog.FileName);
      pictureBoxZdjecie.Image = photoObj.Photo;
  }
  catch (Exception ex)
  {
      MessageBox.Show("Error loading photo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
  }
}
}
}*/
    }
}








