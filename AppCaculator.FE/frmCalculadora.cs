using AppCaculator.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCaculator.FE
{
    public partial class frmCalculadora : Form
    {
        private Calculadora oCalculadora = new Calculadora();
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            oCalculadora.Operador = Convert.ToInt32(txtOperador.Text);
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            oCalculadora.Suma();
            txtResultado.Text = oCalculadora.Resultado.ToString();
        }
    }
}
