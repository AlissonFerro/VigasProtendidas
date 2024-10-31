public record Concrete(int fck)
{
    public readonly int Fck = fck;
    public readonly double Ecs = Math.Round(5600*Math.Sqrt(fck), 2);
    public readonly double Fctm = 0.3 * Math.Pow(fck, 2/3);
    public readonly double Fctkinf = 0.21 * Math.Pow(fck, 2/3);
    
}