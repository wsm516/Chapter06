using System;

class ISwap
{
    public int x, y;
    public void swap()
    {
        int temp;
        temp = x; x = y; y = temp;
    }
}
 
class DSwap
{
    public double x, y;
    public void swap()
    {
        double temp;
        temp = x; x = y; y = temp;
    }
}

public class ExerciseCh06_11
{
    public static void Main(String[] args)
    {
        ISwap i = new ISwap();
        i.x = 1; i.y = 2;
        Console.WriteLine("x: " + i.x + " y: " + i.y);
        i.swap();
        Console.WriteLine("x: " + i.x + " y: " + i.y);
        DSwap d = new DSwap();
        d.x = 1.0; d.y = 2.0;
        Console.WriteLine("x: " + d.x + " y: " + d.y);
        d.swap();
        Console.WriteLine("x: " + d.x + " y: " + d.y);
    }
} 
