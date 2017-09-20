using System;
public class Cuenta
{
    private double iSaldo;
    private double iAcuerdo;

    public Cuenta(double pAcuerdo)      //constructor de cuenta pasando solo un acuerdo como parametro
    {
        this.saldo = 0;
        this.acuerdo = pAcuerdo;
    }

    public Cuenta(double pSaldoInicial, double pAcuerdo)    //constructor de cuenta pasando de parametros saldoInicial y acuerdo
    {
        this.saldo = pSaldoInicial;
        this.acuerdo = pAcuerdo;
    }

    public double saldo
    {
        get { return this.iSaldo; }
        set { this.iSaldo = value; }
    }

    public double acuerdo
    {
        get { return this.iAcuerdo; }
        set { this.iAcuerdo = value; }
    }

    public void acreditarSaldo(double pSaldo)       //suma un monto al saldo
    {
        this.saldo += pSaldo;
    }

    public bool debitarSaldo(double pSaldo)            //metodo que resta un monto al saldo/acuerdo
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
            Console.WriteLine("Monto superado");
            return false;
        }        
    }
}
