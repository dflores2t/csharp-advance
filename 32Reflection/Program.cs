using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Reflection
{
  class Program
  {
    static void Main(string[] args)
    {
      //OBTENEMOS INFORMACION SOBRE UN TIPO.
      try
      {
        //OTENEMOS EL TIPO
        // Type t = Type.GetType("System.Collections.ArrayList");
        Type t = Type.GetType("System.Collections.ArrayList");
        //METODO QUE BUSCAN LA INFORMACION SOBRE EL TIPO
        CaracteristicasTipo(t);
        EncuentraCampos(t);
        EncuentaPropiedades(t);
        EncuentraMetodos(t);
        EncuentraInterfaces(t);
      }
      catch (System.Exception)
      {
        Console.WriteLine("VERIFICAR TIPO");
      }
    }

    public static void CaracteristicasTipo(Type t)
    {
      //IMPRIMRR LAS CARACTERISTICAS PRINCIPALES DEL TIPO
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("LAS CARACTERISTICAS QUE TIENE SON:");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("CLASE BASE: {0}", t.BaseType);
      Console.WriteLine("ES UNA CLASE: {0}", t.IsClass);
      Console.WriteLine("ABSTRACTA: {0}", t.IsAbstract);
      Console.WriteLine("SELLADA: {0}", t.IsSealed);
      Console.WriteLine("GENERICA: {0}", t.IsGenericTypeDefinition);
    }

    public static void EncuentraCampos(Type T)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("LOS CAMPOS ENCONTRADOS SON:");
      Console.ForegroundColor = ConsoleColor.White;
      //ENCONTRAMOS LOS CAMPOS EN ESE TIPO.
      var nombres = from f in T.GetFields()
                    select f.Name;
      foreach (var nombre in nombres)
      {
        Console.WriteLine("{0}", nombre);
      }
      Console.WriteLine("");
    }
    public static void EncuentaPropiedades(Type t)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("LAS PROPIEDADES ENCONTRADAS SON:");
      Console.ForegroundColor = ConsoleColor.White;

      //ENCONTRAMOS LAS PROPIEDASDE EN ESE TIPO
      var nombres = from p in t.GetProperties()
                    select p.Name;
      foreach(var nombre in nombres){
        Console.WriteLine("{0}",nombre);
      }
    }

    public static void EncuentraMetodos(Type t){
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("LOS METODOS ENCONTRADOS SON:");
      Console.ForegroundColor= ConsoleColor.White;
      //ENCONTRAMOS LOS METODOS EN ESE TIPO
      var nombres = from m in t.GetMethods()
                    select m.Name;
      foreach(var nombre in nombres){
        Console.WriteLine("{0}",nombre);
      }
    }

    public static void EncuentraInterfaces(Type t){
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("LAS INTERFACES ENCONTRADAS SON:");
      Console.ForegroundColor = ConsoleColor.White;

      //ENTRONTRAMSO LAS INTERFACE
      var nombres = from i in t.GetInterfaces() select i.Name;

      foreach(var nombre in nombres)
        Console.WriteLine("{0}", nombre);
    }


  }





}