namespace UpdateCsharp8;

public class Clase2G<T,T2> : ClaseG<T>{
  private T2 dato;

  public T2 Dato { set=> dato= value; }

  public void MostrarDos(){
    Console.WriteLine("EN CLASEG VALOR ES {0}, {1}",valor, typeof(T));
    Console.WriteLine("EN CLASEDOSG DATOS ES {0}", dato,typeof(T2));
    

  }
}