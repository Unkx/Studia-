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
using static WinFormsApp1.Okno;

namespace WinFormsApp1
{
    public partial class Lista : Form
    {
        public static List<string> listBoxData { get; set; }
        public static List<string> listBoxData2 { get; set; }

        private List<MyClass> objectList;
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

            if (listBoxData2 != null && listBoxData2.Count >0)
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
                // Implement comparison logic based on the selected field (name, surname, or age)
                // Modify the conditions as per your sorting requirements

                if (other == null)
                    return 1;

                // Sort by Name
                return Imie.CompareTo(other.Imie);

                // Sort by Surname
                return Nazwisko.CompareTo(other.Nazwisko);

                // Sort by Age
                 return Wiek.CompareTo(other.Wiek);
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

        private void buttonSortImie_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 1) // Sprawdź, czy jest więcej niż jeden element
            {
                objectList = objectList.OrderBy(obj => obj.Imie).ToList();
                RefreshList();
            }
        }

        private void buttonSortNazwisko_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 1) // Sprawdź, czy jest więcej niż jeden element
            {
                objectList = objectList.OrderBy(obj => obj.Nazwisko).ToList();
                RefreshList();
            }
        }

        private void buttonSortWiek_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 1) // Sprawdź, czy jest więcej niż jeden element
            {
                objectList = objectList.OrderBy(obj => obj.Wiek).ToList();
                RefreshList();
            }
        }

        private void RefreshList()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(objectList.Select(obj => $"{obj.Imie} {obj.Nazwisko} ({obj.Wiek})").ToArray());
        }


    }
}
