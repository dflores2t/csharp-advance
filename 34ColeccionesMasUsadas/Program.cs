using System.Collections;

namespace Colecciones
{
  class Program
  {
    static void Main(string[] args)
    {


      //LISTAS
      List<int> numbers = new List<int>();
      numbers.Add(0);
      numbers.Add(1);
      numbers.Add(2);

      //mostrar 
      foreach (var number in numbers)
        Console.WriteLine(number);

Console.WriteLine("---------hatable----------------");

      //HASTABLE => recibe tipos objetos-> como los dictionary, key, value
      Hashtable otroNumbers = new Hashtable();
      otroNumbers.Add(1, "1");
      otroNumbers.Add(2, "2");
      otroNumbers.Add(3, "3");
      otroNumbers.Add(4, "4");
      // otroNumbers.Add(4, "4");//no permite repetido

      //mostrar 
      foreach (var number in otroNumbers.Values)
        Console.WriteLine(number);
      Console.WriteLine("-----------DICTINARY----------");
      //DICTINARY
      Dictionary<int, string> dicNumber = new Dictionary<int, string>();
      dicNumber.Add(1,"uno");
      dicNumber.Add(2,"dos");
      dicNumber.Add(3,"tres");
      dicNumber.Add(4,"cuatro");

      //mostrar
      foreach(var number in dicNumber)
      Console.WriteLine("{0} - {1}", number.Key, number.Value);

      //Queue/CAL FIFO- GENERICO.
      Console.WriteLine("---------COLA------");
      Queue<int> colanumbrers = new Queue<int>();
      colanumbrers.Enqueue(1);
      colanumbrers.Enqueue(112);
      colanumbrers.Enqueue(123);
      colanumbrers.Dequeue();

      //mostrar
      foreach (var number in colanumbrers)
        Console.WriteLine("{0}", number);

    //STACK PILAS -LIFO
    Console.WriteLine("-------------STACK PILA GENERICA------");
    Stack<int> stackNumber = new Stack<int>();
      stackNumber.Push(7);
      stackNumber.Push(21);
      stackNumber.Push(12);
      stackNumber.Push(722);
      //ELIMINAR
      stackNumber.Pop();


      //mostrar
      foreach (var number in stackNumber)
        Console.WriteLine("{0}", number);

    }



  }
}