using System;

/// <summary>
/// esta clase se encarga de crear un punto con dos coordenadas del eje cartesiano (x, y), además de poder calcular la distancia entre dos objetos "Punto"
/// </summary>
public class Punto
{
    private double iX;
    private double iY;

    /// <summary>
    /// property de x (coordenada en x del punto)
    /// </summary>
    public double x
    {
        get { return this.iX; }
        set { this.iX = value; }
    }

    /// <summary>
    /// property de y (coordenada en y del punto)
    /// </summary>
    public double y
    {
        get { return this.iY; }
        set { this.iY = value; }
    }

    /// <summary>
    /// Constructor de la clase "Punto" con 2 parametros
    /// </summary>
    /// <param name="pX">
    /// de tipo double, será asignado a iX
    /// </param>
    /// de tipo double, será asignado a iY
    /// <param name="pY"></param>
    public Punto(double pX, double pY) 
    {
        this.iX = pX;
        this.iY = pY;
    }

    /// <summary>
    /// metodo que calcula la distancia entre dos objetos de clase "Punto", el primero es el creado con el constructor
    /// </summary>
    /// <param name="pPunto">
    /// es el segundo objeto de clase "Punto" que se le ingresa
    /// </param>
    /// <returns>
    /// devuelve el calculo de distancia
    /// </returns>
    public double distancia(Punto pPunto)
    {
        double difX = (this.iX - pPunto.iX);
        double difY = (this.iY - pPunto.iY);
        return Math.Sqrt((Math.Pow(difX, 2)) + Math.Pow(difY, 2));
    }
}
