using System;
/// <summary>
/// esta clase se encarga de crear un circulo con un centro de tipo "Punto" y un radio, además de poder calcular su área o perimetro
/// </summary>
public class Circulo
{
    private Punto iCentro;
    private double iRadio;

    /// <summary>
    /// constructor de doble parametro de la clase "Circulo"
    /// </summary>
    /// <param name="pCentro">
    /// de tipo "Punto" que será asignado a iCentro
    /// </param>
    /// <param name="pRadio">
    /// de tipo double, que será asignado a iRadio
    /// </param>
    public Circulo(Punto pCentro, double pRadio)        
    {
        this.iCentro = pCentro;
        this.iRadio = pRadio;
    }

    /// <summary>
    /// constructor de triple parametro de la clase "Circulo"
    /// </summary>
    /// <param name="pX">
    /// de tipo double, para crear un objeto de clase "Punto" que necesita una coordenada x
    /// </param>
    /// <param name="pY">
    /// de tipo double, para crear un objeto de clase "Punto" que necesita una coordenada y
    /// </param>
    /// <param name="pRadio">
    /// de tipo double, que será asignado a iRadio
    /// </param>
    public Circulo(double pX, double pY, double pRadio)
    {
        this.iCentro = new Punto(pX, pY);
        this.iRadio = pRadio;
    }

    /// <summary>
    /// property de centro, que es un "Punto" formado por dos coordenadas
    /// </summary>
    public Punto centro
    {
        get { return this.iCentro; }
        set { this.iCentro = value; }   
    }

    /// <summary>
    /// property de radio (distancia desde el centro a cualquier punto de la circunferencia)
    /// </summary>
    public double radio
    {
        get { return this.iRadio; }
        set { this.iRadio = value; }
    }

    /// <summary>
    /// calcula el área del circulo
    /// </summary>
    public double area()
    {
        return (Math.PI * Math.Pow(this.iRadio, 2));
    }
    
    /// <summary>
    /// calcula el perimetro del circulo
    /// </summary>
    public double perimetro()
    {
        return (2 * this.iRadio * Math.PI);
    }
}