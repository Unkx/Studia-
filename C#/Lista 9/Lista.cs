using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

                pictureZdjecie2.Visible = true;
                pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
                //pictureZdjecie2.Image = new Bitmap("C:\\Users\\mi140\\OneDrive\\Pulpit\\Bez nazwy-2.jpg");
                pictureZdjecie2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (listBoxData == null)
            {
                MessageBox.Show("Nic tu nie ma ");
            }

            listBox1.Items.AddRange(listBoxData.ToArray());

            pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
            //pictureZdjecie2.Image = new Bitmap("C:\\Users\\mi140\\OneDrive\\Pulpit\\Bez nazwy-2.jpg");
            pictureZdjecie2.SizeMode = PictureBoxSizeMode.StretchImage;


        }


        private void buttonNastepny_Click(object sender, EventArgs e)
        {

            if (listBoxData2 != null)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(listBoxData2.ToArray());
                pictureZdjecie2.Visible = true;
                pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
                //pictureZdjecie2.Image = new Bitmap("C:\\Users\\mi140\\OneDrive\\Pulpit\\Bez nazwy-1.jpg");
                pictureZdjecie2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (listBoxData2 == null)
            {
                MessageBox.Show("Nic nie ma ");
            }

            listBox1.Items.AddRange(listBoxData2.ToArray());

            pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
            //pictureZdjecie2.Image = new Bitmap("C:\\Users\\mi140\\OneDrive\\Pulpit\\Bez nazwy-1.jpg");
            pictureZdjecie2.SizeMode = PictureBoxSizeMode.StretchImage;

        }



        //lista 8//

        private void buttonZapisz_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
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
            }
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
