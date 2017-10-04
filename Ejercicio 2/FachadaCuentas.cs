using System;

namespace Ejercicio2
{
    internal class FachadaCuentas
    {
        public Cliente iCliente = null;         //se le asigna null para que ingrese al if del segundo caso del switch hasta ingresar un cliente
        public Cuentas iCuentasDelCliente;

        /// <summary>
        /// método que asigna a un cliente un tipo de documento
        /// </summary>
        internal TipoDocumento elegirTipoDocumento()           
        {
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    return (TipoDocumento.DNI);
                case 2:
                    return (TipoDocumento.CUIT);
                case 3:
                    return (TipoDocumento.CUIL);
                case 4:
                    return (TipoDocumento.LE);
                case 5:
                    return (TipoDocumento.LC);
                default:
                    Console.WriteLine("nro ingresado es incorrecto, se ha asignado DNI");
                    return (TipoDocumento.DNI);
            }
        }

        /// <summary>
        /// método que crea al cliente con el que se realizarán las operaciones luego
        /// </summary>
        /// <param name="pTipoDocumento">
        /// de tipo TipoDocumento, contendrá el tipo de documento elegido del cliente
        /// </param>
        /// <param name="pNroDocumento">
        /// de tipo int, contendrá el número del documento del cliente
        /// </param>
        /// <param name="pNombre">
        /// de tipo string, contendrá el nombre del cliente
        /// </param>
        internal void agregarCliente(TipoDocumento pTipoDocumento, int pNroDocumento, string pNombre)    
        {
            iCliente = new Cliente(pTipoDocumento, pNroDocumento, pNombre);
        }

        /// <summary>
        /// metodo que utiliza el constructor de la clase "Cuentas" para inicilizar cuentas a un cliente
        /// </summary>
        internal void inicializarCuentas()   
        {
            iCuentasDelCliente = new Cuentas(iCliente);
        }

        /// <summary>
        /// método que utiliza el constructor de la clase "Cuenta" con 1 parametro para asignar un monto de acuerdo a la cuenta corriente del cliente en cuestion
        /// </summary>
        internal void inicializarCuentaCorrienteConAcuerdo(double pAcuerdo)   
        {
            iCuentasDelCliente.cuentaCorriente = new Cuenta(pAcuerdo);
        }

        /// <summary>
        /// método que utiliza el constructor de la clase "Cuenta" con 2 parametros para asignar un monto de acuerdo y un monto de saldo a la cuenta corriente del cliente en cuestion
        /// </summary>
        internal void inicializarCuentaCorrienteConAcuerdoYSaldo(double pAcuerdo, double pSaldo)  
        {
            iCuentasDelCliente.cuentaCorriente = new Cuenta(pSaldo, pAcuerdo);
        }

        /// <summary>
        /// método que utiliza el constructor de la clase "Cuenta" con 1 parametro para asignar un monto de acuerdo a la caja de ahorro del cliente en cuestion
        /// </summary>
        internal void inicializarCajaDeAhorroConAcuerdo(double pAcuerdo)  
        {
            iCuentasDelCliente.cajaAhorro = new Cuenta(pAcuerdo);
        }

        /// <summary>
        /// método que utiliza el constructor de la clase "Cuenta" con 2 parametros para asignar un monto de acuerdo y un monto de saldo a la caja de ahorro del cliente en cuestion
        /// </summary>
        internal void inicializarCajaDeAhorroConAcuerdoYSaldo(double pAcuerdo, double pSaldo) 
        {
            iCuentasDelCliente.cajaAhorro = new Cuenta(pSaldo, pAcuerdo);
        }

        /// <summary>
        /// llama al método de la clase "Cuenta" que resta un saldo para la cuenta corriente
        /// </summary>
        /// <returns>
        /// el saldo luego de intentar debitarlo
        /// </returns>
        internal double debitarCuentaCorriente(double pSaldo)    
        {
            if (iCuentasDelCliente.cuentaCorriente.debitarSaldo(pSaldo))
            {
                return (iCuentasDelCliente.cuentaCorriente.saldo);
            }
            else
            {
                Console.WriteLine("no es posible debitar el saldo");
                return (iCuentasDelCliente.cuentaCorriente.saldo);
            }

        }

        /// <summary>
        /// llama al método de la clase "Cuenta" que resta un saldo para la caja de ahorro
        /// </summary>
        /// <returns>
        /// el saldo luego de intentar debitarlo
        /// </returns>
        internal double debitarCajaAhorro(double pSaldo)      
        {
            iCuentasDelCliente.cajaAhorro.debitarSaldo(pSaldo);
            return (iCuentasDelCliente.cajaAhorro.saldo);
        }

        /// <summary>
        /// llama al método de la clase "Cuenta" que suma un saldo para la cuenta corriente
        /// </summary>
        /// <returns>
        /// el saldo luego de aumentarlo
        /// </returns>
        internal double acreditarCuentaCorriente(double pSaldo)   
        {
            iCuentasDelCliente.cuentaCorriente.acreditarSaldo(pSaldo);
            return (iCuentasDelCliente.cuentaCorriente.saldo);
        }

        /// <summary>
        /// llama al método de la clase "Cuenta" que suma un saldo para la caja de ahorro
        /// </summary>
        /// <returns>
        /// el saldo luego de aumentarlo
        /// </returns>
        internal double acreditarCajaAhorro(double pSaldo)    
        {
            iCuentasDelCliente.cajaAhorro.acreditarSaldo(pSaldo);
            return (iCuentasDelCliente.cajaAhorro.saldo);
        }

        /// <summary>
        /// modifica el valor de acuerdo de una cuenta
        /// </summary>
        /// <param name="pCuenta">
        /// la cuenta que será actualizada
        /// </param>
        internal void actualizarAcuerdo(Cuenta pCuenta)               
        {
            pCuenta.acuerdo = Convert.ToDouble(Console.ReadLine());
        }
    }
}