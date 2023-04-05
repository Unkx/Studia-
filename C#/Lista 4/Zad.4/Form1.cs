using System.Windows.Forms;

namespace Zad._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKlient_Click(object sender, EventArgs e)
        {
            Klient o1 = new Klient();
            o1.Wypisz(listBoxKlient);
            Console.WriteLine("----------------");
        }

        
    }
}