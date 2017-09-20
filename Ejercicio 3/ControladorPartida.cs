using System;

namespace Ejercicio3
{
    internal class ControladorPartida
    {
        private int iFallos;
        private string[] cPalabras = {"manzana", "lechuga", "repollo", "mango", "espinaca", "remolacha", "hardware", "software", "alcachofa", "camionero", "gabinete", "referencia", "persiana", "codigo", "cabeza", "corriente", "energia", "unidad", "cielorraso", "geografia", "internet", "linterna", "celular", "precio", "bateria", "memoria", "inundacion", "mermelada", "bayoneta", "amnistia"};
        private Partida iPartida;

        public int Fallos
        {
            get { return this.iFallos; }
            set { this.iFallos = value; }
        }

        public Partida Partida
        {
            get { return this.iPartida; }
        }

        public void IniciarPartida() // obtiene un string aleatorio del arreglo de strings para iniciar la partida
        {
            int index =  new Random().Next(0, 29);
            string pPalabra = cPalabras[index];
            this.iPartida = new Partida(pPalabra);
        }

        public bool RealizarJugada(char pChar, Partida pPartida) // a partir de un caracter obtenido por el usuario y la partida en curso se obtiene un valor booleano que indica si el caracter ingresado ha generado un acierto o no
        {
            bool mValido = false;
            for (int i = 0; i < pPartida.Palabra.Length; i++)
            {
                if (pPartida.Palabra[i] == pChar)
                {
                    pPartida.PalabraSitActual[i] = pChar;
                    mValido = true;
                }
            }
            if (mValido == false)
            {
                this.Fallos--;
            }
            return mValido;
        }

        public void CambiarCantidadFallos(int pFallos)
        {
            iFallos = pFallos;
        }
    }
}