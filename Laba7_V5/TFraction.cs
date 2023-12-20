namespace Laba7_V5;

public class TFraction
{
    public double Numerator { get; private set; }
    public double Denominator { get; private set; }
    public double Num { get; private set; }

    public TFraction(double numerator, double denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
        Num = double.Parse(numerator + "," + denominator);
    }

    public void Expanse(double value) =>
        Num += value;

    public void Reduction(double value) =>
        Num -= value;

    public override string ToString() =>
        $"Fraction is {Math.Round(Num, 2).ToString().Replace(',', '/')}";
}