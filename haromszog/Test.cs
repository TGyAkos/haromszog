namespace Haromszog;

public class Test
{
    private readonly HaromszogData _HaromszogData = new();

    public Test()
    {
        _HaromszogData.A = new[] { 0, 0 };
        _HaromszogData.B = new[] { 10, 0 };
        _HaromszogData.C = new[] { 5, 10 };

        _HaromszogData.CalcHossz();

        Console.WriteLine(_HaromszogData.IsSzabalyos());
        Console.WriteLine(_HaromszogData.IsEgyenloSzaru());

        Console.WriteLine(_HaromszogData.CalcKerulet());
        Console.WriteLine(_HaromszogData.CalcTerulet());
    }
}