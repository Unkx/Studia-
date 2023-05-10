using System.Net;
using System.Windows.Forms;
using static Bookstore;

namespace WinFormsApp1
{

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
        }


    }
}







