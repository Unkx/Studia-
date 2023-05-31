using Lista_5;
using System;
using static Bookstore;

namespace WinFormsApp1
{
    public partial class Okno : Form
    {
        BookForm BookForm = new BookForm(); //tworzymy OBIEKT formatki s³u¿¹cej do dodawania
                                            //nowych studentów do listy listP
        Sklep formBook = new Sklep(); //tworzymy OBIEKT formatki s³u¿¹cej do dodawania

        Lista Lista = new Lista();

        Porownanie Porownanie = new Porownanie();

        public static List<Bookstore> listP = new List<Bookstore>();
        //lista 8//
        private List<MyClass> objectList;

        public int Pole1 { get; set; }
        public string Pole2 { get; set; }

        public Okno()
        {
            InitializeComponent();

            objectList = new List<MyClass>();
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




        private void buttonPorownanie_Click(object sender, EventArgs e)
        {
            Porownanie form5 = new Porownanie();
            form5.ShowDialog();
        }


        //lista 8//





        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("C:\\Users\\mi140\\OneDrive\\Pulpit\\chuj.txt");
            writer.WriteLine("Poniedzia³ek"); //zapisz liniê z podanym tekstem do pliku
            writer.Close();



            /*SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.Title = "Save List to File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (MyClass obj in objectList)
                    {
                        obj.Zapisz(writer);
                    }
                }

                MessageBox.Show("List saved to file successfully!");
            }*/
        }

        private void buttonWczytaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog.Title = "Load List from File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                using (StreamReader reader = new StreamReader(filePath))
                {
                    objectList.Clear();

                    while (!reader.EndOfStream)
                    {
                        MyClass obj = new MyClass();
                        obj.Wczytaj(reader);
                        objectList.Add(obj);
                    }
                }

                MessageBox.Show("List loaded from file successfully!");

            }
        }

        public class MyClass
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public void Zapisz(StreamWriter writer)
            {
                writer.WriteLine(Id);
                writer.WriteLine(Name);
            }

            public void Wczytaj(StreamReader reader)
            {
                Id = int.Parse(reader.ReadLine());
                Name = reader.ReadLine();
            }
        }

        private void buttonWyswietl_Click(object sender, EventArgs e)
        {

            string message = "Dane z listy:\n";
            foreach (MyClass obj in objectList)
            {
                message += "ID: " + obj.Id + ", Name: " + obj.Name + "\n";
            }

            MessageBox.Show(message);
        }

    }
}









