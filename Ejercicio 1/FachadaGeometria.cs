using System;

namespace Ejercicio1
{
    /// <summary>
    /// controlador de fachada
    /// </summary>
    internal class FachadaGeometria
    {
        /// <summary>
        /// metodo que calcula la distancia entre dos objetos de clase "Punto"
        /// </summary>
        /// <param name="x1">
        /// de tipo double, parametro con el que se creará el primer objeto Punto (coordenada en x)
        /// </param>
        /// <param name="y1">
        /// de tipo double, parametro con el que se creará el primer objeto Punto (coordenada en y)
        /// </param>
        /// <param name="x2">
        /// de tipo double, parametro con el que se creará el segundo objeto Punto (coordenada en x)
        /// </param>
        /// <param name="y2">
        /// de tipo double, parametro con el que se creará el segundo objeto Punto (coordenada en y)
        /// </param>
        /// <returns>
        /// llama al metodo que calcula la distancia entre ambos objetos y devuelve el resultado
        /// </returns>
        internal double calcularDistanciaPuntos(double x1, double y1, double x2, double y2)
        {
            Punto cualquierPunto1 = new Punto(x1, y1);              
            Punto cualquierPunto2 = new Punto(x2, y2);
            return(cualquierPunto1.distancia(cualquierPunto2));
        }

        /// <summary>
        /// método que calcula el área de un objeto de clase "Circulo"
        /// </summary>
        /// <param name="x1">
        /// de tipo double, parametro con el que se creará un objeto de clase "Punto" (coordenada en x)
        /// </param>
        /// <param name="y1">
        /// de tipo double, parametro con el que se creará un objeto de clase "Punto" (coordenada en y)
        /// </param>
        /// <param name="cualquierRadio">
        /// de tipo double, parametro con el que se creará un objeto de clase "Circulo"
        /// </param>
        /// <returns>
        /// llama al método que calcula el área del circulo y devuelve el resultado
        /// </returns>
        internal double calcularAreaCirculo(double x1, double y1, double cualquierRadio)
        {
            Punto cualquierCentro = new Punto(x1, y1);                                  //crea un objeto de tipo punto y se lo asigna a esta variable
            Circulo cualquierCirculo = new Circulo(cualquierCentro, cualquierRadio);    //crea un objeto de tipo circulo con la variable anterior y el parametro de entrada cualquierRadio
            return (cualquierCirculo.area());                                           
        }

        /// <summary>
        /// método que calcula el perimetro de un objeto de clase "Circulo"
        /// </summary>
        /// <param name="x1">
        /// de tipo double, parametro con el que se creará un objeto de clase "Punto" (coordenada en x)
        /// </param>
        /// <param name="y1">
        /// de tipo double, parametro con el que se creará un objeto de clase "Punto" (coordenada en y)
        /// </param>
        /// <param name="cualquierRadio">
        /// de tipo double, parametro con el que se creará un objeto de clase "Circulo"
        /// </param>
        /// <returns>
        /// llama al método que calcula el perimetro del circulo y devuelve el resultado
        /// </returns>
        internal double calcularPerimetroCirculo(double x1, double y1, double cualquierRadio)
        {
            Punto cualquierCentro = new Punto(x1, y1);                                  //crea un objeto de tipo punto y se lo asigna a esta variable
            Circulo cualquierCirculo = new Circulo(cualquierCentro, cualquierRadio);    //crea un objeto de tipo circulo con la variable anterior y el parametro de entrada cualquierRadio
            return (cualquierCirculo.perimetro());                                      
        }

        /// <summary>
        /// método que calcula el área de un objeto de clase "Triangulo", al que se le pasan 6 parametros de entrada de tipo double que contendrán las coordenadas de los objetos "Punto" que se creearán
        /// </summary>
        /// <param name="x1">
        /// de tipo double, parametro con el que se creará el primer objeto Punto (coordenada en x)
        /// </param>
        /// <param name="x2">
        /// de tipo double, parametro con el que se creará el segundo objeto Punto (coordenada en x)
        /// </param>
        /// <param name="x3">
        /// de tipo double, parametro con el que se creará el tercer objeto Punto (coordenada en x)
        /// </param>
        /// <param name="y1">
        /// de tipo double, parametro con el que se creará el primer objeto Punto (coordenada en y)
        /// </param>
        /// <param name="y2">
        /// de tipo double, parametro con el que se creará el segundo objeto Punto (coordenada en y)
        /// </param>
        /// <param name="y3">
        /// de tipo double, parametro con el que se creará el tercer objeto Punto (coordenada en y)
        /// </param>
        /// <returns>
        /// llama al método que calcula el área del objeto de clase Triangulo y devuelve el resultado
        /// </returns>
        internal double calcularAreaTriangulo(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            Punto cualquierPuntoT1 = new Punto(x1, y1);             
            Punto cualquierPuntoT2 = new Punto(x2, y2);
            Punto cualquierPuntoT3 = new Punto(x3, y3);
            Triangulo cualquierTriangulo = new Triangulo(cualquierPuntoT1, cualquierPuntoT2, cualquierPuntoT3);     //crea un objeto de tipo triangulo
            return (cualquierTriangulo.area());         
        }
    }
}