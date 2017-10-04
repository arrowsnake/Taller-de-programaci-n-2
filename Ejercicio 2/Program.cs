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
            double iAcuerdo;
            double iSaldo;

            FachadaCuentas fachada = new FachadaCuentas();  //creo un objeto de clase FachadaCuentas, que será el controlador
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
                        TipoDocumento mTipoDocumento = fachada.elegirTipoDocumento();       

                        Console.WriteLine("> Ingrese el Nro de Documento <");
                        iNroDocumento = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("> Ingrese el nombre del Cliente <");
                        iNombre = Convert.ToString(Console.ReadLine());

                        fachada.agregarCliente(mTipoDocumento, iNroDocumento, iNombre);
                        Console.WriteLine("El cliente ha sido agregado");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        if (fachada.iCliente == null)           //si esta variable de instancia está vacia querrá decir que el cliente no fue agregado
                        {
                            Console.WriteLine("No se ha agregado ningún Cliente");
                            break;
                        }
                        else                                    //si consigue acceder a esta parte del código es porque existe un cliente agregado
                        {
                            Console.WriteLine("Cliente: " + (fachada.iCliente.nombre));
                            Console.WriteLine("Con tipo de documento: " + (fachada.iCliente.tipoDocumento) + "  y Nro: " + (fachada.iCliente.tipoDocumento));
                            Console.WriteLine("> Si desea realizar una de estas acciones, toque la tecla indicada <");
                            Console.WriteLine("1- Inicializar Cuenta Corriente con acuerdo");
                            Console.WriteLine("2- Inicializar Cuenta Corriente con acuerdo y saldo");
                            Console.WriteLine("3- Inicializar Caja de Ahorro con acuerdo");
                            Console.WriteLine("4- Inicializar Caja de Ahorro con acuerdo y saldo");

                            fachada.inicializarCuentas();

                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                    Console.Write("Ingrese el acuerdo de descubierto de la nueva cuenta: ");
                                    fachada.inicializarCuentaCorrienteConAcuerdo(Convert.ToDouble(Console.ReadLine()));
                                    fachada.inicializarCajaDeAhorroConAcuerdo(0);
                                    break;
                                case 2:
                                    Console.Write("Ingrese el acuerdo de descubierto de la nueva cuenta: ");
                                    iAcuerdo = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Ingrese el saldo de la nueva cuenta: ");
                                    iSaldo = Convert.ToDouble(Console.ReadLine());
                                    fachada.inicializarCuentaCorrienteConAcuerdoYSaldo(iAcuerdo, iSaldo);
                                    fachada.inicializarCajaDeAhorroConAcuerdo(0);
                                    break;
                                case 3:
                                    Console.Write("Ingrese el acuerdo de descubierto de la nueva cuenta: ");
                                    fachada.inicializarCajaDeAhorroConAcuerdo(Convert.ToDouble(Console.ReadLine()));
                                    fachada.inicializarCuentaCorrienteConAcuerdo(0);
                                    break;
                                case 4:
                                    Console.Write("Ingrese el acuerdo de descubierto de la nueva cuenta: ");
                                    iAcuerdo = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Ingrese el saldo de la nueva cuenta: ");
                                    iSaldo = Convert.ToDouble(Console.ReadLine());
                                    fachada.inicializarCajaDeAhorroConAcuerdoYSaldo(iAcuerdo, iSaldo);
                                    fachada.inicializarCuentaCorrienteConAcuerdo(0);
                                    break;
                                default:
                                    break;
                            }

                            Console.Clear();
                            pantallaDeSaldos();                             //fuera del main está esta pantalla que será utilizada en repetida ocasiones, y para ahorrar codigo se hizo de esta forma
                            int num = Convert.ToInt32(Console.ReadLine());

                            while (num < 9 & num > 0)       //si el num es distinto de los asignados vuelve a la pantalla inicial
                            {
                                switch (num)
                                {
                                    case 1:
                                        mostrarSaldo(fachada.iCuentasDelCliente.cuentaCorriente.saldo);       
                                        mostrarAcuerdo(fachada.iCuentasDelCliente.cuentaCorriente.acuerdo);   
                                        break;
                                    case 2:
                                        mostrarSaldo(fachada.iCuentasDelCliente.cajaAhorro.saldo);            
                                        mostrarAcuerdo(fachada.iCuentasDelCliente.cajaAhorro.acuerdo);
                                        break;
                                    case 3:
                                        Console.WriteLine("Ingrese el valor a debitar");
                                        mostrarSaldo(fachada.debitarCuentaCorriente(Convert.ToDouble(Console.ReadLine())));
                                        break;
                                    case 4:
                                        Console.WriteLine("Ingrese el valor a debitar");
                                        mostrarSaldo(fachada.debitarCajaAhorro(Convert.ToDouble(Console.ReadLine())));
                                        break;
                                    case 5:
                                        Console.WriteLine("Ingrese el valor a acreditar");
                                        mostrarSaldo(fachada.acreditarCuentaCorriente(Convert.ToDouble(Console.ReadLine())));
                                        break;
                                    case 6:
                                        Console.WriteLine("Ingrese el valor a acreditar");
                                        mostrarSaldo(fachada.acreditarCajaAhorro(Convert.ToDouble(Console.ReadLine())));
                                        break;
                                    case 7:
                                        Console.WriteLine("Ingrese el nuevo monto del acuerdo de descubierto");
                                        fachada.actualizarAcuerdo(fachada.iCuentasDelCliente.cuentaCorriente);                       
                                        Console.WriteLine("Monto actualizado...");
                                        break;
                                    case 8:
                                        Console.WriteLine("Ingrese el nuevo monto del acuerdo de descubierto");
                                        fachada.actualizarAcuerdo(fachada.iCuentasDelCliente.cajaAhorro);                            
                                        Console.WriteLine("Monto actualizado...");
                                        break;
                                    default:
                                        break;
                                }
                                Console.ReadKey();
                                Console.Clear();
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

        /// <summary>
        /// este metodo ubicado fuera del main contiene una escritura en pantalla que se utiliza en repetidas ocasiones
        /// </summary>
        static void mostrarSaldo(double pSaldo)
        {
            Console.WriteLine("El saldo de la cuenta es: " + pSaldo);
        }

        /// <summary>
        /// este metodo ubicado fuera del main contiene una escritura en pantalla que se utiliza en repetidas ocasiones
        /// </summary>
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
