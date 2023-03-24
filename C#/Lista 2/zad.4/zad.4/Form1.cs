using zad._4;


namespace zad._4
{
    public partial class Form1 : Form
    {
        private int _n; public int n
        {
            get { return _n; }
            set { _n = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLiczba_Click(object sender, EventArgs e)
        {
            int liczbMax;

            string txt = txtPodajLiczbe.Text;
            string[] liczba = txt.Split(',');
            liczbMax = Convert.ToInt32(liczba[0]);


            foreach (string liczby in liczba)
            {
                if (liczbMax < Convert.ToInt32(liczby))
                {
                    liczbMax = Convert.ToInt32(liczby);
                }
            }


            MessageBox.Show(liczbMax.ToString());
        }

    }
}