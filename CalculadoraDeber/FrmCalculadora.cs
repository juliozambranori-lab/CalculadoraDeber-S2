namespace CalculadoraDeber
{
  
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        double numero1;
        double numero2;
        string operacion;
        private void b1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "9";
        }

        private void bSuma_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtPantalla.Text);
            operacion = "+";
            txtPantalla.Clear();
        }

        private void bResta_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtPantalla.Text);
            operacion = "-";
            txtPantalla.Clear();
        }

        private void bMulti_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtPantalla.Text);
            operacion = "*";
            txtPantalla.Clear();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "0";
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
        }
        private void bIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtPantalla.Text);

            switch (operacion)
            {
                case "+":
                    txtPantalla.Text = (numero1 + numero2).ToString();
                    break;

                case "-":
                    txtPantalla.Text = (numero1 - numero2).ToString();
                    break;

                case "*":
                    txtPantalla.Text = (numero1 * numero2).ToString();
                    break;

                case "/":
                    txtPantalla.Text = (numero1 / numero2).ToString();
                    break;
            }
        }

        private void bDivision_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtPantalla.Text);
            operacion = "/";
            txtPantalla.Clear();
        }
    }
}
