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
            int a = Convert.ToInt32(txtLiczba.Text); //wczytanie liczby a
            Rysuj(a);
        }

        private void Rysuj(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string line = "";
                for (int j = 1; j <= i; j++)
                {
                    line += i;
                }
                listBox1.Items.Add(line);
            }
        }
    }
}
