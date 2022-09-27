namespace ConversionExplicita;

public class CReal
{
  private double r;
  public double R { get=> r; set=>r=value; }
  public CReal()
  {

  }
  public CReal(double pr)
  {
    r = pr;
  }

  public override string ToString()
  {
    return string.Format("r={0}", r);
  }
}