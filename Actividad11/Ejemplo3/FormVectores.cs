namespace Ejemplo3
{
    public partial class FormVectores : Form
    {
        Servicio servicio = new Servicio();
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

        void Ordenar()
        {
            for (int piv = 0; piv < contador - 1; piv++)
            {
                for (int comp = 0; comp < contador - 1; comp++)
                {
                    if (valores[piv] > valores[piv])
                    {
                        Intercambio(valores, piv, comp);
                    }
                }
            }
            void Intercambio(double[] vector, int a, int b)
            {
                double tmp = valores[a];
                valores[a] = valores[b];
                valores[b] = tmp;
            }
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            tbPromedio.Clear();

            Ordenar();

            for (int i = 0; i < contador; i++)
            {
                tbPromedio.Text += $"{valores[i],4:f2}";
            }
        }
    }
}