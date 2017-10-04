using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {

        static void Main(string[] args)
        {
            //Atributos que va a usar el número complejo principal
            double iReal;
            double iImaginario;
            //Atributos que va a usar el número complejo secundario
            double iReal2;
            double iImaginario2;
            //Defino el número complejo secundario
            Complejo iComplejo2;

            //Creo una instancia de clase Complejo.
            Console.WriteLine("Ingrese número complejo");
            Console.WriteLine("Parte real:");
            iReal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Parte Imaginaria:");
            iImaginario = Convert.ToDouble(Console.ReadLine());
            Complejo iComplejo = new Complejo(iReal, iImaginario);

            //Menu de opciones
            Console.WriteLine("1 - Comprobar si es un número real");
            Console.WriteLine("2 - Comprobar si es un número imaginario");
            Console.WriteLine("3 - Comprobar si es igual a otro número complejo");
            Console.WriteLine("4 - Magnitud del número complejo");
            Console.WriteLine("5 - Argumento en grados y en radianes");
            Console.WriteLine("6 - Número complejo conjugado");
            Console.WriteLine("7 - Sumar otro número complejo");
            Console.WriteLine("8 - Restar otro número complejo");
            Console.WriteLine("9 - Multiplicar otro número complejo");
            Console.WriteLine("10 - Dividir otro número complejo");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    if (iComplejo.EsReal()) { //comprueba si se trata de un número real.
                        Console.WriteLine("Es un número real");
                    }
                    else
                    {
                        Console.WriteLine("No es un número real");
                    }
                    break;
                case 2:
                    if (iComplejo.EsImaginario()) { //Comprueba si se trata de un número imaginario.
                        Console.WriteLine("Es un número imaginario");
                    }
                    else
                    {
                        Console.WriteLine("No es un número imaginario");
                    }
                    break;
                case 3:
                    //Inicializo el número complejo secundario
                    Console.WriteLine("Ingrese otro número complejo");
                    Console.WriteLine("Parte real:");
                    iReal2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Parte Imaginaria:");
                    iImaginario2 = Convert.ToDouble(Console.ReadLine());
                    iComplejo2 = new Complejo(iReal2, iImaginario2);

                    if (iComplejo.EsIgual(iComplejo2)) //Compruebo si el complejo principal y el secundario son iguales.
                    {
                        Console.WriteLine("Los números complejos son iguales");
                    }
                    else
                    {
                        Console.WriteLine("No son iguales");
                    }
                    break;

                case 4:
                    Console.Write("La magnitud es: {0}", iComplejo.Magnitud);  //Muestro la magnitud del número complejo

                    break;
                case 5:
                    //Muestro el argumento del complejo en grados y en radianes
                    Console.WriteLine("El argumento en grados es: {0}", iComplejo.ArgumentoEnGrados);
                    Console.WriteLine("El argumento en radianes es: {0}", iComplejo.ArgumentoEnRadianes);
                    break;
                case 6:
                    //Muestro el conjugado del número complejo
                    Console.WriteLine("El número complejo conjugado es: {0}", MostrarComplejo(iComplejo.Conjugado));
                    break;
                case 7:
                    //inicializo el complejo secundario
                    Console.WriteLine("Ingrese otro número complejo");
                    Console.WriteLine("Parte real:");
                    iReal2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Parte Imaginaria:");
                    iImaginario2 = Convert.ToDouble(Console.ReadLine());
                    iComplejo2 = new Complejo(iReal2, iImaginario2);
                    //realizo la suma y muestro en pantalla
                    Console.WriteLine(MostrarComplejo(iComplejo) + " + " + MostrarComplejo(iComplejo2) + " = " + MostrarComplejo(iComplejo.Sumar(iComplejo2)));
                    break;
                case 8:
                    //inicializo el complejo secundario
                    Console.WriteLine("Ingrese otro número complejo");
                    Console.WriteLine("Parte real:");
                    iReal2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Parte Imaginaria:");
                    iImaginario2 = Convert.ToDouble(Console.ReadLine());
                    iComplejo2 = new Complejo(iReal2, iImaginario2);

                    //realizo la resta y muestro en pantalla
                    Console.WriteLine(MostrarComplejo(iComplejo) + " - " + MostrarComplejo(iComplejo2) + " = " + MostrarComplejo(iComplejo.Restar(iComplejo2)));
                    break;
                case 9: 
                    //inicializo el complejo secundario
                    Console.WriteLine("Ingrese otro número complejo");
                    Console.WriteLine("Parte real:");
                    iReal2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Parte Imaginaria:");
                    iImaginario2 = Convert.ToDouble(Console.ReadLine());
                    iComplejo2 = new Complejo(iReal2, iImaginario2);

                    //Realizo la multiplicación y muestro en pantalla
                    Console.WriteLine(MostrarComplejo(iComplejo) + " * " + MostrarComplejo(iComplejo2) + " = " + MostrarComplejo(iComplejo.Multiplicar(iComplejo2)));
                    break;
                case 10:
                    //inicializo el complejo secundario
                    Console.WriteLine("Ingrese otro número complejo");
                    Console.WriteLine("Parte real:");
                    iReal2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Parte Imaginaria:");
                    iImaginario2 = Convert.ToDouble(Console.ReadLine());
                    iComplejo2 = new Complejo(iReal2, iImaginario2);

                    //realizo la división y muestro en pantalla.
                    Console.WriteLine(MostrarComplejo(iComplejo) + " / " + MostrarComplejo(iComplejo2) + " = " + MostrarComplejo(iComplejo.Dividir(iComplejo2)));
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Muestra al número complejo en su forma: a + bi
        /// </summary>
        /// <param name="pComplejo">
        /// Complejo que se quiere representar
        /// </param>
        /// <returns></returns>
        static string MostrarComplejo(Complejo pComplejo) 
        {

            if (pComplejo.EsReal())
            {
                return (pComplejo.Real.ToString()); //Si es real, solo muestra el número real
            }
            else if (pComplejo.EsImaginario())
            {
                return (pComplejo.Imaginario + "i"); //Si solo es imaginario, muestra solo el número imaginario
            }
            else if (pComplejo.Imaginario < 0)
            {
                return (pComplejo.Real + " " + pComplejo.Imaginario + "i"); //imaginario negativo: (a - bi)
            }
            else
            {
                return (pComplejo.Real + " +" + pComplejo.Imaginario + "i"); //imaginario positivo: (a + bi)
            }
        }
    }
}
