namespace UpdateCsharp8;
//CREAMOS UNA SUBCLASE QUE CIERRA LA CLASE BASE A INT
//EN LUGAR DE HEREDAR EL TIPO T
public class ClaseGCerrado : ClaseG<int> //AL MOMONETO DE HACER LA HERENCIA CERRAMOS CON EL TIPO QUE TRABAJARIAMOS. EN ESTE CASO INT
{
  public void MostrarCerrada()
  {
    valor = 17;
    //NO PODEMOS USAR T PORQUE YA SE CERRO
    //Console.WriteLine("EN CLA CLASEG CERRADA {0}',{1}", valor, typeof(T));
    Console.WriteLine("EN LA CLASEGCERRADA  {0}", valor);

  }

}