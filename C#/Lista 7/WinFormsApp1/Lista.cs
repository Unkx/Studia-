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
        public bool IsFirstListBox { get; set; }
        public Lista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxData != null)
            {
                listBox1.Items.AddRange(listBoxData.ToArray());
<<<<<<< HEAD
                pictureZdjecie2.Visible = true;
                pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureZdjecie2.Image = new Bitmap("C:\\Users\\mi140\\OneDrive\\Pulpit\\Bez nazwy-1.jpg");
            }
            else if(listBoxData == null) 
            {
                MessageBox.Show("Chuj", "Nic nie ma ");
            }

           
=======
            }
            else
            {
                listBox1.Items.AddRange(listBoxData2.ToArray());
            }

            pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureZdjecie2.Image = new Bitmap("C:\\Users\\mi140\\OneDrive\\Pulpit\\Bez nazwy-1.jpg");
>>>>>>> 667dfc5582b3dd69e7b0af7951a581a1dbc4b1df
        }


        private void button2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (listBoxData2 != null)
            {
                listBox1.Items.AddRange(listBoxData2.ToArray());
                pictureZdjecie2.Visible = true;
                pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureZdjecie2.Image = new Bitmap("C:\\Users\\mi140\\OneDrive\\Pulpit\\Bez nazwy-1.jpg");
            }
            else if (listBoxData2 == null)
            {
                MessageBox.Show("Nic nie ma ");
            }
            

            
=======

            listBox1.Items.AddRange(listBoxData2.ToArray());

            pictureZdjecie2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureZdjecie2.Image = new Bitmap("C:\\Users\\mi140\\OneDrive\\Pulpit\\Bez nazwy-1.jpg");
>>>>>>> 667dfc5582b3dd69e7b0af7951a581a1dbc4b1df
        }

    }
}
