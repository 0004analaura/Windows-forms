using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double capitalInicialtex = double.Parse(CapitalInicial.Text);
            double TasadeInterestext = double.Parse(TasaInteres.Text);
            double Periodtext = double.Parse(Tiempo.Text);

           

            double resultado = capitalInicialtex *( Math.Pow(1 + TasadeInterestext, Periodtext));
            resultado = Math.Round(resultado, 2);

            Resultado.Text = resultado.ToString();

        }
    }
}
