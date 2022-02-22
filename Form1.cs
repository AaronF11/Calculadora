namespace Ventana
{
    public partial class Form1 : Form
    {
        //---------------------------------------------------------------------
        //Variables.
        //---------------------------------------------------------------------
        double Num1 = 0;
        double Num2 = 0;
        Char Operador;

        public Form1()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------------
        //Función para agregar número.
        //---------------------------------------------------------------------
        private void FuncAgregar(object sender, EventArgs e)
        {
            var Boton = ((Button)sender);

            if (TxtPantalla.Text == "0")
            {
                TxtPantalla.Text = "";
            }

            TxtPantalla.Text += Boton.Text;
        }

        //---------------------------------------------------------------------
        //Función para agregar número.
        //---------------------------------------------------------------------
        private void FuncOperador(object sender, EventArgs e)
        {
            var Boton = ((Button)sender);

            Num1 = Convert.ToDouble(TxtPantalla.Text);
            Operador = Convert.ToChar(Boton.Text);

            TxtPantalla.Text = "0";
        }

        private void BtnAC_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text = "";
        }

        private void BtnResultado_Click(object sender, EventArgs e)
        {
            Num2 = Convert.ToDouble(TxtPantalla.Text);

            switch (Operador)
            {
                case '+':
                    TxtPantalla.Text = (Num1 + Num2).ToString();
                    Num1 = Convert.ToDouble(TxtPantalla.Text);
                    break;

                case '-':
                    TxtPantalla.Text = (Num1 - Num2).ToString();
                    Num1 = Convert.ToDouble(TxtPantalla.Text);
                    break;

                case '*':
                    TxtPantalla.Text = (Num1 * Num2).ToString();
                    Num1 = Convert.ToDouble(TxtPantalla.Text);
                    break;

                case '/':
                    TxtPantalla.Text = (Num1 / Num2).ToString();
                    Num1 = Convert.ToDouble(TxtPantalla.Text);
                    break;

                case '%':
                    TxtPantalla.Text = (Num1 % Num2).ToString();
                    Num1 = Convert.ToDouble(TxtPantalla.Text);
                    break;

                default:
                    break;
            }
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(TxtPantalla.Text);
            Num1 *= -1;
            TxtPantalla.Text = Num1.ToString();
        }

        private void BtnPunto_Click(object sender, EventArgs e)
        {
            if (!TxtPantalla.Text.Contains("."))
            {
                TxtPantalla.Text += ".";
            }
        }
    }
}