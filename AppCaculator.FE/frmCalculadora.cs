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
            if (txtOperador1.Text == "")
            {
                oCalculadora.Operador1 = Convert.ToInt32(txtOperador2.Text);
                txtOperador1.Text = txtOperador2.Text;
                oCalculadora.Resultado = oCalculadora.Operador1;
                txtResultado.Text = txtOperador2.Text;
                oCalculadora.Operador2 = 0;
                txtOperador2.Text = "";
                txtOperador2.Focus();
            }
            else if(txtOperador1.Text == txtResultado.Text)
            {
                oCalculadora.Operador2 = Convert.ToInt32(txtOperador2.Text);
                oCalculadora.Suma();
                txtResultado.Text = oCalculadora.Resultado.ToString();
                txtOperador2.Focus();
                txtOperador2.SelectAll();
            }
            else
            {
                oCalculadora.Operador1 = oCalculadora.Resultado;
                txtOperador1.Text = oCalculadora.Operador1.ToString();
                oCalculadora.Operador2 = Convert.ToInt32(txtOperador2.Text);
                oCalculadora.Suma();
                txtResultado.Text = oCalculadora.Resultado.ToString();
                txtOperador2.Focus();
                txtOperador2.SelectAll();
            }
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            oCalculadora.Operador1 = oCalculadora.Resultado;
            txtOperador1.Text = oCalculadora.Operador1.ToString();
            oCalculadora.Operador2 = Convert.ToInt32(txtOperador2.Text);
            oCalculadora.Suma();
            txtResultado.Text = oCalculadora.Resultado.ToString();
            txtOperador2.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oCalculadora = null;
            oCalculadora=new Calculadora();
            txtResultado.Text = "";
            txtOperador1.Text = "";
            txtOperador2.Text = "";
            txtOperador2.Focus() ;
        }
    }
}
