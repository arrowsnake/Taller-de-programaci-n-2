using System;

namespace Ejercicio3
{
    /// <summary>
    /// Clase que contiene un arreglo de palabras que se utilizan para el juego
    /// </summary>
    internal class ConjuntoPalabras
    {
        private string[] cPalabras = { "manzana", "lechuga", "repollo", "mango", "espinaca", "remolacha", "hardware", "software", "alcachofa", "camionero", "gabinete", "referencia", "persiana", "codigo", "cabeza", "corriente", "energia", "unidad", "cielorraso", "geografia", "internet", "linterna", "celular", "precio", "bateria", "memoria", "inundacion", "mermelada", "bayoneta", "amnistia" };

        /// <summary>
        /// Obtiene un string aleatorio del conjunto de palabras
        /// </summary>
        /// <returns></returns>
        public string ObtenerPalabra()
        {
            int index = new Random().Next(0, 29);
            return cPalabras[index];
        }
    }
}