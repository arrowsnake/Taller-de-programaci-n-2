using System;

namespace Ejercicio2
{
    internal class FachadaCuentas
    {
        private Cuentas iCuentasDelCliente;

        internal TipoDocumento elegirTipoDocumento()            //este metodo asigna un tipo de documento
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

        internal Cliente agregarCliente(TipoDocumento pTipoDocumento, int pNroDocumento, string pNombre)    //metodo que crea al cliente con el que se realizarán las operaciones luego
        {
            return (new Cliente(pTipoDocumento, pNroDocumento, pNombre));
        }
        
        internal Cuentas inicializarCuentas(Cliente pCliente)   //metodo que utiliza el constructor de la clase Cuentas para inicilizar cuentas a un cliente
        {
            iCuentasDelCliente = new Cuentas(pCliente);
            return (iCuentasDelCliente);
        }

        internal Cuenta inicializarCuentaCorrienteConAcuerdo(double pAcuerdo)   //metodo que utiliza el constructor de la clase Cuenta con 1 parametro para asignar un monto de acuerdo a la cuenta corriente del cliente en cuestion
        {
            return (iCuentasDelCliente.cuentaCorriente = new Cuenta(pAcuerdo));
        }

        internal Cuenta inicializarCuentaCorrienteConAcuerdoYSaldo(double pAcuerdo, double pSaldo)  //metodo que utiliza el constructor de la clase Cuenta con 2 parametros para asignar un monto de acuerdo y un monto de saldo a la cuenta corriente del cliente en cuestion
        {
            return (iCuentasDelCliente.cuentaCorriente = new Cuenta(pSaldo, pAcuerdo));
        }

        internal Cuenta inicializarCajaDeAhorroConAcuerdo(double pAcuerdo)  //metodo que utiliza el constructor de la clase Cuenta con 1 parametro para asignar un monto de acuerdo a la caja de ahorro del cliente en cuestion
        {
            return (iCuentasDelCliente.cajaAhorro = new Cuenta(pAcuerdo));
        }

        internal Cuenta inicializarCajaDeAhorroConAcuerdoYSaldo(double pAcuerdo, double pSaldo) //metodo que utiliza el constructor de la clase Cuenta con 2 parametros para asignar un monto de acuerdo y un monto de saldo a la caja de ahorro del cliente en cuestion
        {
            return (iCuentasDelCliente.cajaAhorro = new Cuenta(pSaldo, pAcuerdo));
        }

        internal double debitarCuentaCorriente(double pSaldo, Cuentas pCuentas)     //llama al metodo de la clase Cuenta que resta un saldo para la cuenta corriente
        {
            pCuentas.cuentaCorriente.debitarSaldo(pSaldo);
            return (pCuentas.cuentaCorriente.saldo);
        }

        internal double debitarCajaAhorro(double pSaldo, Cuentas pCuentas)      //llama al metodo de la clase Cuenta que resta un saldo para la caja de ahorro
        {
            pCuentas.cajaAhorro.debitarSaldo(pSaldo);
            return (pCuentas.cajaAhorro.saldo);
        }

        internal double acreditarCuentaCorriente(double pSaldo, Cuentas pCuentas)   //llama al metodo de la clase Cuenta que suma un saldo para la cuenta corriente
        {
            pCuentas.cuentaCorriente.acreditarSaldo(pSaldo);
            return (pCuentas.cuentaCorriente.saldo);
        }

        internal double acreditarCajaAhorro(double pSaldo, Cuentas pCuentas)    //llama al metodo de la clase Cuenta que suma un saldo para la caja de ahorro
        {
            pCuentas.cajaAhorro.acreditarSaldo(pSaldo);
            return (pCuentas.cajaAhorro.saldo);
        }

        internal void actualizarAcuerdo(Cuenta pCuenta)                 //modifica el valor de acuerdo de una cuenta
        {
            pCuenta.acuerdo = Convert.ToDouble(Console.ReadLine());
        }
    }
}