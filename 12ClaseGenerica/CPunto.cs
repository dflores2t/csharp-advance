namespace ClaseGenerica;

//T REPRESENTA AL TIPO CON EL QUE SE TRABAJA EN UN MOMENTO DADO
public class CPunto<T> //
{
  //CREAMOS VARIABLES TIPO T
  private T x;
  private T y;

  //PODEMOS RECIBIR PARAMETROS DEL TIPO T

  public CPunto(T px, T py)
  {
    x = px;
    y = py;
  }

  public override string ToString()
  {
    return string.Format("X={0}, Y={1}", x, y);
  }

  public void Reset()
  {
    //COLOCAMOS EL VALOR DE DEFAULT PARA EL TIPO T
    // NUMERICOS 0
    // REFERENCIAS NULL
    x = default(T);
    y = default(T);
  }

  public void EncuentraTipo()
  {
    if (typeof(T) == typeof(int))
    {
      Console.WriteLine("TRABAJA CON ENTEROS");
    }
    else
    {
      Console.WriteLine("SOY DE OTRO TIPO");
    }
  }


}