namespace hastables;
using System.Collections;

public class program {
  static void Main(string[] args){
    Hashtable miTabla = new Hashtable();

    //ADICIONAMOS ELEMENTOS.
    miTabla.Add(123, "HOLA");
    miTabla.Add(234, "SALUDOS");
    miTabla.Add(45, "ADIOS");
    miTabla.Add(567, "C#");
    miTabla.Add(12763, "PROGRAMACION");

    //MOSTRAMOS LOS ELEMENTOS.
    foreach(DictionaryEntry elemento in miTabla){
      Console.WriteLine("{0}, {1}", elemento.Key, elemento.Value);
    }
    Console.WriteLine("-------------------------------------------");

    //INTENTAMOS COLOCAR UN ELEMENTO CON LLAVE REPETIDO
    //NO PUEDE EXISTIR ELEMENTOS CON LA MISMA LLAVE
    // miTabla.Add(123, "OTRO MAS"); //ESTO MANDA UNA EXCEPICION , PORQUE LA CLAVE YA ESTA REPETIDA

    //CANTIDAD DE ELEMENTOS
    Console.WriteLine("----------------CANTIDAD DE ELEMENTOS----------");
    Console.WriteLine(miTabla.Count);

    //ACCEDER A UN ELEMENTO EN PARTICULAR
    //ES NECESARIO CONOCER LA LLAVE
    Console.WriteLine("-----------------ACCEDER A UN ELEMENTO EN PARTICULAR-----------");
    Console.WriteLine(miTabla[567]);
    Console.WriteLine(miTabla[445]);

    Console.WriteLine("-----------------------------");

    //COLOCAMOS ELEMENTOS EN UNA LLAVE
    //NECESITAMOS HACER USO DEL KEY, SI LA LLAVE NO EXISTE, ENTONCES LO TOMARA COMO UNA NUEVA ADICION
    Console.WriteLine("-------------COLOCAMOS ELEMENTOS EN UNA LLAVE--------------");
    miTabla[45] = "AVANZADO";
    miTabla[300] = "COLECCIONES"; // ESTO TAMBIEN ADICIONA
    foreach(DictionaryEntry elemento in miTabla){
      Console.WriteLine("<{0}, {1}>", elemento.Key,  elemento.Value);
    }
  Console.WriteLine("-----------------------------------------------");

  //VERIFICAMOS SI HAY UN ELEMENTO
  Console.WriteLine("-----------VERIFICAMOS SI HAY UN ELEMENTO----------");
  //TRUE OR FALSE
  Console.WriteLine(miTabla.Contains(567));
  Console.WriteLine(miTabla.Contains(335));

//ELIMINACION DE UN ELEMENTO
Console.WriteLine("---------ELIMINACION DE UN ELEMENTO---------");
    //IGUAL NECESITAMOS CONOCER SU LLAVE SI LA LLAVE NO EXISTE NO TRUENA EL PROGRAMA
    miTabla.Remove(234);
    foreach(DictionaryEntry elemento in miTabla){
      Console.WriteLine("({0},{1})", elemento.Key, elemento.Value);
    }
    Console.WriteLine("---------------------------------------");
  //PODEMOS ACCEDER A CADA UNA DE LAS LLAVES SI FUERA NECESARIO
  Console.WriteLine("--------PODEMOS ACCEDER A CADA UNA DE LAS LLAVES----------");
  foreach(int llave in miTabla.Keys){ //keys a su ves es otra coleccion donde se guarda los valores
    Console.WriteLine(llave);
  }
  Console.WriteLine("--------------------");
  //PODEMOS ACCEDER A CADA UNA DE LOS VALORES SI FUERA NECESARIO
  Console.WriteLine("--------PODEMOS ACCEDER A CADA UNA DE LOS VALORES----------");
  foreach(string valor in miTabla.Values){ //values a su ves es otra coleccion donde se guarda los valores
    Console.WriteLine(valor);
  }
  Console.WriteLine("--------------------");


  }
}