using System.Net;
using System.Windows.Forms;
using static Bookstore;

namespace WinFormsApp1
{

<<<<<<< HEAD
=======

>>>>>>> 25b8928c75a7f0908a89092c37d61efabbc4c2d5
    public partial class Okno : Form
    {
        private PhotoClass photoObj;
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
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.Title = "Select an image file";

<<<<<<< HEAD
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    photoObj = new PhotoClass(openFileDialog.FileName);
                    pictureBoxZdjecie.Image = photoObj.Photo;
                }
            }
        }
=======
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


>>>>>>> 25b8928c75a7f0908a89092c37d61efabbc4c2d5
    }

}







