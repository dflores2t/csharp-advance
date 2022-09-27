namespace ConversionExplicita;

public class CComplejo
{

  //a+bi
  private int a;
  private int b;

  public int A { get; set; }

  public int B { get; set; }

  public CComplejo(int pa, int pb)
  {
    a = pa;
    b = pb;
  }

  public override string ToString()
  {
    return string.Format("{0} + {1}i", a, b);
  }

  //CREAMOS UNA CONVERSION  EXPLICITA A REALES, REGLA
  public static explicit operator CReal(CComplejo pi){ //creal la clase a la que sera convertida. como parametro el numero complejo que se quiere convertir
    CReal temp = new CReal(); 
    temp.R = pi.a;
    return temp;
  }


}