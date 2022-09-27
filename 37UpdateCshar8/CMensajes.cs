namespace UpdateCsharp8;

public class CMensajes<T>{
  //LAS VARIABLES ESTATICAS EN CLASES GENERICAS, SON UNICAS PARA CADA TIPO ASIGNADO A LAS CLASES
  private static int contador = 0; // seran variables unicas para cada tipo asignado a las clase. T intereo, todas las instancias de tipo int tendran su propio contador, igual string double float, no se comparte entre toas las instancias.

  private T dato;
  public CMensajes(T pDato)
  {
    dato = pDato;
  }

  public void Imprime(){
    Console.WriteLine(dato);
    contador++;
    Console.WriteLine("EL CONTADOR TIENE {0}", contador);
  }
}