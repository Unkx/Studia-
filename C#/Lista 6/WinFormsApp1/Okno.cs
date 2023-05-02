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
            Text = "Photo Viewer";
            ClientSize = new Size(300, 300);

            // Create an instance of PhotoClass and load the photo
            PhotoClass photoObj = new PhotoClass("http://i.imgur.com/7ikw7ye.png");

            // Create a PictureBox control to display the photo
            pictureBox2 = new PictureBox();
            pictureBox2.Image = photoObj.Photo;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Dock = DockStyle.Fill;

            // Add the PictureBox control to the form
            Controls.Add(pictureBox2);
        }

        static void Photo()
        {
            Application.EnableVisualStyles();
            Application.Run(new Okno());
        }
    }
}







