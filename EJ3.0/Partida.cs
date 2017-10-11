using System;
using System.Diagnostics;

namespace EJ3._0
{
    /// <summary>
    /// Clase encargada de manejar la Partida en curso
    /// </summary>
    internal class Partida
    {
        private string iPalabra;
        private char[] iPalabraSitActual;
        private string iJugador;
        private DateTime iTimestampInicio;
        private DateTime iTimestampFin;
        private TimeSpan iDuracion;

        /// <summary>
        /// Inicializa la partida con un string obtenido aleatoriamente y guardado en dos instancias, una de string y una de char[] ya que una se usara para controlar la partida, a su vez ambas sirven para evaluar si una partida se ha ganado o no
        /// </summary>
        /// <param name="pPalabra"></param>
        public Partida(string pPalabra)
        {                                
            this.iPalabra = pPalabra;
            char[] mPalabraSitActual = this.iPalabra.ToCharArray();
            this.iPalabraSitActual = mPalabraSitActual;
            for (int i = 1; i < this.iPalabraSitActual.Length; i++)  // cambia todas las letras luego de la primera por '*', este array sera el que se muestra en pantalla para jugar
            {
                this.PalabraSitActual[i] = '*';
            }
            this.iTimestampInicio = DateTime.Now;
        }

        /// <summary>
        /// Property get y set de la Palabra a adivinar
        /// </summary>
        public string Palabra
        {
            get { return this.iPalabra; }
            set { this.iPalabra = value; }
        }

        /// <summary>
        /// Property get y set de la palabra que contiene los caracteres adivinados
        /// </summary>
        public char[] PalabraSitActual
        {
            get { return this.iPalabraSitActual; }
            set { this.iPalabraSitActual = value; }
        }

        /// <summary>
        /// Property get y set de el campo Jugador
        /// </summary>
        public string Jugador
        {
            get { return this.iJugador; }
            set { this.iJugador = value; }
        }

        /// <summary>
        /// Property que devuelve la duracion de la partida en segundos
        /// </summary>
        public double Duracion  // se utiiza el metodo Math.Truncate para eliminar la parte decimal al mostrarlo
        {
            get { return Math.Truncate(this.iDuracion.TotalSeconds); }
        }

        /// <summary>
        /// Obtiene la duracion de la partida en una instancia TimeSpan la cual sera a segundos en formato double al utilizar el metodo get de Duracion
        /// </summary>
        public void FinalizarPartida()
        {
            this.iTimestampFin = DateTime.Now;
            this.iDuracion = this.iTimestampFin - this.iTimestampInicio;
        }
    }
}