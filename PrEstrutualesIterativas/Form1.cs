namespace PrEstrutualesIterativas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //Declaracion De Variable

            int numero;
            double suma, resta, multiplicacion, division;

            //Entrada de datos

            numero = Convert.ToInt32(txtnumero.Text);

            // Proceso
            //Dejamos en blanco lo combobox
            cbosuma.Items.Clear();
            cboresta.Items.Clear();
            cbomultiplicacion.Items.Clear();   
            cbodivision.Items.Clear();

            // Creamos nuestro bucle para que muestre la tabla del 1 al 12

            for (int i = 1; i <= 12; i=i+1)
            {
                suma = numero + i;
                resta = numero - i;
                multiplicacion = numero * i;
                division = numero / i;

                // agregar los resultados de combobox

                cbosuma.Items.Add(numero + " + " + i + " = " + suma);
                cboresta.Items.Add(numero + " - " + i + " = " + resta);
                cbomultiplicacion.Items.Add(numero + " * " + i + " = " + multiplicacion);
                cbodivision.Items.Add(numero + " / " + i + " = " + division);
            }


        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            cbosuma.Items.Clear();
            cboresta.Items.Clear();
            cbomultiplicacion.Items.Clear();
            cbodivision.Items.Clear();
            txtnumero.Clear();



        }
    }
}