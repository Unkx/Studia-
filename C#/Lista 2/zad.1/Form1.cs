namespace zad1
{
    public partial class Form1 : Form
    {

        private int _pole;
        private int _objetosc;

        public int Pole
        {
            get { return _pole; }
            set { _pole = value; }
        }
        public int Objetosc
        {
            get { return _objetosc; }
            set { _objetosc = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bok;
            if (Int32.TryParse(txtBok.Text, out bok))
            {
                lblPole.Text = this.obliczPole(bok).ToString();
                lblObjetosc.Text = this.obliczObjetosc(bok).ToString();
            }
            else
            {
                MessageBox.Show("Nieprawid³owe dane");
            }
        }

        private int obliczPole(int bok)
        {
            return bok * bok * bok;
        }
        private int obliczObjetosc(int bok)
        {
            return 6 * bok * bok;
        }

    }
}