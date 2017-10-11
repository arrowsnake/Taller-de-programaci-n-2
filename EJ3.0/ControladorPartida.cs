using System;

namespace EJ3._0
{
    /// <summary>
    /// Clase encargada de manejar los eventos del sistema
    /// </summary>
    internal class ControladorPartida
    {
        private Partida iPartida;
        private Configuracion iConfiguracion;
        private HighScores iHighScores;
        private ConjuntoPalabras iConjuntoPalabras;

        /// <summary>
        /// Inicializador del controlador
        /// </summary>
        public ControladorPartida()
        {
            HighScores = new HighScores();
            HighScores.Inicializar();
            Configuracion = new Configuracion();
            iConjuntoPalabras = new ConjuntoPalabras();
        }

        /// <summary>
        /// Property get y set de Partida
        /// </summary>
        public Partida Partida
        {
            get { return this.iPartida; }
            set { this.iPartida = value; }
        }

        /// <summary>
        /// Property get de ConjuntoPalabras
        /// </summary>
        public ConjuntoPalabras ConjuntoPalabras
        {
            get { return this.iConjuntoPalabras; }
        }

        /// <summary>
        /// Property get y set de Configuracion
        /// </summary>
        public Configuracion Configuracion
        {
            get { return this.iConfiguracion; }
            set { this.iConfiguracion = value; }
        }

        /// <summary>
        /// Property get y set de HighScores
        /// </summary>
        public HighScores HighScores
        {
            get { return this.iHighScores; }
            set { this.iHighScores = value; }
        }

        /// <summary>
        /// obtiene un string aleatorio de ConjuntoPalabras y guarda el nombre del Jugador, pJugador, en ella para iniciar la partida
        /// </summary>
        /// <param name="pJugador"></param>
        public string IniciarPartida(string pJugador, int pFallos) 
        {
            string pPalabra = ConjuntoPalabras.ObtenerPalabra();
            Partida = new Partida(pPalabra);
            Partida.Jugador = pJugador;
            Configuracion.Fallos = pFallos;
            return new string(Partida.PalabraSitActual);
        }

        /// <summary>
        /// Procedimiento por el cual a partir de un caracter ingresado por el usuario y la partida en curso devuelve un resultado que contiene la situacion actual de la palabra a adivinar y un valor booleano que indica si el caracter ingresado ha generado un acierto o no
        /// </summary>
        /// <param name="pChar"></param>
        /// <param name="pPartida"></param>
        /// <returns></returns>
        public ResultadoJugada RealizarJugada(char pChar)
        {
            ResultadoJugada mResultadoJugada = new ResultadoJugada();
            mResultadoJugada.Exito = false;
            for (int i = 0; i < Partida.Palabra.Length; i++)
            {
                if (Partida.Palabra[i] == pChar)
                {
                    Partida.PalabraSitActual[i] = pChar;
                    mResultadoJugada.Exito = true;
                }
            }
            if (mResultadoJugada.Exito == false)
            {
                Configuracion.RestarFallo();
            }
            mResultadoJugada.PalabraActual = new string(Partida.PalabraSitActual);
            return mResultadoJugada;
        }

        /// <summary>
        /// Cambia la cantidad de Fallos de la siguiente Partida
        /// </summary>
        /// <param name="pFallos"></param>
        public void CambiarCantidadFallos(int pFallos)
        {
            Configuracion.Fallos = pFallos;
        }

        /// <summary>
        /// Devuelve la cantidad de Fallos actual
        /// </summary>
        /// <returns></returns>
        public int GetFallos()
        {
            return Configuracion.Fallos;
        }

        /// <summary>
        /// Devuelve un valor booleano que indica si la partida en curso esta en un estado valido para finalizarla
        /// </summary>
        /// <returns></returns>
        public bool GetEstadoPartidaFinalizada()
        {
            return (GetFallos() > 0 && Partida.Palabra != new string(Partida.PalabraSitActual));
        }

        /// <summary>
        /// Finaliza la partida actual y devuelve un valor booleano que indica si la partida quedo registrada como highscore
        /// </summary>
        /// <returns></returns>
        public bool FinalizarPartida()
        {
            Partida.FinalizarPartida();
            return HighScores.ObtenerHighScore(Partida);
        }

        /// <summary>
        /// Procedimiento que muestra cada Partida de los highscores con puesto, jugador y tiempo en segundos
        /// </summary>
        public void MostrarHighScores()
        {
            HighScores.Mostrar();
        }
    }
}