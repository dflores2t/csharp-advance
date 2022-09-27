using System.Collections;

namespace arraylist;

public class Program{

  static void Main(string[] args)
  {
    ArrayList palabras = new ArrayList();
    int n = 0;
    int r = 0;

    //PODOMES ADICONAR CON RANGO
    palabras.AddRange(new string[]{
    "HOLA","COMO","ESTAN?",
  }); //SE PASA UNA COLECCION COMO PARAMETRO

    Console.WriteLine("CANTIDAD DE ELEMENTOS EN EL ARRAYLINT ES {0}", palabras.Count);

    //RECORREMOS CON CICLO FOR
    for (n = 0; n < palabras.Count; n++)
    {
      Console.WriteLine(" {0}", palabras[n]);
    }

    Console.WriteLine();
    Console.WriteLine("----------------------");

    //PARTE 2
    // USO DE ADD, RECORRIDO CON FOREACH, LA NECESIDAD DEL TYPE CAST, INSERCION DE ELEMENTOS, ELIMINACION DE ELEMENTOS.
    //ELIMINAR DETERMINADO INDICE

    //METODO ADD, OTRA FORMA DE AGREGARE LEMENTOS.
    palabras.Add("BIEN Y TU"); //EN UN ARREGOL NORMAL NO PODEMOS HACER CRECER DINAMICAMENTE EL TAMANO COMO CON LOS ARRAG LIST
    
    //RECORREMOS CON FOREACH
    foreach(string palabra in palabras){
      Console.WriteLine(" {0}", palabra);
    }
    Console.WriteLine();
    Console.WriteLine("-----------------");

    //TRABAJANDO CON OTROS TIPO
    ArrayList valores = new ArrayList();
    valores.Add(5);
    valores.Add(7);
    valores.Add(34);

    //RECORREMOS CON CICLO FOR
    for (n = 0; n < valores.Count; n++){
      r = (int)valores[n]; //CUANDO ESTAMOS TRABAJANDO CON EL COLLECTION, ESTOS GUARDAN TOSO LOS ELEMESTOS COMO SI FUERAN DEL TIPO OBJECT, POR TANTO SI DESEAMOS SACAR UN ELEMENTO LO OBTENDREMOS COMO OBJECT Y NO COMO UN STRNIG DOUBLE DECIMAL ETC. POR LO TANTO ES NECESARIO PONER UN TYPECAST
      Console.WriteLine(r);
    }
    Console.WriteLine("----------------------------");

    //VEMOS SI EXISTE UN ELEMENTO EN EL ARRAYLIST
    Console.WriteLine(valores.Contains(5)); //ESTE METODO DEVUELVE TRUE SI EXISTE Y UN FALSE SI NO ESTA EN LA COLECCION.
    Console.WriteLine(valores.Contains(17));
    Console.WriteLine("--------------------------");

    //INSERTAMOS EN UN INDICE EN PARTICULAR, ESTO SERIA DIFICIL CON UN ARRAY TRADICIONAL
    //METODO INSERT -> RECIBE COMO PARAMETRO EL INDICE Y EL VALOR A INSERTAR
    valores.Insert(2, 55); //METODO INSERT, INSERTA EL VALO 55 EN EL INDICE 2
    for (n = 0; n < valores.Count; n++){
      Console.WriteLine((int)valores[n]);
    }
    Console.WriteLine("---------REMOVER ELEMENTO--------------");
    //REMOVER ELEMENTOS - METODO REMOVE -> RECIBO COMO PARAMETRO EL OBJETO QUE SE VA A ELIMINAR
    valores.Remove(55);
    for (n = 0; n < valores.Count; n++)
    {
      Console.WriteLine((int)valores[n]);
    }
    Console.WriteLine("--------REMOVER ELEMENTO EN DETERMINADO INDICE O POSICION---------");
    //REMOVER EN UNA POSICION -> METODO REMOVEAT-> RECIBE COMO PARAMETRO LA POSICION A REMOVER
    valores.RemoveAt(0);
    for (n = 0; n < valores.Count; n++)
    {
      Console.WriteLine((int)valores[n]);
    }
  Console.WriteLine("-----------------------------");

  //PARTE 3

  }
}