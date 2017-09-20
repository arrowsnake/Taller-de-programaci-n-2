using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            char mOpcion = '0';
            ControladorPartida controlador = new ControladorPartida();
            HighScores highScores = new HighScores();
            highScores.Inicializar();
            controlador.Fallos = 10;
            while (mOpcion != '4')
            {
                Console.Clear();
                Console.WriteLine("Juego del Ahorcado");
                Console.WriteLine("Seleccione una opcion:");
                Console.WriteLine("1) Cambiar cantidad de fallos    Cantidad actual: {0}", controlador.Fallos);
                Console.WriteLine("2) Iniciar Partida");
                Console.WriteLine("3) Mostrar los HighScores");
                Console.WriteLine("4) Salir");
                mOpcion = Console.ReadKey().KeyChar;
                switch (mOpcion)
                {
                    case '1':
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese la nueva cantidad de fallos: ");
                            controlador.Fallos = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                    case '2':
                        {
                            controlador.IniciarPartida();
                            Console.Clear();
                            Console.WriteLine("Juego del Ahorcado");
                            do
                            {
                                string mPalabraSitActual = new string(controlador.Partida.PalabraSitActual);
                                Console.WriteLine("Palabra: {0}", mPalabraSitActual);
                                Console.WriteLine("Ingrese una letra para jugar:");
                                char mChar = Console.ReadKey().KeyChar;
                                bool mBool = controlador.RealizarJugada(mChar, controlador.Partida);
                                Console.Clear();
                                if (mBool)
                                {
                                    Console.WriteLine("Bien hecho, la palabra contiene {0}", mChar);
                                }
                                else
                                {
                                    Console.WriteLine("Error, aun te quedan {0} intentos", controlador.Fallos);
                                }
                            } while (controlador.Fallos > 0 && controlador.Partida.Palabra != new string (controlador.Partida.PalabraSitActual));
                            if (controlador.Fallos == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Has Perdido");
                                Console.WriteLine("Pulse una tecla para continuar");
                                controlador.Fallos = 10;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Has ganado");
                                Console.WriteLine("Ingresa tu nombre de jugador:");
                                string mJugador = Convert.ToString(Console.ReadLine());
                                controlador.Partida.FinalizarPartida(mJugador);
                                bool mBool = highScores.ObtenerHighScore(controlador.Partida);
                                if (mBool)
                                {
                                    Console.WriteLine("Obtuviste un HighScore!");
                                }
                                controlador.Fallos = 10;
                                Console.WriteLine("Pulsa una tecla para continuar");
                                Console.ReadKey();
                            }
                            break;
                        }
                    case '3':
                        {
                            Console.Clear();
                            Console.WriteLine("HighScores:");
                            highScores.Mostrar();
                            Console.WriteLine("Pulse una tecla para continuar");
                            Console.ReadKey();
                            break;
                        }
                    case '4':
                        {
                            break;
                        }
                }
            }
        }
    }
}
