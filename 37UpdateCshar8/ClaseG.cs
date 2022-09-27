namespace UpdateCsharp8;

public class ClaseG<T>{
  protected T valor;

  public T Valor {set=>valor = value; }

  public void mostrar(){
    Console.WriteLine("EN CLASEG VALOR ES {0}, {1}", valor, typeof(T));
  }
}