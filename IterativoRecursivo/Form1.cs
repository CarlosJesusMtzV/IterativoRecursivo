namespace IterativoRecursivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero;

            // Validar que el número sea un entero válido
            if (!int.TryParse(txtNumero.Text, out numero) || numero < 0)
            {
                MessageBox.Show("Por favor, ingrese un número entero positivo.");
                return;
            }

            string problema = comboBoxProblemas.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(problema))
            {
                MessageBox.Show("Seleccione un problema de la lista.");
                return;
            }

            int resultadoIterativo = 0, resultadoRecursivo = 0;

            switch (problema)
            {
                case "Factorial":
                    resultadoIterativo = FactorialIterativo(numero);
                    resultadoRecursivo = FactorialRecursivo(numero);
                    break;
                case "Suma":
                    resultadoIterativo = SumaIterativa(numero);
                    resultadoRecursivo = SumaRecursiva(numero);
                    break;
                case "Fibonacci":
                    resultadoIterativo = FibonacciIterativo(numero);
                    resultadoRecursivo = FibonacciRecursivo(numero);
                    break;
                default:
                    MessageBox.Show("Opción no válida.");
                    break;
            }

            // Mostrar los resultados
            lblResultadoIterativo.Text = $"Iterativo: {resultadoIterativo}";
            lblResultadoRecursivo.Text = $"Recursivo: {resultadoRecursivo}";
        }

        // Métodos iterativos y recursivos
        private int FactorialIterativo(int n)
        {
            int resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        // Factorial Recursivo
        private int FactorialRecursivo(int n)
        {
            if (n == 0) // Condición de salida
                return 1;
            return n * FactorialRecursivo(n - 1); // Segmento recursivo
        }

        // Suma Iterativa
        private int SumaIterativa(int n)
        {
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }
            return suma;
        }

        // Suma Recursiva
        private int SumaRecursiva(int n)
        {
            if (n == 0) // Condición de salida
                return 0;
            return n + SumaRecursiva(n - 1); // Segmento recursivo
        }

        // Fibonacci Iterativo
        private int FibonacciIterativo(int n)
        {
            if (n <= 1)
                return n;

            int a = 0, b = 1, temp;
            for (int i = 2; i <= n; i++)
            {
                temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }

        // Fibonacci Recursivo
        private int FibonacciRecursivo(int n)
        {
            if (n <= 1) // Condición de salida
                return n;
            return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2); // Segmento recursivo
        }
    }
}
