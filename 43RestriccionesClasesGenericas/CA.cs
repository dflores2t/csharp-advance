namespace RestriccionesClasesGenericas
{
  //COLOCAL LOS ATRIBUTOS Y METODOS DE LA CLASE
  public class CA
  {
    
    // public CA(int a, int b)
    // {

    // }

    public override string ToString()
    {
      return string.Format("DESDE LA CLASE A CA");
    }
  }

  public class CB : CA
  {
    //COLOCAMOS LOS ATRIBUTOS Y METODOS DE LA CLASE
    public override string ToString()
    {
      string r = base.ToString();
      return string.Format("DESDE LA CLASE B CB=>" + r);
    }
  }

  public interface IInterfaz
  {
    void metodo();
  }

  public class CC : IInterfaz
  {
    public void metodo()
    {
      Console.WriteLine("IMPLEMENTACION DE LA INTERFAZ");
    }

    public override string ToString()
    {
      return string.Format("DESDE LA CLASE C CC");
    }
  }
}