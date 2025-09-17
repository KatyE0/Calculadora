using Calculadora.Models;
using System;
using System.Windows.Forms;


namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double num1;
        private double num2;
        private string operacion;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; 
            // Permite que el formulario capture los eventos de teclado primero
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys)'0': btn0.PerformClick(); break;
                case (Keys)'1': btn1.PerformClick(); break;
                case (Keys)'2': btn2.PerformClick(); break;
                case (Keys)'3': btn3.PerformClick(); break;
                case (Keys)'4': btn4.PerformClick(); break;
                case (Keys)'5': btn5.PerformClick(); break;
                case (Keys)'6': btn6.PerformClick(); break;
                case (Keys)'7': btn7.PerformClick(); break;
                case (Keys)'8': btn8.PerformClick(); break;
                case (Keys)'9': btn9.PerformClick(); break;
                case (Keys)'+': btnSumar.PerformClick(); break;
                case (Keys)'-': btnRestar.PerformClick(); break;
                case (Keys)'*': btnMulti.PerformClick(); break;
                case (Keys)'/': btnDividir.PerformClick(); break;
                case (Keys)(char)Keys.Enter: btnIgual.PerformClick(); break;
                case (Keys)(char)Keys.Escape: btnClear.PerformClick(); break;


            }
            e.Handled = true; // Evita que el evento se propague
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtPantalla.Focus(); // Asegura que el TextBox tenga el foco al iniciar
        }

        // Obtiene los valores de los botones y los muestra en la pantalla :D
                //Botón 1
        private void btn1_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender; // Obtiene el valor del boton
            txtPantalla.Text += boton.Text; // Imprime en la pantalla 
        }
                //Botón 2
        private void btn2_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender; // Obtiene el valor del boton
            txtPantalla.Text += boton.Text; // Imprime en la pantalla 
        }
                //Botón 3
        private void btn3_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender; // Obtiene el valor del boton
            txtPantalla.Text += boton.Text; // Imprime en la pantalla 
        }
                //Botón 4  
        private void btn4_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender; // Obtiene el valor del boton
            txtPantalla.Text += boton.Text; // Imprime en la pantalla 
        }
                //Botón 5
        private void btn5_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender; // Obtiene el valor del boton
            txtPantalla.Text += boton.Text; // Imprime en la pantalla 
        }
                //Botón 6
        private void btn6_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender; // Obtiene el valor del boton
            txtPantalla.Text += boton.Text; // Imprime en la pantalla 
        }
                //Botón 7
        private void btn7_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender; // Obtiene el valor del boton
            txtPantalla.Text += boton.Text; // Imprime en la pantalla 
        }
                //Botón 8
        private void btn8_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender; // Obtiene el valor del boton
            txtPantalla.Text += boton.Text; // Imprime en la pantalla 
        }
                //Botón 9
        private void btn9_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender; // Obtiene el valor del boton
            txtPantalla.Text += boton.Text; // Imprime en la pantalla 
        }
                //Botón 0
        private void btn0_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender; // Obtiene el valor del boton
            txtPantalla.Text += boton.Text; // Imprime en la pantalla 
        }
                //Botón punto
        private void btnPunto_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender; // Obtiene el valor del boton
            txtPantalla.Text += boton.Text; // Imprime en la pantalla 
        }
                //Botón 00
        private void btnDobleCero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender; // Obtiene el valor del boton
            txtPantalla.Text += boton.Text; // Imprime en la pantalla 
        }

        // Botón "Clean" -> Limpia la pantalla y operaciones
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear(); //Limpia la pantalla
            num1 = 0.0;
            num2 = 0.0;
            operacion = "";
        }

        // Gestiona las operaciones
                // Suma
        private void btnSumar_Click(object sender, EventArgs e)
        {
            //Guarda el valor del numero 1
            num1 = double.Parse(txtPantalla.Text);

            // Asigana el tipo de operacion
            operacion = "suma";

            txtPantalla.Clear(); //Limpia la pantalla
        }
                // Resta
        private void btnRestar_Click(object sender, EventArgs e)
        {
            //Guarda el valor del numero 1
            num1 = double.Parse(txtPantalla.Text);

            // Asigana el tipo de operacion
            operacion = "resta";

            txtPantalla.Clear(); //Limpia la pantalla

        }
                //Multiplicacion
        private void btnMulti_Click(object sender, EventArgs e)
        {
            // Guarda el valor del numero 1
            num1 = double.Parse(txtPantalla.Text);

            // Asigana el tipo de operacion
            operacion = "multiplicacion";

            txtPantalla.Clear(); //Limpia la pantalla
        }
                // Division
        private void btnDividir_Click(object sender, EventArgs e)
        {
            // Guarda el valor del numero 1
            num1 = double.Parse(txtPantalla.Text);

            // Asigana el tipo de operacion
            operacion = "division";

            txtPantalla.Clear(); //Limpia la pantalla
        }
        //Raiz
        private void btnRaiz_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
            txtPantalla.Text = "Simbolo raiz";
        
            // Guarda el valor del numero 1
            //num1 = double.Parse(txtPantalla.Text);

            // Asigana el tipo de operacion
            operacion = "raiz";

            //txtPantalla.Clear(); //Limpia la pantalla
        }
                //Porcentaje
        private void btnPorcen_Click(object sender, EventArgs e)
        {
            // Guarda el valor del numero 1
            num1 = double.Parse(txtPantalla.Text);

            // Asigana el tipo de operacion
            operacion = "porcentaje";

            txtPantalla.Clear(); //Limpia la pantalla
        }
                // Igual
        private void btnIgual_Click(object sender, EventArgs e)
        {
            // Obtiene el valor del numero 2
            num2 = double.Parse(txtPantalla.Text);

            Operaciones opera = new Operaciones();


            // Opera de acuerdo al tipo de operador
            switch (operacion)
            {
                //Caso de Suma
                case "suma":
                    String suma = opera.Suma(num1, num2);
                    txtPantalla.Text = suma;
                    break;
                case "resta":
                    String resta = opera.Resta(num1, num2);
                    txtPantalla.Text = resta;
                    break;
                case "multiplicacion":
                    String multiplicacion = opera.Multi(num1, num2);
                    txtPantalla.Text = multiplicacion;
                    break;
                case "division":
                    String division = opera.Division(num1, num2);
                    txtPantalla.Text = division;
                    break;
                case "raiz":
                    //string input = txtPantalla.Text;
                    //num1 = double.Parse(input.Replace("√", ""));
                    double raiz = Math.Sqrt(num2);
                    string raizString = raiz.ToString();
                    txtPantalla.Text = raizString;
                    break;
                case "porcentaje":
                   // double porcentaje = num2 / 100;
                    //double porcen = num1 * porcentaje;
                    //string porcenString = porcen.ToString();
                    //txtPantalla.Text = porcenString;
                    double porcentaje = num1 * (num2 / 100); // Calcula el porcentaje de num1
                   // Opción 1: Muestra solo el porcentaje (500 × 20% = 100)
                    txtPantalla.Text = porcentaje.ToString();
                    break;

                default:
                    // Código a ejecutar si no coincide ningún caso
                    break;
            }

            // double suma = num1 + num2;
            // string sumaString = suma.ToString();
            // txtPantalla.Text = sumaString;



        }




        private void txtPantalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números, operadores y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '+') && (e.KeyChar != '-') &&
                (e.KeyChar != '*') && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }

            // Si es un carácter válido, simula el clic del botón correspondiente
            if (!e.Handled)
            {
               // Form1_KeyDown(sender, e);
            }
        }
    }

}
