using static Bookstore;

namespace WinFormsApp1
{
    public partial class Okno : Form
    {
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

            //PhotoClass photoObj = new PhotoClass("http://i.imgur.com/7ikw7ye.png");
            pictureBoxZdjecie.Visible = true;
            // Create a PictureBox control to display the photo
            pictureBoxZdjecie = new PictureBox();
            //pictureBoxZdjecie.Image = photoObj.Photo;
            pictureBoxZdjecie.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxZdjecie.Dock = DockStyle.Fill;

            // Add the PictureBox control to the form
            Controls.Add(pictureBoxZdjecie);
        }




    }
}







