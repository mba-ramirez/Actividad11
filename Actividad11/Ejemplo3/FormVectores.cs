namespace Ejemplo3
{
    public partial class FormVectores : Form
    {
        double[] valores = new double[5];
        int contador = 0;
        public FormVectores()
        {
            InitializeComponent();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (contador < valores.Length)
            {
                // Guarda el valor ingresado en el vector
                valores[contador] = Convert.ToDouble(tbValor.Text);
                contador++;

                tbValor.Clear();
            }
            else
            {
                MessageBox.Show("Ya no se pueden registrar más valores.");
            }
        }
        private void btnPromedio_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                MessageBox.Show("No se han registrado valores.");
                return;
            }

            double suma = 0;

            for (int i = 0; i < contador; i++)
            {
                suma += valores[i];
            }

            double promedio = suma / contador;

            lbPromedio.Text = $"{promedio:f2}";

            tbPromedio.Text = $@"Promedio:
{promedio,10:f2}";
        }
    }
}