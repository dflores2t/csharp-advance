namespace VarNulleableDynamic
{
  public class Program
  {
    static void Main(string[] args)
    {
      var a = 5;
      var b = "HOLA A TODOS";
      var c = 15.6898;
      var d = false;
      // var e = null; //no puede sur null
      // d = 58; //no se puede cambiar el tipo
      var f = c;

      //MOSTRAMOS LOS DATOS EN PANTALLA
      Console.WriteLine(a);
      Console.WriteLine(b);
      Console.WriteLine(c);
      Console.WriteLine(d);

      //USAMOS LA REFLEXION PARA CONOCER EL TIPO
      Console.WriteLine("a es {0}", a.GetType().Name);
      Console.WriteLine("b es {0}", b.GetType().Name);
      Console.WriteLine("c es {0}", c.GetType().Name);
      Console.WriteLine("d es {0}", d.GetType().Name);
      Console.WriteLine("f es {0} -->{1}", f.GetType().Name, f);

      Console.WriteLine("-------------------------------------");

      //TIPOS NULLEABLE
      Console.WriteLine("-----------TIPOS NULLEABLES-----------");
      //LOS TIPOS VALOR NO PUEDEN TENER UN NULL
      // int valor = null; //error no se puede convertir null ent int

      //LOS TIPOS NULLEABLES REPRESENAR LOS MISMOS VALORES MAS EL VAROL DE NULL
      //UTILES PARA BASE DE DATOS, PUES PODEMOS ENCONTRAR COLUMNAS NO DEFINIDAS 
      //PARA DEFINIRLO USAMOS ?
      //PERO REALMENTE CREAMOS UNA INSTANCIA DE SYSTEM.NULLABLE<T>
      int? dato = 5;
      Console.WriteLine("dato {0}", dato);
      dato = null;
      Console.WriteLine("dato {0}", dato);

      double? precio = null;
      precio = 6.7;
      Console.WriteLine(precio);

      //EL STRING NO ES NULLEABLE YA QUE ES UN TIPO POR REFERENCIA
      // string? nombre = "kevin"; 
      // string nombre = null; ///

      //PODEMOS SABER SI TIENE O NO TIENE VALOR
      Console.WriteLine("------SABER SI TIENE VALOR -PROPIEDAD HASVALUE----------");
      // precio = null;
      if (precio.HasValue)
      {
        Console.WriteLine("TIENE VALOR {0}", precio.Value);
      }
      else
      {
        Console.WriteLine("NO TIENE VALOR");
      }

      Console.WriteLine("-----------------------");

      //OPERADOR ?? NOS PERMITE ASIGNAR UN VALOR EN CASO DE QUE TENGA NULL
      Console.WriteLine("---ASIGNAR VALOR EN CASO DE QUE SEA NULL ----??---");
      double? numero = asignador() ?? 5.55;
      Console.WriteLine(numero);
      Console.WriteLine("----------------");


      Console.WriteLine("--------------------DYNAMIC------------------");
      //object es el super tipo de csharp.
      dynamic z = 5;
      Console.WriteLine("Tipo {0}, valor: {1}", z.GetType().Name,z);
      z = "HOLA A TODOS";
      Console.WriteLine("Tipo {0}, valor: {1}", z.GetType(),z);


    }

    public static double? asignador(){
      return 4.5;
      // return null;

    }
}
}