namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextboxCalificacion1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPromediarCalificaciones_Click(object sender, EventArgs e)
        {
            int calificacion1 = int.Parse(TextboxCalificacion1.Text);
            int calificacion2 = int.Parse(textBoxCalificacion2.Text);
            int calificacion3 = int.Parse(TextBoxCalificacion3.Text);
            int calificacion4 = int.Parse(TexBoxCalificacion4.Text);
            int promedio = (calificacion1 + calificacion2 + calificacion3 + calificacion4) / 4;

            label3.Text = promedio.ToString();

        }

        private void TexBoxCalificacion4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
