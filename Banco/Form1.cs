using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        Cuenta cuentas = new Cuenta();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            cuentas.Titular = textBoxTitular.Text;
            cuentas.Cantidad = double.Parse(textBoxCantidad.Text);
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            textBoxTitularMostrar.Text = cuentas.Titular;
            textBoxCantidadMostrar.Text = Convert.ToString(cuentas.Cantidad);
        }

        private void buttonDepositar_Click(object sender, EventArgs e)
        {
            double monto;
            monto = double.Parse(textBoxMonto.Text);

            cuentas.Cantidad += monto;
            textBoxTitularMostrar.Text = cuentas.Titular;
            textBoxCantidadMostrar.Text = Convert.ToString(cuentas.Cantidad);
            MessageBox.Show("Se depositó correctamente");

        }

        private void buttonRetirar_Click(object sender, EventArgs e)
        {
            double monto;
            monto = double.Parse(textBoxMonto.Text);
            if (monto <= cuentas.Cantidad)
            {
                cuentas.Cantidad -= monto;
                textBoxTitularMostrar.Text = cuentas.Titular;
                textBoxCantidadMostrar.Text = Convert.ToString(cuentas.Cantidad);
                MessageBox.Show("Se retiró correctamente");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }
        }
    }
}
