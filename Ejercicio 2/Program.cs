using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNroDocumento;
            string iNombre;
            Cliente iCliente = null;        //se le asigna null para que ingrese al if del segundo caso del switch hasta ingresar un cliente
            Cuentas iCuentas;
            double iAcuerdo;
            double iSaldo;

            FachadaCuentas fachada = new FachadaCuentas();  //se asigna una clase FachadaCuentas a la variable fachada
            bool pasa = true;                               //se utiliza esta variable para el default del switch dentro del siguiente while, para que no se repita infinitamente, esto pasa al asignarle false

            while (pasa == true)
            {
                Console.WriteLine("1- Agregar un Cliente");
                Console.WriteLine("2- Buscar un Cliente");
                Console.WriteLine("Para salir pulse cualquier otra tecla");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("> Ingrese el tipo de documento del Cliente <");
                        Console.WriteLine("1- DNI");
                        Console.WriteLine("2- CUIT");
                        Console.WriteLine("3- CUIL");
                        Console.WriteLine("4- LE");
                        Console.WriteLine("5- LC");
                        TipoDocumento mTipoDocumento = fachada.elegirTipoDocumento();       //asigno a la variable mTipoDocumento un metodo que asigna el tipo elegido

                        Console.WriteLine("> Ingrese el Nro de Documento <");
                        iNroDocumento = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("> Ingrese el nombre del Cliente <");
                        iNombre = Convert.ToString(Console.ReadLine());

                        iCliente = fachada.agregarCliente(mTipoDocumento, iNroDocumento, iNombre);
                        Console.WriteLine("El cliente ha sido agregado");
                        break;

                    case 2:
                        if (iCliente == null)
                        {
                            Console.WriteLine("No se ha agregado ningún Cliente");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Cliente: " + (iCliente.nombre));
                            Console.WriteLine("Con tipo de documento: " + (iCliente.tipoDocumento) + "  y Nro: " + (iCliente.tipoDocumento));
                            Console.WriteLine("> Si desea realizar una de estas acciones, toque la tecla indicada <");
                            Console.WriteLine("0- Inicializar Cuenta Corriente con acuerdo");
                            Console.WriteLine("1- Inicializar Cuenta Corriente con acuerdo y saldo");
                            Console.WriteLine("2- Inicializar Caja de Ahorro con acuerdo");
                            Console.WriteLine("3- Inicializar Caja de Ahorro con acuerdo y saldo");

                            iCuentas = fachada.inicializarCuentas(iCliente);    //esta variable contendrá las cuentas del cliente

                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                //dependiendo de qué elección de cuenta se inicialice, se inicializará posteriormente la siguiente con un saldo y acuerdo nulo
                                case 0:
                                    Console.Write("Ingrese el acuerdo de descubierto de la nueva cuenta: ");
                                    iCuentas.cuentaCorriente = fachada.inicializarCuentaCorrienteConAcuerdo(Convert.ToDouble(Console.ReadLine()));
                                    iCuentas.cajaAhorro = fachada.inicializarCajaDeAhorroConAcuerdo(0);
                                    break;
                                case 1:
                                    Console.Write("Ingrese el acuerdo de descubierto de la nueva cuenta: ");
                                    iAcuerdo = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Ingrese el saldo de la nueva cuenta: ");
                                    iSaldo = Convert.ToDouble(Console.ReadLine());
                                    iCuentas.cuentaCorriente = fachada.inicializarCuentaCorrienteConAcuerdoYSaldo(iAcuerdo, iSaldo);
                                    iCuentas.cajaAhorro = fachada.inicializarCajaDeAhorroConAcuerdo(0);
                                    break;
                                case 2:
                                    Console.Write("Ingrese el acuerdo de descubierto de la nueva cuenta: ");
                                    iCuentas.cajaAhorro = fachada.inicializarCajaDeAhorroConAcuerdo(Convert.ToDouble(Console.ReadLine()));
                                    iCuentas.cuentaCorriente = fachada.inicializarCuentaCorrienteConAcuerdo(0);
                                    break;
                                case 3:
                                    Console.Write("Ingrese el acuerdo de descubierto de la nueva cuenta: ");
                                    iAcuerdo = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Ingrese el saldo de la nueva cuenta: ");
                                    iSaldo = Convert.ToDouble(Console.ReadLine());
                                    iCuentas.cajaAhorro = fachada.inicializarCajaDeAhorroConAcuerdoYSaldo(iAcuerdo, iSaldo);
                                    iCuentas.cuentaCorriente = fachada.inicializarCuentaCorrienteConAcuerdo(0);
                                    break;
                            }

                            pantallaDeSaldos();                             //fuera del main está esta pantalla que será utilizada en repetida ocasiones, y para ahorrar codigo se hizo de esta forma
                            int num = Convert.ToInt32(Console.ReadLine());

                            while (num < 9 & num > 0)       //si el num es distinto de los asignados vuelve a la pantalla inicial
                            {
                                switch (num)
                                {
                                    case 1:
                                        mostrarSaldo(iCuentas.cuentaCorriente.saldo);       //este metodo ubicado fuera del main contiene una escritura en pantalla que se utiliza en repetidas ocasiones
                                        mostrarAcuerdo(iCuentas.cuentaCorriente.acuerdo);   //este metodo ubicado fuera del main contiene una escritura en pantalla que se utiliza en repetidas ocasiones
                                        break;
                                    case 2:
                                        mostrarSaldo(iCuentas.cajaAhorro.saldo);            
                                        mostrarAcuerdo(iCuentas.cajaAhorro.acuerdo);
                                        break;
                                    case 3:
                                        Console.WriteLine("Ingrese el valor a debitar");
                                        iSaldo = fachada.debitarCuentaCorriente(Convert.ToDouble(Console.ReadLine()), iCuentas);
                                        mostrarSaldo(iSaldo);
                                        break;
                                    case 4:
                                        Console.WriteLine("Ingrese el valor a debitar");
                                        iSaldo = fachada.debitarCajaAhorro(Convert.ToDouble(Console.ReadLine()), iCuentas);
                                        mostrarSaldo(iSaldo);
                                        break;
                                    case 5:
                                        Console.WriteLine("Ingrese el valor a acreditar");
                                        iSaldo = fachada.acreditarCuentaCorriente(Convert.ToDouble(Console.ReadLine()), iCuentas);
                                        mostrarSaldo(iSaldo);
                                        break;
                                    case 6:
                                        Console.WriteLine("Ingrese el valor a acreditar");
                                        iSaldo = fachada.acreditarCajaAhorro(Convert.ToDouble(Console.ReadLine()), iCuentas);
                                        mostrarSaldo(iSaldo);
                                        break;
                                    case 7:
                                        Console.WriteLine("Ingrese el nuevo monto del acuerdo de descubierto");
                                        fachada.actualizarAcuerdo(iCuentas.cuentaCorriente);                       //este metodo modifica el acuerdo
                                        Console.WriteLine("Monto actualizado...");
                                        break;
                                    case 8:
                                        Console.WriteLine("Ingrese el nuevo monto del acuerdo de descubierto");
                                        fachada.actualizarAcuerdo(iCuentas.cajaAhorro);                            //este metodo modifica el acuerdo
                                        Console.WriteLine("Monto actualizado...");
                                        break;
                                }
                                pantallaDeSaldos();
                                num = Convert.ToInt32(Console.ReadLine());
                            }

                            break;
                        }

                    default:
                        pasa = false;           //se asigna false a esta variable para que no se repita el ciclo while principal
                        break;
                }
            }
        }

        static void mostrarSaldo(double pSaldo)
        {
            Console.WriteLine("El saldo de la cuenta es: " + pSaldo);
        }

        static void mostrarAcuerdo(double pAcuerdo)
        {
            Console.WriteLine("El acuerdo de descubierto de la cuenta es: " + pAcuerdo);
        }

        static void pantallaDeSaldos()
        {
            Console.WriteLine("1- Revisar Cuenta Corriente");
            Console.WriteLine("2- Revisar Caja de Ahorro");
            Console.WriteLine("3- Debitar saldo Cuenta Corriente");
            Console.WriteLine("4- Debitar saldo Caja de Ahorro");
            Console.WriteLine("5- Acreditar saldo Cuenta Corriente");
            Console.WriteLine("6- Acreditar saldo Caja de Ahorro");
            Console.WriteLine("7- Modificar acuerdo de descubierto de Cuenta Corriente");
            Console.WriteLine("8- Modificar acuerdo de descubierto de Caja de Ahorro");
            Console.WriteLine("Para salir pulse cualquier otro número");
        }
    }
}
