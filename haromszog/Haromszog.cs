namespace Haromszog;

internal class Haromszog
{
    public static void Main(string[] args)
    {
        Console.WriteLine("asdads");
        var test = new Test();
    }
}

internal class HaromszogData
{
    public int[] A { get; set; }
    public int[] B { get; set; }
    public int[] C { get; set; }

    public double ABH { get; set; }
    public double BCH { get; set; }
    public double ACH { get; set; }

    public void CalcHossz()
    {
        ABH = Math.Sqrt(Math.Pow(B[0] - A[0], 2.0) + Math.Pow(B[1] - A[1], 2.0));
        BCH = Math.Sqrt(Math.Pow(C[0] - B[0], 2.0) + Math.Pow(C[1] - B[1], 2.0));
        ACH = Math.Sqrt(Math.Pow(C[0] - A[0], 2.0) + Math.Pow(C[1] - A[1], 2.0));
    }

    public bool IsEgyenloSzaru()
    {
        if (ABH == BCH || ABH == ACH || BCH == ACH) return true;
        return false;
    }

    public bool IsSzabalyos()
    {
        if (ABH == BCH && BCH == ACH) return true;
        return false;
    }

    public double CalcKerulet()
    {
        return ABH + BCH + ACH;
    }

    public double CalcTerulet()
    {
        var s = (ABH + BCH + ACH) / 2;
        return Math.Sqrt(s * (s - ABH) * (s - BCH) * (s - ACH));
    }
}