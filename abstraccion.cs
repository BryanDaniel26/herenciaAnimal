using Internal;
using System;

abstract class F{
    private string x = "Ferreiras, Castro";
    private double y = 1.34E+12;
    private long z = 98764354;
    protected byte w = 34;

    public F(string x, double y, long z, byte w)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.w = w;
    }

    public string getX()
    {
        return x;
    }

    public double getY()
    {
        return y;
    }

    public long getZ()
    {
        return z;
    }

    abstract public void verObjeto();

}

class G : F
{
    private int s = 9998833;

    public G(int s)
    {
        this.s = s;
    }

    public override void verObjeto()
    {
        Console.WriteLine("Estado del objeto..");
    }
}

class teste
{
    public static void Main()
    {
        G num = new G();
        num.verObjeto();

        F num1 = new F();
        num1.getX("Daniel");
        num1.getY(4353254);
        num1.getZ(038428435485);
        num1.verObjeto();
    }
}