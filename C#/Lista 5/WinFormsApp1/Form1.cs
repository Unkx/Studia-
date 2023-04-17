namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonBook_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }


        private void buttonStore_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();

        }

        private void buttonZdjecie_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "http://i.imgur.com/7ikw7ye.png";
            pictureBox1.Load();

        }
    }

}
