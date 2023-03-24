namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int _a;
        private int _b;
        public int a
        {
            get { return _a; }
            set { _a = value; }
        }
        public int b
        {
            get { return _b; }
            set { _b = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtLiczba1.Text);
            int b = Convert.ToInt32(txtLiczba2.Text);
            int c = a + b;

            if (c < 10)
            {
                lblWynik.Text = "Wynik: " + (a * b).ToString();
            }
            else if (c > 10 && c < 100)
            {
                lblWynik.Text = "Wynik: " + (a + b).ToString();
            }
            else if (c > 100)
            {
                lblWynik.Text = "Wynik: " + (a - b).ToString();
            }
        }
    }
}