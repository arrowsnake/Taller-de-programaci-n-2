using System;
public class Circulo
{
    private Punto iCentro;
    private double iRadio;

    public Circulo(Punto pCentro, double pRadio)        //Constructor con 2 parametros
    {
        this.iCentro = pCentro;
        this.iRadio = pRadio;
    }

    public Circulo(double pX, double pY, double pRadio) //Constructor con 3 parametros
    {
        this.iCentro = new Punto(pX, pY);
        this.iRadio = pRadio;
    }

    public Punto centro
    {
        get { return this.iCentro; }
        set { this.iCentro = value; }   
    }

    public double radio
    {
        get { return this.iRadio; }
        set { this.iRadio = value; }
    }

    public double area()
    {
        return (Math.PI * Math.Pow(this.iRadio, 2));
    }

    public double perimetro()
    {
        return (2 * this.iRadio * Math.PI);
    }
}