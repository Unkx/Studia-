using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Lista : Form
    {
        public static List<string> listBoxData { get; set; }
        public static List<string> listBoxData2 { get; set; }
        public Lista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxData != null)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(listBoxData.ToArray());

                pictureZdjecie2.Visible = true;
                pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureZdjecie2.Image = new Bitmap("C:\\Users\\mi140\\OneDrive\\Pulpit\\Bez nazwy-2.jpg");
                pictureZdjecie2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if(listBoxData == null) 
            {
                MessageBox.Show("Nic tu nie ma ");
            }

            listBox1.Items.AddRange(listBoxData.ToArray());

            pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureZdjecie2.Image = new Bitmap("C:\\Users\\mi140\\OneDrive\\Pulpit\\Bez nazwy-2.jpg");
            pictureZdjecie2.SizeMode = PictureBoxSizeMode.StretchImage;


        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (listBoxData2 != null)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(listBoxData2.ToArray());
                pictureZdjecie2.Visible = true;
                pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureZdjecie2.Image = new Bitmap("C:\\Users\\mi140\\OneDrive\\Pulpit\\Bez nazwy-1.jpg");
                pictureZdjecie2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (listBoxData2 == null)
            {
                MessageBox.Show("Nic nie ma ");
            }
            
            listBox1.Items.AddRange(listBoxData2.ToArray());

            pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureZdjecie2.Image = new Bitmap("C:\\Users\\mi140\\OneDrive\\Pulpit\\Bez nazwy-1.jpg");
            pictureZdjecie2.SizeMode = PictureBoxSizeMode.StretchImage;

        }

    }
}
