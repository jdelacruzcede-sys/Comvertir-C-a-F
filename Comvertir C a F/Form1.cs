namespace Comvertir_C_a_F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Comvertir_Click(object sender, EventArgs e)
        {
            double c = double.Parse(txtcelsius.Text);

            double f = (c * 9 / 5) + 32;

            lblResultado.Text = f + " °F";
        }
    }
}
