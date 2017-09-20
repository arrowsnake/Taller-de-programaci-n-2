using System;

namespace Ejercicio1
{
    internal class FachadaGeometria
    {
        internal double calcularDistanciaPuntos(double x1, double y1, double x2, double y2)
        {
            Punto cualquierPunto1 = new Punto(x1, y1);              //creo los puntos
            Punto cualquierPunto2 = new Punto(x2, y2);
            return(cualquierPunto1.distancia(cualquierPunto2));     //llama al metodo que calcula la distancia entre ambos y lo devuelve
        }

        internal double calcularAreaCirculo(double x1, double y1, double cualquierRadio)
        {
            Punto cualquierCentro = new Punto(x1, y1);                                  //crea un objeto de tipo punto
            Circulo cualquierCirculo = new Circulo(cualquierCentro, cualquierRadio);    //crea un objeto de tipo circulo
            return (cualquierCirculo.area());                                           //llama al metodo que calcula el area del circulo
        }

        internal double calcularPerimetroCirculo(double x1, double y1, double cualquierRadio)
        {
            Punto cualquierCentro = new Punto(x1, y1);                                  //crea un objeto de tipo punto
            Circulo cualquierCirculo = new Circulo(cualquierCentro, cualquierRadio);    //crea un objeto de tipo circulo
            return (cualquierCirculo.perimetro());                                      //llama al metodo que calcula el perimetro del circulo
        }

        internal double calcularAreaTriangulo(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            Punto cualquierPuntoT1 = new Punto(x1, y1);             //crea objetos de tipo punto
            Punto cualquierPuntoT2 = new Punto(x2, y2);
            Punto cualquierPuntoT3 = new Punto(x3, y3);
            Triangulo cualquierTriangulo = new Triangulo(cualquierPuntoT1, cualquierPuntoT2, cualquierPuntoT3);     //crea un objeto de tipo triangulo
            return (cualquierTriangulo.area());         //llama al metodo que calcula el area del triangulo
        }
    }
}