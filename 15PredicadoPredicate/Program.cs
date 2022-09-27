namespace predicadopredicate;

using System.Collections.Generic;

public class Program{
  static void Main(string[] args){
    // public List<T> FindAll(Predicate<T> match) Recorre los elementos de la lista y los pasa como parametros al delegado, si esto regreso true los pone en la lista de retorn.
    List<int> numeros = new List<int>();
    numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,5,4,8,11,12,27,20 }); //el metodo addrange me permite poner de un solo golpe la lista  que quier en esa variale.

    //INDICAMOS EL DELEGADO
    Predicate<int> delegado = new Predicate<int>(Rango);

    //INVOCAMOS METODO
    List<int> numPares = numeros.FindAll(delegado);

    //MOSTRAMOS
    foreach(int n in numPares){
      Console.WriteLine(n);
    }

    //REMOVEMOS
    numeros.RemoveAll(delegado);
    Console.WriteLine("---------REMOVIENDO---------------");
    //MOSTRAMOS
    foreach (int n in numeros)
    {
      Console.WriteLine(n);
    }
  }

  //ESTE ES EL DELEGADO
  static bool Pares(int n){
    if(n % 2 ==0){
      return true;
    }else{
      return false;
    }
  }

  static bool Rango(int n){
    if(n >= 3 && n <= 7){
      return true;
    }else{
      return false;
    }
  }
}