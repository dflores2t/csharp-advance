namespace UpdateCsharp8;

public class ClaseG1<T> : ClaseG<T>{
  private T numero;

  public T Numero { set=> numero = value; }

  public void MostrarNumero(){
    Console.WriteLine("EN CLASE G1 NUMERO {0}, {1}",numero, typeof(T));
    Console.WriteLine("POR HERENCIA RECIBI T= {0} ",typeof(T));
  }
}