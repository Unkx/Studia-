﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie
{
    public partial class Form3 : Form
    {


        public Form3()
        {
            InitializeComponent();
        }

        private void buttonPodajLiczbe_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Console.ReadLine()); //wczytanie liczby a
            Draw(a);
        }

        private void Draw(int n)
        {
            listBox1.Items.Clear();
            for (int i = 1; i <= n; i++)
            {
                string line = "";
                for (int j = 1; j <= i; j++)
                {
                    line += "1";
                }
                listBox1.Items.Add(line);
            }
        }
    }

}
