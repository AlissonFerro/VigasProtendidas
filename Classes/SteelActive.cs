public class SteelActive(int fyk, int as1) : Steel () 
{
    public override SteelType Type => SteelType.Active;

    public override int Fyk => fyk;

    public override double Astot => as1; 

    public override int Es => 200; // GPa
}