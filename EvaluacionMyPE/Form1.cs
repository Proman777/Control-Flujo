using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluacionMyPE
{
    public partial class Form1 : Form
    {
        private System.Collections.Generic.List<int> numeros;

        public Form1()
        {
            InitializeComponent();
            numeros = new System.Collections.Generic.List<int>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int numero;
            if (int.TryParse(txtInput.Text, out numero))
            {
                if (numero >= 0)
                {
                    numeros.Add(numero);
                    txtInput.Clear();
                    txtInput.Focus();
                }
                else
                {
                    MessageBox.Show("Introduzca un número positivo o 0. Para finalizar, introduzca un número negativo.");
                }
            }
            else
            {
                MessageBox.Show("Introduzca un número válido.");
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (numeros.Count == 0)
            {
                MessageBox.Show("No se han ingresado números.");
                return;
            }

            int suma = numeros.Sum();
            int mayor = numeros.Max();
            int menor = numeros.Min();

            lblResult.Text = $"Suma: {suma}\nMayor: {mayor}\nMenor: {menor}";
        }
    }
}