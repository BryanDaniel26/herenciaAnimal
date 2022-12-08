/*
    Este codigo fuente fue escrito por Bryan Mendez
    Implementacion de clase uml dada por el maestro
    Fecha inicio: 7/12/22 Fecha fin: 8/12/22    

*/


using System;

abstract class F{
    private string x;
    private double y;
    private long z;
    protected byte w;

    public F(string x, double y, long z, byte w)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.w = w;
    }

    public F()
    {
        x = "Ferreiras Castro";
        y = 1.34E+12;
        z = 98764354;
        w = 34;
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
    private int s;

    public G(int s)
    {
        this.s = s;
    }
    public G()
    {
        s =  9998833;
    }

    public override void verObjeto()
    {
        Console.WriteLine("Estado del objeto..");
        Console.WriteLine(getX(), "\n", getY(), "\n", getZ(), "\n", w);
    }
}

class teste
{
    public static void Main()
    {
        G num = new G();
        num.verObjeto();


        F num1 = new G();
        num1.getX();
        num1.getY();
        num1.getZ();
        num1.verObjeto();
    }
}