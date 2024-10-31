public class Process
{
    public readonly Concrete Concrete;
    public readonly SteelActive SteelActive;
    public readonly SteelPassive SteelPassive;
    public readonly Beam Beam;
    public readonly Force Force;
    public readonly double Pi;          // Força de Protensão inicial
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
    }

    public void ExecuteMcr()
    {
        for (int Pi = 1000; Pi < 3000; Pi += 100 )
        {
            Mcr = (Beam.alfa * Concrete.Fctkinf * Beam.Ieq / Yc) + (Pi * Beam.Ieq /( Beam.Ac * Yc)) + Pi * Yc;
            MessageBox.Show(Mcr.ToString());
        }
    }
}
