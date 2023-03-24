namespace zad._5
{
    public partial class Form1 : Form
    {
        private int _a;

        public int a
        {
            get { return _a; }
            set { _a = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLiczba_Click_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtLiczba.Text);

            int i = 1;
            string wynik = "";
            while (i <= a)
            {
                int result = a * i;
                wynik += result.ToString() + " ";
                i++;
            }



            MessageBox.Show(wynik, "WYNIK:");
        }


    }
}