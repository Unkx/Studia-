using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WinFormsApp1.Okno;

namespace WinFormsApp1
{
    public partial class Lista : Form
    {

        public static List<string> listBoxData { get; set; }
        public static List<string> listBoxData2 { get; set; }

        private List<MyClass> objectList;
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }

        public Lista()
        {
            InitializeComponent();

            objectList = new List<MyClass>();
        }

        private void buttonPoprzedni_Click(object sender, EventArgs e)
        {
            if (listBoxData != null)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(listBoxData.ToArray());

                //pictureZdjecie2.Image = new Bitmap("C:\\Users\\mi140\\OneDrive\\Pulpit\\Bez nazwy-1.jpg");//ścierzka dla laptopa
                listBox1.Items.Add(pictureZdjecie2);
                pictureZdjecie2.Visible = true;
                //pictureZdjecie2.Image = new Bitmap("C:\\Users\\mi140\\OneDrive\\Pulpit\\Bez nazwy-1.jpg");//ścierzka dla laptopa
                pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
                //pictureZdjecie2.Image = new Bitmap("C:\\Users\\mi140\\OneDrive\\Pulpit\\Bez nazwy-2.jpg");
                pictureZdjecie2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (listBoxData == null)
            {
                MessageBox.Show("Nic tu nie ma ");
            }


            pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
            //pictureZdjecie2.Image = new Bitmap("C:\\Users\\mi140\\OneDrive\\Pulpit\\Bez nazwy-2.jpg");
            pictureZdjecie2.SizeMode = PictureBoxSizeMode.StretchImage;


            pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureZdjecie2.SizeMode = PictureBoxSizeMode.StretchImage;


        }


        private void buttonNastepny_Click(object sender, EventArgs e)
        {

            if (listBoxData2 != null && listBoxData2.Count > 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(listBoxData2.ToArray());
                pictureZdjecie2.Visible = true;
                listBox1.Items.Add(pictureZdjecie2);
                pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureZdjecie2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Nic nie ma ");
            }

            if (listBox1.Items.Count > 1)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(listBoxData2.ToArray());
                pictureZdjecie2.Visible = true;
                listBox1.Items.Add(pictureZdjecie2);
                pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureZdjecie2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Nic nie ma ");
            }



            pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
            //pictureZdjecie2.Image = new Bitmap("C:\\Users\\mi140\\OneDrive\\Pulpit\\Bez nazwy-1.jpg");
            pictureZdjecie2.SizeMode = PictureBoxSizeMode.StretchImage;


            pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureZdjecie2.SizeMode = PictureBoxSizeMode.StretchImage;


        }



        //lista 8//

        private void buttonZapisz_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog.Title = "Save List to XML";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (XmlWriter writer = XmlWriter.Create(filePath))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Items");

                    foreach (var item in listBox1.Items)
                    {
                        writer.WriteStartElement("Name");
                        writer.WriteString(item.ToString());
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }

                buttonZapisz.BackColor = Color.Aqua;
                MessageBox.Show("List saved to XML successfully!");
            }
        }

        private void buttonWczytaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";
            openFileDialog.Title = "Load List from XML";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                using (XmlReader reader = XmlReader.Create(filePath))
                {
                    listBox1.Items.Clear();

                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Name")
                        {
                            reader.Read(); // Move to the text content of the element
                            listBox1.Items.Add(reader.Value);
                        }
                    }
                }
                buttonWczytaj.BackColor = Color.Azure;
                MessageBox.Show("List loaded from XML successfully!");
            }
        }
        public class MyClass : IComparable<MyClass>
        {
            public int Id { get; set; }
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public int Wiek { get; set; }

            public void Zapisz(StreamWriter writer)
            {
                writer.WriteLine(Id);
                writer.WriteLine(Imie);
                writer.WriteLine(Nazwisko);
                writer.WriteLine(Wiek);
            }

            public void Wczytaj(StreamReader reader)
            {
                Id = int.Parse(reader.ReadLine());
                Imie = reader.ReadLine();
                Nazwisko = reader.ReadLine();
                Wiek = int.Parse(reader.ReadLine());
            }

            public int CompareTo(MyClass other)
            {
                if (other == null)
                    return 1;

                // Sort by Name
                int nameComparison = Imie.CompareTo(other.Imie);
                if (nameComparison != 0)
                {
                    // If the names aren't the same, return the comparison
                    return nameComparison;
                }

                // If the names are the same, sort by Surname
                int surnameComparison = Nazwisko.CompareTo(other.Nazwisko);
                if (surnameComparison != 0)
                {
                    // If the surnames aren't the same, return the comparison
                    return surnameComparison;
                }

                // If the surnames are the same, sort by Age
                return Wiek.CompareTo(other.Wiek);
            }
        }

        public class ListBoxItem
        {
            public string Text { get; set; }
            public Image Image { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void buttonWyswietl_Click(object sender, EventArgs e)
        {
            string message = "Dane z listy:\n";
            foreach (MyClass obj in objectList)
            {
                message += "ID: " + obj.Id + ", Name: " + obj.Imie + "\n";
            }
            buttonWyswietl.BackColor = Color.CadetBlue;
            MessageBox.Show(message);
        }
        // lista 10


        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(selectedItem);

                // Usuń obiekt z listy obiektów
                MyClass selectedObject = objectList.FirstOrDefault(obj => obj.Imie == selectedItem);
                if (selectedObject != null)
                {
                    objectList.Remove(selectedObject);
                }

                MessageBox.Show("Obiekt został usunięty z listy.");
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego obiektu do usunięcia.");
            }
        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (sender == buttonSort)
            {
                SortListBox(listBoxData); // Sort listBoxData
            }
            else if (sender == buttonSort2)
            {
                SortListBox(listBoxData2); // Sort listBoxData2
            }
        }

        private void SortListBox(List<string> listBoxData)
        {
            List<string> sortedData = new List<string>();

            if (listBoxData != null)
            {
                sortedData.AddRange(listBoxData.OrderBy(item => item));
            }

            if (listBoxData2 != null)
            {
                sortedData.AddRange(listBoxData2.OrderBy(item => item));
            }

            listBox1.BeginUpdate();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(sortedData.ToArray());
            listBox1.EndUpdate();
        }



        private void buttonImie_Click(object sender, EventArgs e)
        {
            string searchPhrase = textBoxImie.Text;

            List<string> searchResults = listBox1.Items
            .OfType<string>() // Filter the items to only include strings
            .Where(item => item.ToLower().Contains(searchPhrase.ToLower()))
            .ToList();

            if (searchResults.Count > 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(searchResults.ToArray());
                MessageBox.Show($"Znaleziono {searchResults.Count} obiektów z imieniem '{searchPhrase}'.");
            }
            else
            {
                listBox1.Items.Clear();
                MessageBox.Show("Brak obiektów pasujących do podanego imienia.");
            }
        }

        private void buttonNazwisko_Click(object sender, EventArgs e)
        {
            string searchPhrase = textBoxNazwisko.Text;

            List<string> searchResults = listBox1.Items
            .OfType<string>() // Filter the items to only include strings
            .Where(item => item.ToLower().Contains(searchPhrase.ToLower()))
            .ToList();

            if (searchResults.Count > 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(searchResults.ToArray());
                MessageBox.Show($"Znaleziono {searchResults.Count} obiektów z nazwiskiem '{searchPhrase}'.");
            }
            else
            {
                listBox1.Items.Clear();
                MessageBox.Show("Brak obiektów pasujących do podanego nazwiska.");
            }
        }

        private void buttonWiek_Click(object sender, EventArgs e)
        {
            string searchPhrase = textBoxPrzeczytaneStrony.Text;

            List<string> searchResults = listBox1.Items
            .OfType<string>() // Filter the items to only include strings
            .Where(item => item.ToLower().Contains(searchPhrase.ToLower()))
            .ToList();

            if (searchResults.Count > 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(searchResults.ToArray());
                MessageBox.Show($"Znaleziono {searchResults.Count} obiektów z przeczytanymi stronami '{searchPhrase}'.");
            }
            else
            {
                listBox1.Items.Clear();
                MessageBox.Show("Brak obiektów pasujących do ilości przeczytanych stron.");
            }
        }

    }
}
