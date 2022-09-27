namespace objetosdesechables
{
  //V1
  public class CPrueba : IDisposable //interface tiene un metodo que se tiene que invocar dispose()
  {
    private int a;

    public CPrueba(int pA)
    {
      a = pA;
    }
    public override string ToString()
    {

      return string.Format("EL VALOR ES {0}", a);
    }
    ~CPrueba()
    {
      Console.WriteLine("ESTAMOS EN EL DESTRUCTOR, AQUI LIBERAMOS LO NO ADMINISTRADO {0}", a);
    }

    //DESECHABLE.
    public void Dispose()
    {
      Console.WriteLine("ESTAMOS EN DISPOSE, AQUI LIBERAMOS LO NO ADMINISTRADO {0}", a);
      //todo el codigo el cual estaran liberando los recursos no administrados.
      //HAY CLASES QUE TIENEN IMPLEMENTADO DISPOSE POR SI MISMA COMO LAS DE SERIALIZACION. ARCHIVO.CLOSE() HACE EL DISPOSE.

      //SI SE USO DISPOSE NO DEBEMOS DE USAR EL DESTRUCTOR
      GC.SuppressFinalize(this);
    }

  }
  //V2
  public class CPrueba2 : IDisposable //interface tiene un metodo que se tiene que invocar dispose()
  {
    //PARA SABER SI SE USO DISPOSE
    private bool usoDispose = false;

    private int a;

    public CPrueba2(int pA)
    {
      a = pA;
    }
    public override string ToString()
    {

      return string.Format("EL VALOR ES {0}", a);
    }
    // ~CPrueba2(){
    //   Console.WriteLine("ESTAMOS EN EL DESTRUCTOR, AQUI LIBERAMOS LO NO ADMINISTRADO {0}",a);
    // }

    //DESECHABLE.
    public void Dispose()
    {
      //INVOCAMOS EL CODIGO DE LIMPIEZA
      Limpieza();

      //COMO USAMOS DISPOSE INDICAMOS QUE NO USE DESTRUCTOR
      GC.SuppressFinalize(this);
    }

    ~CPrueba2(){
      //INVOCAMOS EL METODO DE LIMPIEZA
      Limpieza();
    }

    public void Limpieza()
    {
      if(usoDispose ==false){
      //CODIGO DE LIMPIEZA COMUN
      Console.WriteLine("ESTAMOS EN LIMPIEZA, AQUI LIBERAMOS NO ADMINISTRADO{0}", a);

      }
      usoDispose = true;
    }
  }


}