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
            pictureBox1.ImageLocation = "http://i.imgur.com/7ikw7ye.png";
            //pictureBox1.ImageLocation = "C:\\Users\\mi140\\OneDrive\\Pulpit";
            pictureBox1.Load();

        }
    }

}
