namespace queue;
using System.Collections;


public class Program {
  static void Main(string[] args){
    Queue miQ = new Queue(); //FIFO/ COLAS/ COLECCION SECUENCIAL

    //ADICIONAMOS ELEMENTOS
    Console.WriteLine("---------------QUEUE ADICIONAR ELEMENTOS : ENQUUE------------");
    miQ.Enqueue("MANZANA");
    miQ.Enqueue("FRESA");
    miQ.Enqueue("PERA");
    miQ.Enqueue("UVA");

    //ITERAMOS
    foreach(string fruta in miQ){
      Console.WriteLine("-->{0}", fruta);
    }

    Console.WriteLine("----------------------------------------");
    //OBTENER UN OBJETO
    Console.WriteLine("------------OBTENEMOS OBJETO DEQUEUE------------------");
    Console.WriteLine("DEQUEUE {0}", miQ.Dequeue());
    Console.WriteLine("DEQUEUE {0}", miQ.Dequeue());
    foreach(string fruta in miQ){
      Console.WriteLine("DESPUES DE DEQUUE->{0}",fruta);
    }
    Console.WriteLine("---------------------------");

    //ADICIONAMOS NUEVOS OBJETOS
    Console.WriteLine("-----------ADICIONAMOS NUEVOS ELEMENTOS-------------");
    miQ.Enqueue("LIMON");
    miQ.Enqueue("MANGO");
    miQ.Enqueue("CIRUELA");

    //OBSERVAMOS EL OBJETO
    Console.WriteLine("-------------OBSERVAR EL OBJETO O PRIMER ELEMENTO----------------");
    Console.WriteLine("PEEK {0}", miQ.Peek());
    foreach(String fruta in miQ){
      Console.WriteLine("DESPUES DEL PEEK {0}", fruta);
    }
    Console.WriteLine("--------------------------");

    //CONTEO DE OBJETOS
    Console.WriteLine("-----------CONTEO DE ELEMENTOS----------------");
    Console.WriteLine(miQ.Count);

    //VERIFICAMOS SI EXISTE UN ELEMENTO
    Console.WriteLine("-----------VERIFICAR SI EXISTE UN ELEMENTO-----------");
    Console.WriteLine(miQ.Contains("MANGO"));
    Console.WriteLine(miQ.Contains("MANZANA"));
    //TRUE SI EXISTE, FLASE SI NO EXISTE
  }
}