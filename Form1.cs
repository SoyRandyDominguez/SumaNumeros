namespace SumaNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            int resultado = 0;

            // Verificar si los textos de n1 y n2 son números válidos
            bool isValidNum1 = int.TryParse(n1.Text, out num1);
            bool isValidNum2 = int.TryParse(n2.Text, out num2);

            if (isValidNum1 && isValidNum2)
            {
                // Si ambos son números, realiza la suma
                resultado = num1 + num2;
                // Muestra el resultado en el TextBox res
                res.Text = resultado.ToString();
            }
            else
            {
                // Si alguno tiene letras, muestra una alerta
                MessageBox.Show("Por favor, ingrese solo números en ambos campos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Limpia el TextBox res en caso de error
                res.Text = string.Empty;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            n1.Text = string.Empty;
            n2.Text = string.Empty;
            res.Text = string.Empty;
        }
    }
}