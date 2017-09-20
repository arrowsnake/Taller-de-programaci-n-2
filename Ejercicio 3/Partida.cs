using System;
using System.Diagnostics;

namespace Ejercicio3
{
    internal class Partida
    {
        private string iPalabra;
        private char[] iPalabraSitActual;
        private string iJugador;
        private DateTime iTimestampInicio;
        private DateTime iTimestampFin;
        private TimeSpan iDuracion;

        public Partida(string pPalabra)  // inicia la partida con un string obtenido aleatoriamente y guardado en dos instancias, una de string y una de char[] ya que una se usara para controlar la partida
        {                                // a su vez ambas sirven para evaluar si una partida se ha ganado o no
            this.iPalabra = pPalabra;
            char[] mPalabraSitActual = this.iPalabra.ToCharArray();
            this.iPalabraSitActual = mPalabraSitActual;
            for (int i = 1; i < this.iPalabraSitActual.Length; i++)  // cambia todas las letras luego de la primera por '*', este array sera el que se muestra en pantalla para jugar
            {
                this.PalabraSitActual[i] = '*';
            }
            this.iTimestampInicio = DateTime.Now;
        }

        public string Palabra
        {
            get { return this.iPalabra; }
            set { this.iPalabra = value; }
        }

        public char[] PalabraSitActual
        {
            get { return this.iPalabraSitActual; }
            set { this.iPalabraSitActual = value; }
        }

        public string Jugador
        {
            get { return this.iJugador; }
            set { this.iJugador = value; }
        }

        public double Duracion  // se utiiza el metodo Math.Truncate para eliminar la parte decimal al mostrarlo
        {
            get { return Math.Truncate(this.iDuracion.TotalSeconds); }
        }

        public void FinalizarPartida(string pJugador)  //obtiene la duracion de la partida en una instancia TimeSpan la cual sera a segundos en formato double al utilizar el metodo get de Duracion
        {
            this.iTimestampFin = DateTime.Now;
            this.iDuracion = this.iTimestampFin - this.iTimestampInicio;
            this.iJugador = pJugador;
        }
    }
}