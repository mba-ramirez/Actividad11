using System.Numerics;

namespace Ejemplo1
{
    public partial class FormPrincipal : Form
    {
        double acumulador = 0;
        int contador = 0;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            //Convert.ToDouble( Console.ReadLine());
            double valor = Convert.ToDouble(tbValor.Text);

            acumulador += valor;
            contador++;

        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double promedio = acumulador / contador;

            lbResultado.Text = $"{promedio,10:f2}";

            tbResultado.Text = $@"Promedio:
{promedio,10:f2}
"; 
        }
    }
}
