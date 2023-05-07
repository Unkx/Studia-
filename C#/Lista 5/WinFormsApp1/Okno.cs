using Lista_5;

namespace WinFormsApp1
{
    public partial class Okno : Form
    {
        List<Bookstore> BookstoreList = new List<Bookstore>();

        public Okno()
        {
            InitializeComponent();
            // dodanie obiektów do listy
            //BookstoreList.Add(new Book());
            BookstoreList.Add(new Store());

            // utworzenie przycisku do otwierania nowej formatki
            Button viewObjectsButton = new Button();
            viewObjectsButton.Text = "View Objects";
            viewObjectsButton.Click += new EventHandler(ViewObjectsButton_Click);
            this.Controls.Add(viewObjectsButton);
        }

        private void ViewObjectsButton_Click(object sender, EventArgs e)
        {
            // otwarcie nowej formatki
            Form1 objectsForm = new Form1(BookstoreList);
            objectsForm.ShowDialog();
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
