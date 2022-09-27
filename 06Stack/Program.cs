using System.Collections;

namespace stack;

public class Program {
  static void Main(string[] args){
    Stack miStack = new Stack(); //fifo

    //AGREGAMOS ELEMENTOS
    miStack.Push("MANZANA");
    miStack.Push("PERA");
    miStack.Push("CIRUELA");
    miStack.Push("MANGO");

    //ITERAMOS EL STACK
    foreach(String fruta in miStack){
      Console.WriteLine("---> {0}", fruta);
    }
    Console.WriteLine("-------------------------");

    //OBTENER ELEMENTO USANDO EL METODO POP
    Console.WriteLine("-----OBTENER ELEMENTO USANDO EL ELEMENTO POP SACANDO DEL STACK--------");
    Console.WriteLine("METODO POP: {0}",miStack.Pop()); //REGRESA ALGUIEN DE TIPO OBJECT, SOBRECARGO STRNIG.

    foreach(string fruta in miStack){
      Console.WriteLine("---> {0}",fruta);
    }
    Console.WriteLine("---------------------------");
    //HACEMOS PEEK
    Console.WriteLine("-----PEEK CONOCER EL PRIMER ELEMENTO DEL STACK SIN SACARLO-----------");
    Console.WriteLine("METODO PEEK: {0}", miStack.Peek());

    Console.WriteLine("-----------------------------");
    //CANTIDAD DE ELEMENTOS
    Console.WriteLine("------------CANTIDAD DE ELEMENOS - COUNT");
    Console.WriteLine("METODO COUNT: {0}", miStack.Count);


  }
}