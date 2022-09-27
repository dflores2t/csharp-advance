namespace ColleccionGenerica;
using System.Collections.Generic;

public class Program
{
  static void Main(string[] args)
  {
    //EMPZAMOS CON LA LISTA <T> representa el tipo. clase abstracta, T tipo generico.
    List<int> valores = new List<int>();
    int n = 0;
    int r = 0;
    valores.Add(7);
    valores.Add(5);
    valores.Add(4);
    valores.Add(3);
    valores.Add(8);
    valores.Add(9);

    //RECORREMOS CON CILCO FOR
    for (n = 0; n < valores.Count; n++){
      //NO HAY NECESIDAD DEL TYPECAST
      r = valores[n];
      Console.WriteLine("VALOR {0}: {1}", n,r);
    }
    Console.WriteLine("----------------------");

    //VEMOS SI CONTIENE DETERMINADO ELEMENTO
    Console.WriteLine("----------DETERMINAR SI EXISTE UN DETERMINADO ELEMENTO-------------");
    Console.WriteLine("METODO CONTAINS: {0}", valores.Contains<int>(5)); //necesita indicar cual es el tipo con el que necesita trabajar
    Console.WriteLine("METODO CONTIANS: {0}", valores.Contains<int>(17));//true or false.
    Console.WriteLine("------------------------------"); 

    //OBTENER EL INDICE DE UN ELEMENTO EN PARTICULAR
    Console.WriteLine("----------------OBTENER EL INDICE DE UN ELEMENTO PARTICULAR ----------------");
    Console.WriteLine("OBTENER EL INDICE, METODO INDEXOF: {0}", valores.IndexOf(4)); //cuando no esta en la lista regresa -1

    //INSERTAR ELEMENTOS EN UN INDICE EN PARTICULA
    Console.WriteLine("-------------INSERTAR ELEMENTO EN UN INDICE EN PARTICULAR --------------");
    valores.Insert(2, 55);
    foreach(int valor in valores){
      Console.WriteLine("VALORES: {0}",valor);
    }
    Console.WriteLine("------------------");

    //ELIMINAMOS ELEMENTO EN UN INDICE
    Console.WriteLine("---------ELIMINAMOS ELEMENTOS DE UN INDICE -REMOVEAT ----------------");
    valores.RemoveAt(3);
      foreach(int valor in valores){
        Console.WriteLine("VALORES :{0}",valor);
      }

    //ELIMANOR ELEMENTO A TRAVES DE SU VALOR
    Console.WriteLine("--------ELIMINAR ELEMENTO A TRAVES DE SU VALOR: METODO REMOVE");
    valores.Remove(8); //ELIMINARA LA PRIMERA OCURRENCIA SI ES QUE EXISTEN MAS.
    foreach(int valr in valores){
      Console.WriteLine("Valores: {0}",valr);
    }

    //COLOCAR LA LISTA EN SENTIDO CONTRARIO
    Console.WriteLine("------COLOCAR LA LISTA EN SENTIDO CONTRARIO METODO REVERSE----------");
    valores.Reverse();
    foreach (int valr in valores)
    {
      Console.WriteLine("Valores: {0}", valr);
    }

    //MANDAMOS A ORDENAR LA LISTA
    Console.WriteLine("---------MANDAMOS A ORDENAR LA LISTA METODO SORT-----------");
    valores.Sort(); //implementar icomparable en una clase
    foreach (int valr in valores)
    {
      Console.WriteLine("Valores: {0}", valr);
    }

    //CREAMOS UNA LISTA DE CLASE
    Console.WriteLine("-------------CREAMOS UNA LISTA DE CLASE--------");
    List<CPunto> listaPuntos = new List<CPunto>();

    listaPuntos.Add(new CPunto(5, 3));
    listaPuntos.Add(new CPunto(7, 8));
    listaPuntos.Add(new CPunto(12, 5));
    listaPuntos.Add(new CPunto(6, 2));

    //MOSTRAMOS DATOS EN PANTALLA
    Console.WriteLine("--------MOSTRAMOS LOS DATOS EN PANTALLA DE LA LISTA DE LA CLASE ---------");
    foreach (CPunto lista in listaPuntos)
    {
      Console.WriteLine("Valores: {0}", lista);
    }

    //SORT EN LA CLASE
    Console.WriteLine("----------METODO SORT SOBRE LA CLASE NO FUNCIANARA-----------------");
    // listaPuntos.Sort(); //System.InvalidOperationException: Failed to compare two elements in the array, sort se debe implementar icormparable.
    //adicion explicita
    List<CPunto> puntos = new List<CPunto>{
      new CPunto(2,3),
      new CPunto(5,23),
      new CPunto(7,9),
    };
    //MOSTRAMOS EN PANTALLA
    foreach(CPunto punto in puntos){
      Console.WriteLine("VALORES: {0}", punto);
    }
    
    //ADICIONAMOS UN PUNTO
    Console.WriteLine("--------ADICONAMOS UN PUNTO----------");
    puntos.Add(new CPunto(45, 00));
    //MOSTRAMOS EN PANTALLA
    foreach (CPunto punto in puntos)
    {
      Console.WriteLine("VALORES: {0}", punto);
    }
    //INSERTAMOS UN PUNTO POR INDICE
    Console.WriteLine("--------INSERTAMO UN VALOR EN UN INDICE ESPECIFIO-------");
    puntos.Insert(2, new CPunto(100, 150));
    //MOSTRAMOS EN PANTALLA
    foreach (CPunto punto in puntos)
    {
      Console.WriteLine("VALORES: {0}", punto);
    }
    //CONVERTIR LA LISTA A UN ARREGOL
    Console.WriteLine("----------CONVERTIR LA LISTA EN UN ARREGLO----------------");
    CPunto[] arregloPuntos = puntos.ToArray();
    //MOSTRAMOS EN PANTALLA
    foreach (CPunto punto in arregloPuntos)
    {
      Console.WriteLine("ARREGLO: {0}", punto);
    }

  }
}