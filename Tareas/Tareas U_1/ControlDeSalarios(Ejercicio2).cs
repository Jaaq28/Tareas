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
    public partial class ControlDeSalarios : Form
    {
        public ControlDeSalarios()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            DateTime fechaIngresada = FechaTimePicker.Value;
            EdadLabel.Text = EdadEmpleado(fechaIngresada).ToString();

            Condicione();
        }
        private void Condicione() 
        {
            int VentasProm = Convert.ToInt32(IngresarValorTextBox.Text);
            int AñosTrabajados = Convert.ToInt32(IngresarAñosTextBox.Text);
            int EdadEmpleado = Convert.ToInt32(EdadLabel.Text);
            double SalarioE = Convert.ToInt32(SalarioDelEmpleadoTexbox.Text);
            if (VentasProm >= 10000 && EdadEmpleado >= 30 && AñosTrabajados >= 10)
            {
                SalarioE = SalarioE * 1.5;
            }
            SalarioAumentoTextBox.Text = Convert.ToString(SalarioE);
        }

        private int EdadEmpleado(DateTime fechaNacimeinto)
        {
            DateTime _fechaNacimiento = fechaNacimeinto;
            DateTime _fechaActual = DateTime.Now;

            int Edad;

            if (_fechaNacimiento.Day >= _fechaActual.Day)
            {
                return 0;
            }
            {
                Edad = _fechaActual.Year - _fechaNacimiento.Year;
                if (_fechaActual.Month > _fechaActual.Month)
                {
                    --Edad;
                }
                return Edad;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HoraLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void ControlDeSalarios_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            SalarioDelEmpleadoTexbox.Clear();
            SalarioAumentoTextBox.Clear();
            IngresarAñosTextBox.Clear();
            IngresarValorTextBox.Clear();
        }
    }
}



