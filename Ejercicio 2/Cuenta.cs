using System;

/// <summary>
/// esta clase se encarga de crear una cuenta que tendrá un saldo y un acuerdo de descubierto. Esta cuenta será asignada a un objeto cuentas, que estará asignada a un objeto cliente. Además posee metodos que pueden aumentar o decrementar el valor del saldo
/// </summary>
public class Cuenta
{
    private double iSaldo;
    private double iAcuerdo;

    /// <summary>
    /// constructor del objeto cuenta pasando solo un acuerdo como parametro. Se utiliza si solo se quiere crear cuenta con acuerdo, debido que se asigna el valor 0 a saldo
    /// </summary>
    /// <param name="pAcuerdo">
    /// de tipo double, es la cantidad de dinero que el cliente puede gastar sin ser de su pertenencia
    /// </param>
    public Cuenta(double pAcuerdo)      
    {
        this.saldo = 0;
        this.acuerdo = pAcuerdo;
    }

    /// <summary>
    /// constructor de cuenta pasando 2 parametros, un saldo inicial y un acuerdo
    /// </summary>
    /// <param name="pSaldoInicial">
    /// de tipo double, es el dinero perteneciente al cliente
    /// </param>
    /// <param name="pAcuerdo">
    /// de tipo double, es la cantidad de dinero que el cliente puede gastar sin ser de su pertenencia
    /// </param>
    public Cuenta(double pSaldoInicial, double pAcuerdo)    
    {
        this.saldo = pSaldoInicial;
        this.acuerdo = pAcuerdo;
    }

    /// <summary>
    /// property de saldo (dinero perteneciente al cliente que se asigna al objeto cuenta)
    /// </summary>
    public double saldo
    {
        get { return this.iSaldo; }
        set { this.iSaldo = value; }
    }

    /// <summary>
    /// property de acuerdo (dinero que no pertenece al cliente pero que puede gastarlo, que se asigna al objeto cuenta)
    /// </summary>
    public double acuerdo
    {
        get { return this.iAcuerdo; }
        set { this.iAcuerdo = value; }
    }

    /// <summary>
    /// método que suma un monto al saldo
    /// </summary>
    /// <param name="pSaldo">
    /// el monto que será aumentado
    /// </param>
    public void acreditarSaldo(double pSaldo)       
    {
        this.saldo += pSaldo;
    }

    /// <summary>
    /// método que resta un monto al saldo
    /// </summary>
    /// <param name="pSaldo">
    /// el monto que será restado
    /// </param>
    public bool debitarSaldo(double pSaldo)            
    {
        if (this.iSaldo > pSaldo)     //si el saldo es mayor al monto ingresado
        {
            this.saldo -= pSaldo;
            return true;
        }

        else if ((this.iAcuerdo + this.iSaldo) > pSaldo)    //si el saldo junto con el acuerdo son mayores al monto ingresado
        {
            this.acuerdo -= (pSaldo - this.iSaldo);
            this.saldo = 0;
            return true;
        }

        else    //si el monto ingresado es mayor, devuelve false
        {
            return false;
        }        
    }
}
