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
    public partial class Form1 : Form
    {
        private List<Bookstore> BookstoreList;
        private int currentIndex = 0;

        private PictureBox pictureBox;
        private Label label;

        public Form1() { }

        public Form1(List<Bookstore> objectsList)
        {
            this.BookstoreList = objectsList;

        }
    }
}