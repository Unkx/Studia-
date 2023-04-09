namespace BookStore
{
    public partial class BookStore : Form
    {
        public BookStore()
        {
            InitializeComponent();
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            Book form2 = new Book();
            form2.ShowDialog();
        }
    }
}