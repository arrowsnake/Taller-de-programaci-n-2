using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Cuentas
    {
        private Cliente iCliente;
        private Cuenta iCuentaCorriente;
        private Cuenta iCajaAhorro;

        public Cuentas(Cliente pCliente)        //Constructor de la clase con el parametro cliente de clase Cliente
        {
            this.iCliente = pCliente;
        }

        public Cuenta cuentaCorriente
        {
            get { return this.iCuentaCorriente; }
            set { this.iCuentaCorriente = value; }
        }

        public Cuenta cajaAhorro
        {
            get { return this.iCajaAhorro; }
            set { this.iCajaAhorro = value; }
        }
    }
}
