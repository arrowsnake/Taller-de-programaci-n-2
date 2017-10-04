using System;

/// <summary>
/// esta clase se encarga de crear un triángulo con con 3 objetos puntos de tipo "Punto", además de poder calcular el área de un objeto de tipo "Triangulo"
/// </summary>
public class Triangulo
{
    private Punto iPunto1;
    private Punto iPunto2;
    private Punto iPunto3;

    /// <summary>
    /// property de punto1, el primer punto de los necesarios para un objeto de clase "Triangulo"
    /// </summary>
    public Punto punto1
    {
        get { return this.iPunto1; }
        set { this.iPunto1 = value; }   
    }

    /// <summary>
    /// property de punto2, el segundo punto de los necesarios para un objeto de clase "Triangulo"
    /// </summary>
    public Punto punto2
    {
        get { return this.iPunto2; }
        set { this.iPunto2 = value; }   
    }

    /// <summary>
    /// property de punto3, el tercer punto de los necesarios para un objeto de clase "Triangulo"
    /// </summary>
    public Punto punto3
    {
        get { return this.iPunto3; }
        set { this.iPunto3 = value; }   
    }

    /// <summary>
    /// constructor de la clase "Triangulo" con 3 parametros
    /// </summary>
    /// <param name="pPunto1">
    /// de tipo "Punto", será asignado a punto1
    /// </param>
    /// <param name="pPunto2">
    /// de tipo "Punto", será asignado a punto2
    /// </param>
    /// <param name="pPunto3">
    /// de tipo "Punto", será asignado a punto3
    /// </param>
    public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
    {
        this.punto1 = pPunto1;
        this.punto2 = pPunto2;
        this.punto3 = pPunto3;
    }

    /// <summary>
    /// metodo que calcula el area de un objeto "Triangulo"
    /// </summary>
    /// <returns>
    /// devuelve un double, que es el calculo del area
    /// </returns>
    public double area()    //fórmula para calcular área de triángulo en eje cartesiando: 1/2 * |(x1 y1 1) (x2 y2 1) (x3 y3 1)|
    {
        double areaT = ((1d / 2d) * (this.punto1.x * this.punto2.y + this.punto2.x * this.punto3.y + this.punto3.x * this.punto1.y - this.punto2.y * this.punto3.x - this.punto1.x * this.punto3.y - this.punto1.y * this.punto2.x));
        if (areaT >= 0)
        {
            return areaT;
        }

        else
        {
            return (areaT * (-1));      //valor absoluto del area
        }
    }
}