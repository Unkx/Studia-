﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonWypisz_Click(object sender, EventArgs e)
        {
            Book o1 = new Book();
            listBoxBook.Items.AddRange(o1.Wypisz());
            Book o2 = new Book("Kuba", "Mickiewicz", 2000, "Czerwień","Stary Śpi", 23);
            listBoxBook.Items.AddRange(o2.Wypisz());
            Book o3 = new Book(o2);
            listBoxBook.Items.AddRange(o3.Wypisz());
        }
    }
}
