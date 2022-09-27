using System.Collections;

namespace bitarray;

public class Program{
  static void Main(string[]args){
    BitArray miArreglo = new BitArray(new byte[] { 1, 2, 4, 8, 16 }); //estos valones estan siendo a bit y se estan arreglando al bitarry

    //CANTIDAD DE ELEMENTOS, 5 BYTES * 8 = 40BITS
    Console.WriteLine(miArreglo.Count);
    MuestraArreglo(miArreglo);

    Console.WriteLine("--------------------");

    //OBTENER UN BIT EN PARTICULAR
    Console.WriteLine("-------------OBTENER UN BIT EN PARTICULAR------------------");
    Console.WriteLine(miArreglo.Get(0));
    // COLOCAR UN BIT EN PARTICULAR
    Console.WriteLine("------------COLOCAR UN BIT EN PARTICUAL----------");
    miArreglo.Set(3, true);
    MuestraArreglo(miArreglo);
    Console.WriteLine(miArreglo.Get(3));
    Console.WriteLine("-------------------------------");

    //SEGUNDA PARTE
    Console.WriteLine("---------------CLONAR BITARRAY--------------");
    BitArray arreglo2 = (BitArray)miArreglo.Clone(); //typecast porque los elementos estan en type object
    MuestraArreglo(arreglo2);

    //INVERTIR EL ARREGLO NOT
    Console.WriteLine("----INVERTIR EL ARRGELO NOT, CADA 1 LO CONVIENTE EN 0 Y CADA 0 EN 1----------");
    arreglo2.Not(); // ESTOS CAMBIOS QUEDAN GUARDADOS DENTRO DEL ARRGELO2, AL HOCER USO DE LOS METODOS QUE LOS ARREGLOS QUEDAN MODIFICADOS
    MuestraArreglo(arreglo2);
  Console.WriteLine("-------------------------");
    //CREAMOS OTRO

    BitArray arreglo3 = new BitArray(new byte[] { 5, 7, 9, 13, 15 });
    MuestraArreglo(arreglo3, "arreglo3");

  //HACEMOS OR ENTRE ARREGLOS, EL RESULTADO DE LA OPERACION OR SE GUARDA EN EL OBJETO QUE INVOCA OR
  Console.WriteLine("-------------HACEMOS OR ENTRE ARREGLOS-----------");
    arreglo3.Or(miArreglo);
    MuestraArreglo(miArreglo, "miArreglo :");
    MuestraArreglo(arreglo3, "arreglo3 :");
    Console.WriteLine("===========================================");

    //HACEMOS EL AND, ARREGLO 3 SE MODIFICARA CON EL RESULTADO.
    arreglo3.And(miArreglo);
    MuestraArreglo(arreglo3, "arreglo3 And:");
    Console.WriteLine("--------------------------------------------");

  //HACEMOS XOR ENTRE ARREGLO, ARREGLO 3 SE MODIFICA CON EL RESULTADO
    Console.WriteLine("------------HACEMOS XOR ENTRE ARREGLOS---------------");
    arreglo3.Xor(miArreglo);
    MuestraArreglo(arreglo3, "Arreglo3 Xor:");

  }

  public static void MuestraArreglo(BitArray pMiArreglo, string pNombre=""){
    int c = 0;
    Console.Write("{0}\t", pNombre);
    foreach(bool b in pMiArreglo){
      c++;
      if(b)
        Console.Write("1");
      else
        Console.Write("0");
      if(c % 8 ==0)
      Console.Write(","); //NECESARIO PARA NOSOTROS COMO HUMAN


    }
    Console.WriteLine();
    
  }
}