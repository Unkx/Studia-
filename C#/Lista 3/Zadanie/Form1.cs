namespace Zadanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonZatwierdz_Click_1(object sender, EventArgs e)
        {
            string imie = "Micha³";
            string nazwisko = "Tiedemann";

            if ((imie == txtImie.Text) && (nazwisko == txtNazwisko.Text))
            {
                Button1.Visible = true;
                Button2.Visible = true;
            }
            else
            {
                MessageBox.Show("Nieprawid³owe dane!", "ERROR");
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        private void Button2_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}