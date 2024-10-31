public class Force
{
    public readonly double W;
    public readonly Beam Bean;
    public readonly double Mmax;

    public Force(double w, Beam bean)
    {
        Bean = bean;
        W = w + (bean.h * bean.b * 250);
        Mmax = W * bean.L * bean.L / 8;
    } 
}