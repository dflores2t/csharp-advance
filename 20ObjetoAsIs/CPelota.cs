namespace objetoasis;

public class CPelota{
  string tamano;
  public CPelota(string pTamano)
  {
    tamano = pTamano;
  }

  public override string ToString()
  {
    return string.Format("EL TAMANO DE LA PELOTA ES {0}", tamano);
  }
}