public class SteelPassive(int fyk, double asTop, double asBottom) : Steel()
{
    public override int Fyk => fyk;

    public override double Astot => asBottom + asTop;

    public override SteelType Type => SteelType.Passive;

    public override int Es => 210;

    public double AsBottom => asBottom;
    public double AsTop => asTop;
}