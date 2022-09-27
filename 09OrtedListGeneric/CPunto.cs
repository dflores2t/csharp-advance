namespace sortedlistgeneric;

public class CPunto : IComparable<CPunto>
{
  private int x;
  private int y;

  public CPunto(int px, int py)
  {
    x = px;
    y = py;
  }
  //IMPLEMENTACION DE LA REGLA DE COMPARACION, YO OBJETO ME COMPARA CONTRA AQUEL OBJETO COMO PARAMETRO
  //LA REGLA DE COMPARACION SE CREA, DEPENDIENDO DE LA CLASE QUE SE CREE SE DEBE PROGRAMAR LA REGLA DE COMPARACION.
  //REGLA DE MAGNITUD.
  public int CompareTo(CPunto? b)
  {
    double maga = Math.Sqrt(x * x + y * y);
    double magb = Math.Sqrt(b.x * b.x + b.y * b.y);
    if(maga > magb)
    {
      return 1;
    }
    if(maga < magb){
      return -1;
    }
    else{
      return 0;
    }
  }

  public override string ToString()
  {
    return string.Format("X= {0}, Y= {1}", x, y);
  }
}