using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(montotxt.Text);
            double interes = double.Parse(tasatxt.Text);
            double plazo = double.Parse(pagotxt.Text);

            double cuotaMensual = (monto * (interes * Math.Pow(1 + interes, plazo))) / (Math.Pow(1 + interes, plazo) - 1);
            cuotaMensual = Math.Round(cuotaMensual / 2);
            Cuota.Text = cuotaMensual.ToString();
        }
    }
}
