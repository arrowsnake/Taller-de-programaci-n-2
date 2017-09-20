using System;
public class Triangulo
{
    private Punto iPunto1;
    private Punto iPunto2;
    private Punto iPunto3;

    public Punto punto1
    {
        get { return this.iPunto1; }
        set { this.iPunto1 = value; }   
    }

    public Punto punto2
    {
        get { return this.iPunto2; }
        set { this.iPunto2 = value; }   
    }

    public Punto punto3
    {
        get { return this.iPunto3; }
        set { this.iPunto3 = value; }   
    }

    public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
    {
        this.punto1 = pPunto1;
        this.punto2 = pPunto2;
        this.punto3 = pPunto3;
    }

    public double area()    //fórmula para calcular área de triángulo en eje cartesiando: 1/2 * |(x1 y1 1) (x2 y2 1) (x3 y3 1)|
    {
        double areaT = ((1d / 2d) * (this.punto1.X * this.punto2.Y + this.punto2.X * this.punto3.Y + this.punto3.X * this.punto1.Y - this.punto2.Y * this.punto3.X - this.punto1.X * this.punto3.Y - this.punto1.Y * this.punto2.X));
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