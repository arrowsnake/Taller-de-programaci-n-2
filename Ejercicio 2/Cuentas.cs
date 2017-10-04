using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    /// <summary>
    /// esta clase se encarga de crear un objeto cuentas que asociará a un cliente sus dos cuentas, corriente y caja de ahorro, ambas de tipo "Cuenta"
    /// </summary>
    class Cuentas
    {
        private Cliente iCliente;
        private Cuenta iCuentaCorriente;
        private Cuenta iCajaAhorro;

        /// <summary>
        /// Constructor de la clase con el parametro cliente de clase "Cliente"
        /// </summary>
        /// <param name="pCliente">
        /// de tipo "Cliente" será asignado a iCliente
        /// </param>
        public Cuentas(Cliente pCliente)        
        {
            this.iCliente = pCliente;
        }

        /// <summary>
        /// property de cuentaCorriente
        /// </summary>
        public Cuenta cuentaCorriente
        {
            get { return this.iCuentaCorriente; }
            set { this.iCuentaCorriente = value; }
        }

        /// <summary>
        /// property de cajaAhorro
        /// </summary>
        public Cuenta cajaAhorro
        {
            get { return this.iCajaAhorro; }
            set { this.iCajaAhorro = value; }
        }
    }
}
