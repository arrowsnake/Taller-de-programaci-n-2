using System;

namespace Ejercicio4
{
    public class Complejo
    {
        private double iReal;
        private double iImaginario;

        public Complejo(double pReal, double pImaginario) //Constructor, para instanciar un objeto de clase complejo.
        {
            this.iReal = pReal;
            this.iImaginario = pImaginario;
        }

        public double Real //Solo lectura, devuelve el valor real
        {
            get { return this.iReal; }
        }

        public double Imaginario //solo lectura, devuelve el valor imaginario
        {
            get { return this.iImaginario; }
        }

        public bool EsReal() //Verdadero si es un número real, falso si no.
        {
            if (this.Imaginario == 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool EsImaginario() //Verdadero si es un número imaginario, falso si no.
        {
            if (this.Real == 0)
            {
                return true;
            }
            else return false;
        }

        public bool EsIgual(Complejo pOtroComplejo)  //Verdadero si es igual al otro complejo, falso si no.
        {
            if ((this.Real == pOtroComplejo.Real) && (this.Imaginario == pOtroComplejo.Imaginario))
            {
                return true;
            }
            else return false;
        }

        public double Magnitud  //devuelve la magnitud del número complejo
        {
            get { return Math.Sqrt(Math.Pow(this.Real, 2) + Math.Pow(this.Imaginario, 2)); }  //Cálculo de la magnitud de un número complejo
        }

        public double ArgumentoEnRadianes //devuelve el argumento en radianes.
        {
            get { return Math.Tan(this.Imaginario / this.Real); }
        }
        public double ArgumentoEnGrados //devuelve el argumento en grados.
        {
            get { return (this.ArgumentoEnRadianes * (180 / Math.PI)); }  //paso los radianes a grados
        }
        public Complejo Conjugado //devuelve el conjugado del complejo
        {
            get { return (new Complejo(this.Real,(this.Imaginario * (-1)) )); }
        }

        public Complejo Sumar (Complejo pOtroComplejo) //devuelve el resultado de la suma con otro complejo
        {
            return (new Complejo((this.Real + pOtroComplejo.Real), (this.Imaginario + pOtroComplejo.Imaginario)));  //cálculo de la suma de dos complejos
        }

        public Complejo Restar(Complejo pOtroComplejo) //devuelve el resultado de la resta con otro complejo
        {
            return (new Complejo((this.Real - pOtroComplejo.Real), (this.Imaginario - pOtroComplejo.Imaginario)));  //cálculo de la resta de dos complejos
        }

        public Complejo Multiplicar(Complejo pOtroComplejo)
        {
            return (new Complejo(((this.Real * pOtroComplejo.Real) - (this.Imaginario * pOtroComplejo.Imaginario)), ((this.Real * pOtroComplejo.Imaginario) + (this.Imaginario * pOtroComplejo.Real)))); //Cálculo de la multiplicación de dos complejos por distributiva
        }

        public Complejo Dividir(Complejo pOtroComplejo)
        {
            return (new Complejo(((this.Real * pOtroComplejo.Imaginario) + (this.Imaginario * pOtroComplejo.Real)) / ((Math.Pow(pOtroComplejo.Real, 2)) * (Math.Pow(pOtroComplejo.Imaginario, 2))), ((this.Imaginario * pOtroComplejo.Imaginario) - (this.Real * pOtroComplejo.Real)) / ((Math.Pow(pOtroComplejo.Real, 2)) * (Math.Pow(pOtroComplejo.Imaginario, 2))))); //cálculo de la división de dos complejos.
        }
    }
}