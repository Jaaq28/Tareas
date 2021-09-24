using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tareas_U_1
{
    public partial class FunciondeParImparPrimo : Form
    {
        public FunciondeParImparPrimo()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            NumeroParImpar();
            int ResulPrimos = NumerosPrimos(Convert.ToInt32(IngresarTextBox.Text));
        }
        private void NumeroParImpar() 
        {
            int N;
            N = int.Parse(IngresarTextBox.Text);

            if (N % 2 == 0)
            {
                ResultadoTextBox.Text = "EL Numero Ingresado es Par";
            }
            else
            {
                ResultadoTextBox.Text = "EL Numero Ingresado es Impar";
            }
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarTexbox();
        }
        private void LimpiarTexbox()
        {
            IngresarTextBox.Clear();
            ResultadoTextBox.Clear();
            Resultado2TextBox.Clear();
        }

        private void FunciondeParImparPrimo_Load(object sender, EventArgs e)
        {

        }
        private int NumerosPrimos(int num)
        {
            int Digito = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Digito = Digito + 1;
                }
            }
            if (Digito == 2)
            {
                Resultado2TextBox.Text = "El Numero que Ingreso Es Primo";
            }
            else
            {
                Resultado2TextBox.Text = "El Numero que Ingreso No es Primo";
            }
            return num;

        }
    }
}
