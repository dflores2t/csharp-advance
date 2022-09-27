namespace ReimplementacionInterfacesHerencia
{
  //CLASE BASE
  public class CPrueba : ICalculable
  {

    private double n;

    public CPrueba(double pValor)
    {
      n = pValor;
    }
    // //IMPLEMENTACION DE LA INTERFAZ ICALCULABLE -> VERSION DEL CLASE PADRE.
    // public void Calcular(double pNumero)
    // {
    //   Console.ForegroundColor = ConsoleColor.White;
    //   Console.WriteLine("ESTOY EN CPRUEBA {0}", n * pNumero);
    // }

    //IMPLEMENTACION DE ICALCULABLE, HAY QUE NOTAR QUE LA ESTAMOS MARCANDO COM VIRTUAL, POR DEFAULT LAS IMPLEMENTACIONES SON SEALED.
    public virtual void Calcular(double pNumero)
    {
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("ESTOY EN CPRUEBA {0}", n * pNumero);
    }


  }
}