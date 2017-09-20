using System;
public class Punto
{
    private double iX;
    private double iY;

    public double X
    {
        get { return this.iX; }
        set { this.iX = value; }
    }

    public double Y
    {
        get { return this.iY; }
        set { this.iY = value; }
    }

    public Punto(double pX, double pY)      //Constructor de la clase con 2 parametros
    {
        this.iX = pX;
        this.iY = pY;
    }

    public double distancia(Punto pPunto)
    {
        double difX = (this.iX - pPunto.iX);
        double difY = (this.iY - pPunto.iY);
        return Math.Sqrt((Math.Pow(difX, 2)) + Math.Pow(difY, 2));  //devuelve el calculo de distancia entre 2 puntos, que se calcula con el punto ingresado como parametro y el otro que fue inicialiazado anteriormente
    }
}
