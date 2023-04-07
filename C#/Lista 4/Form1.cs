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
            listBoxKlient.Items.AddRange(o1.Wypisz());
            Klient o2 = new Klient("Kuba","Mickiewicz", 2137, 20,4,"R.R. Martin","Gra o tron","Harry Potter",2002,45);
            listBoxKlient.Items.AddRange(o2.Wypisz());
            Klient o3 = new Klient(o2);
            listBoxKlient.Items.AddRange(o3.Wypisz());
            
        }


    }
}