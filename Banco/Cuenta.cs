using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Cuenta
    {
        protected string titular;
        protected double cantidad;
        public Cuenta()
        {
            Titular = "";
            cantidad = 0;
        }

        public string Titular
        {
            set
            {
                titular = value;
            }
            get
            {
                return titular;
            }
        }

        public double Cantidad
        {
            set
            {
                cantidad = value;
            }
            get
            {
                return cantidad;
            }
        }

    }
}
