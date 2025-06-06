namespace Ejemplo2
{
    public partial class FormPrincipal : Form
    {
        double acumulador = 0;
        int contador = 0;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            //acumulador += Console Readline;
            acumulador += Convert.ToDouble(tbValor.Text);
            contador++;

            tbValor.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double promedio = acumulador / contador;

            lbPromedio.Text = $"{promedio:f2}";

            tbPromedio.Text = $@"Promedio:
{promedio,10:f2}";
        }
    }
}
