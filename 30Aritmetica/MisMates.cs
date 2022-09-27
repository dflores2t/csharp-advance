namespace Aritmetica
{
  public class MisMates
  {
    private double a;
    private double b;
    private double r;
    
    public MisMates(double pA, double pB)
    {
      a = pA;
      b = pB;
    }

    public double R { get=> r; }

    public double Suma(){
      r = a + b;
      return r;
    }  
    public double Resta(){
      r = a - b;
      return r;
    }  
    public double Multi(){
      r = a * b;
      return r;
    }  
    public double Div(){
      r = a / b;
      return r;
    }  

  }

}