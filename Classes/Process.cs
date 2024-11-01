public class Process
{
    public readonly Concrete Concrete;
    public readonly SteelActive SteelActive;
    public readonly SteelPassive SteelPassive;
    public readonly Beam Beam;
    public readonly Force Force;
    public double Yc {get; set;}        // Posição da linha neutra 
    public double Mcr {get; set;}       // Momento de fissuração

    public Process(Concrete concrete, SteelActive steelActive, SteelPassive steelPassive, Beam beam, Force force)
    {
        Concrete = concrete;
        SteelActive = steelActive;
        SteelPassive = steelPassive;
        Beam = beam;
        Force = force;
        Yc =  Beam.h/2;
        Mcr = ((Beam.alfa * Concrete.Fctkinf * Beam.Ieq / Yc) + (SteelActive.Pi * Beam.Ieq /( Beam.Ac * Yc)) + SteelActive.Pi * Yc)/1000; 
        MessageBox.Show(Mcr.ToString());
    }

    public void ExecuteMcr()
    {
    }
}
