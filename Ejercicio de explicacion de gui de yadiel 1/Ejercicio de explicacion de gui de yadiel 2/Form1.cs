namespace ejercicio_yadiel_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click_Click(object sender, EventArgs e)
        {
            double valor1 = double.Parse(textBox1.Text);
            double valor2 = double.Parse(textBox2.Text);

            double suma = valor1 + valor2;
            double resta = valor1 - valor2;
            double multiplicacion = valor1 * valor2;
            string division;

            if (valor2 != 0)
            {
                division = (valor1 / valor2).ToString();
            }
            else
            {
                division = "No se puede dividir entre cero";
            }

            labelSuma.Text = "Suma: " + suma.ToString();
            labelResta.Text = "Resta: " + resta.ToString();
            labelMultiplicacion.Text = "Multiplicación: " + multiplicacion.ToString();
            labelDivision.Text = "División: " + division;
        }
    }
}
