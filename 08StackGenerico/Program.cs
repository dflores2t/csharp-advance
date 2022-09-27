using System.Collections.Generic;
namespace stackqueuegeneric;

public class Program{
  static void Main(string[] args){

    Stack<CPunto> puntos = new Stack<CPunto>();

    puntos.Push(new CPunto(3, 4));
    puntos.Push(new CPunto(5, 7));
    puntos.Push(new CPunto(9, 11));
    puntos.Push(new CPunto(1, 4));

    //MOSTRAMOS EN PANTALLA
    foreach(CPunto p in puntos){
      Console.WriteLine("-->{0}", p);
    }
    Console.WriteLine("---------------------------------------");

    //HACEMOS UN PEEK
    Console.WriteLine("-----------HACEMOS PEEK-----------------");
    Console.WriteLine("METODO PEEK: {0}", puntos.Peek());
    //MOSTRAMOS EN PANTALLA
    foreach (CPunto p in puntos)
    {
      Console.WriteLine("-->{0}", p);
    }
    Console.WriteLine("---------------------------------------");

    //POP PARA SACAR EL ELEMENTO PRIMERO EN SALIR
    Console.WriteLine("------------METEODO POP--------------");
    Console.WriteLine("POP {0}", puntos.Pop());
    Console.WriteLine("POP {0}", puntos.Pop());

    //MOSTRAMOS EN PANTALLA
    foreach (CPunto p in puntos)
    {
      Console.WriteLine("-->{0}", p);
    }
    Console.WriteLine("---------------------------------------");
    Console.WriteLine(puntos.Peek());

    // COLECCION QUEUE
Console.WriteLine("-------------COLECCION GENERICA CON QUEUE --------- ");
    Queue<CPunto> puntoqueue = new Queue<CPunto>();
    puntoqueue.Enqueue(new CPunto(3, 7));
    puntoqueue.Enqueue(new CPunto(7, 9));
    puntoqueue.Enqueue(new CPunto(11, 2));

    //MOSTRAMOS EN PANTALLA
    foreach (CPunto p in puntoqueue)
    {
      Console.WriteLine("-->{0}", p);
    }
    Console.WriteLine("---------------------------------------");

    //HACEMS UN PEE
    Console.WriteLine("---------HACEMOS PEEK------------");
    Console.WriteLine("PEEK {0}", puntoqueue.Peek());

    //HOCEMOS DEQUEUE
    Console.WriteLine("-------------HACEMOS DEQUEUE----------");
    Console.WriteLine("DEQUEDUE {0}", puntoqueue.Dequeue());
    Console.WriteLine("DEQUEDUE {0}", puntoqueue.Dequeue());
    //MOSTRAMOS EN PANTALLA
    Console.WriteLine("-------LISTA EN PANTALLA----------");
    foreach (CPunto p in puntoqueue)
    {
      Console.WriteLine("-->{0}", p);
    }
    Console.WriteLine("---------------------------------------");

  }
}