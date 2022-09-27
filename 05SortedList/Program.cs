namespace sortedlist;

using System.Collections;

public class Program{
  static void Main(string[] args){
    //lista de elementos que se iran autoordenando.
    //trabaja con dicitonary entry
    SortedList miSlista = new SortedList();

    //ADICIONAMOS
    miSlista.Add(754, "HONDA");
    miSlista.Add(123, "VOLVO");
    miSlista.Add(587, "NISSAN");
    miSlista.Add(323, "FIAT");
    //ITERAMOS
    foreach(DictionaryEntry elemento in miSlista){
      Console.WriteLine("({0}, {1})",elemento.Key, elemento.Value);
    }
    Console.WriteLine("---------------------------------");

    //CANTIDAD DE ELEMENTOS
    Console.WriteLine("---------CANTIDAD DE ELEMENTOS EN LA COLECCION---------");
    Console.WriteLine(miSlista.Count);

    //CONTIENE EL ELEMENTO/
    Console.WriteLine("------------CONTIENE EL ELEMENTO X ------------");
    Console.WriteLine("METODO CONTAINS: {0}",miSlista.Contains(123)); //elemenot de la key a buscar
    Console.WriteLine("METODO CONTAINS: {0}",miSlista.Contains(678)); // true or false

    Console.WriteLine("METODO CONTAINSKEY: {0}",miSlista.ContainsKey(587)); //busca la llavae en especifico 
    Console.WriteLine("METODO CONAINSVALUE: {0}",miSlista.ContainsValue("VOLVO")); //busca los valores
    Console.WriteLine("-----------------------------"); 

    //OBTENER ELEMENTOS POR MEDIO DEL INDICE
    Console.WriteLine("-----OBTENER ELEMENTOS POR MEDIO DEL INDICE-----------");
    Console.WriteLine("METODO GETKEY: {0}",miSlista.GetKey(2)); // la llave que se encuentra en el indice 2
    Console.WriteLine("METODO GETBYINDEX: {0}",miSlista.GetByIndex(2));// EL VALOR QUE SE ENCUENTRA EN EL INDICE2

  }
}