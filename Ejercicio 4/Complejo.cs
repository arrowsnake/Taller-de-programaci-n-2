using System;

namespace Ejercicio4
{
    /// <summary>
    /// Clase que representa a un número complejo
    /// </summary>
    public class Complejo
    {
        private double iReal;
        private double iImaginario;
        

        /// <summary>
        /// Constructor que se encarga de instanciar un objeto de clase Complejo
        /// </summary>
        /// <param name="pReal">
        /// Término real del complejo
        /// </param>
        /// <param name="pImaginario">
        /// Término imaginario del complejo
        /// </param>
        public Complejo(double pReal, double pImaginario)
        {
            this.iReal = pReal;
            this.iImaginario = pImaginario;
        }

        /// <summary>
        /// Término Real del número complejo
        /// </summary>
        public double Real
        {
            get { return this.iReal; }
        }

        /// <summary>
        /// Término imaginario del número complejo
        /// </summary>
        public double Imaginario //solo lectura, devuelve el valor imaginario
        {
            get { return this.iImaginario; }
        }

        /// <summary>
        /// Verdadero si se trata de un número real, falso si no.
        /// </summary>
        /// <returns></returns>
        public bool EsReal() 
        {
            if (this.Imaginario == 0)
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Verdadero si es un número imaginario, falso si no.
        /// </summary>
        /// <returns></returns>
        public bool EsImaginario()
        {
            if (this.Real == 0)
            {
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Compara con otro complejo, es verdadero si son iguales
        /// </summary>
        /// <param name="pOtroComplejo">
        /// Complejo con el que se compara
        /// </param>
        /// <returns></returns>

        public bool EsIgual(Complejo pOtroComplejo) 
        {
            if ((this.Real == pOtroComplejo.Real) && (this.Imaginario == pOtroComplejo.Imaginario))
            {
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Devuelve la magnitud del número complejo
        /// </summary>
        public double Magnitud 
        {
            get { return Math.Sqrt(Math.Pow(this.Real, 2) + Math.Pow(this.Imaginario, 2)); }  //Cálculo de la magnitud de un número complejo
        }

        /// <summary>
        /// Devuelve el argumento del complejo en radianes.
        /// </summary>
        public double ArgumentoEnRadianes 
        {
            get { return Math.Tan(this.Imaginario / this.Real); }
        }

        /// <summary>
        /// Devuelve el argumento del complejo en grados.
        /// </summary>
        public double ArgumentoEnGrados 
        {
            get { return (this.ArgumentoEnRadianes * (180 / Math.PI)); }  //paso los radianes a grados
        }

        /// <summary>
        /// Devuelve el conjugado del complejo
        /// </summary>
        public Complejo Conjugado 
        {
            get { return (new Complejo(this.Real,(this.Imaginario * (-1)) )); }
        }

        /// <summary>
        /// devuelve el resultado de la suma con otro complejo
        /// </summary>
        /// <param name="pOtroComplejo">
        /// Complejo que queremos sumar
        /// </param>
        /// <returns></returns>
        public Complejo Sumar (Complejo pOtroComplejo) 
        {
            return (new Complejo((this.Real + pOtroComplejo.Real), (this.Imaginario + pOtroComplejo.Imaginario)));  //cálculo de la suma de dos complejos
        }

        /// <summary>
        /// Devuelve el resultado de la resta con otro complejo
        /// </summary>
        /// <param name="pOtroComplejo">
        /// Complejo que queremos restar
        /// </param>
        /// <returns></returns>
        public Complejo Restar(Complejo pOtroComplejo) 
        {
            return (new Complejo((this.Real - pOtroComplejo.Real), (this.Imaginario - pOtroComplejo.Imaginario)));  //cálculo de la resta de dos complejos
        }

        /// <summary>
        /// Devuelve el resultado de la multiplicación con otro complejo
        /// </summary>
        /// <param name="pOtroComplejo">
        /// Complejo que queremos multiplicar
        /// </param>
        /// <returns></returns>
        public Complejo Multiplicar(Complejo pOtroComplejo)
        {
            return (new Complejo(((this.Real * pOtroComplejo.Real) - (this.Imaginario * pOtroComplejo.Imaginario)), ((this.Real * pOtroComplejo.Imaginario) + (this.Imaginario * pOtroComplejo.Real)))); //Cálculo de la multiplicación de dos complejos por distributiva
        }

        /// <summary>
        /// Devuelve el resultado de la división con otro complejo
        /// </summary>
        /// <param name="pOtroComplejo">
        /// Complejo que hace del divisor
        /// </param>
        /// <returns></returns>
        public Complejo Dividir(Complejo pOtroComplejo)
        {
            return (new Complejo(((this.Real * pOtroComplejo.Imaginario) + (this.Imaginario * pOtroComplejo.Real)) / ((Math.Pow(pOtroComplejo.Real, 2)) * (Math.Pow(pOtroComplejo.Imaginario, 2))), ((this.Imaginario * pOtroComplejo.Imaginario) - (this.Real * pOtroComplejo.Real)) / ((Math.Pow(pOtroComplejo.Real, 2)) * (Math.Pow(pOtroComplejo.Imaginario, 2))))); //cálculo de la división de dos complejos.
        }
    }
}