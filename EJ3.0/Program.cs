using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            char mOpcion = '0';
            ControladorPartida controlador = new ControladorPartida();
            while (mOpcion != '3')
            {
                Console.Clear();
                Console.WriteLine("Juego del Ahorcado");
                Console.WriteLine("Seleccione una opcion:");
                Console.WriteLine("1) Iniciar Partida");
                Console.WriteLine("2) Mostrar los HighScores");
                Console.WriteLine("3) Salir");
                mOpcion = Console.ReadKey().KeyChar;
                switch (mOpcion)
                {
                    case '1':
                        {
                            Console.Clear();
                            Console.WriteLine("Ingresa tu nombre de jugador:");
                            string mJugador = Convert.ToString(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("Ingrese la cantidad de fallos para la partida");
                            int mFallos = Convert.ToInt32(Console.ReadLine());
                            string mPalabraSitActual = controlador.IniciarPartida(mJugador, mFallos);
                            Console.Clear();
                            Console.WriteLine("Juego del Ahorcado");
                            do
                            {
                                Console.WriteLine("Palabra: {0}", mPalabraSitActual);
                                Console.WriteLine("Ingrese una letra para jugar:");
                                char mChar = Console.ReadKey().KeyChar;
                                ResultadoJugada mResultado = controlador.RealizarJugada(mChar);
                                mPalabraSitActual = mResultado.PalabraActual;
                                Console.Clear();
                                if (mResultado.Exito)
                                {
                                    Console.WriteLine("Bien hecho, la palabra contiene {0}", mChar);
                                }
                                else
                                {
                                    Console.WriteLine("Error, aun te quedan {0} intentos", controlador.GetFallos());
                                }
                            } while (controlador.GetEstadoPartidaFinalizada());
                            if (controlador.GetFallos() == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Has Perdido");
                                Console.WriteLine("Pulse una tecla para continuar");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Has ganado");
                                bool mBool = controlador.FinalizarPartida();
                                if (mBool)
                                {
                                    Console.WriteLine("Obtuviste un HighScore!");
                                }
                                Console.WriteLine("Pulsa una tecla para continuar");
                                Console.ReadKey();
                            }
                            break;
                        }
                    case '2':
                        {
                            Console.Clear();
                            Console.WriteLine("HighScores:");
                            controlador.MostrarHighScores();
                            Console.WriteLine("Pulse una tecla para continuar");
                            Console.ReadKey();
                            break;
                        }
                    case '3':
                        {
                            break;
                        }
                }
            }
        }
    }
}
