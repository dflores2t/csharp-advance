using System.Collections;

namespace manejoerrores;

public class Program{
  static void Main(string[] args){
    Caldera miCaldera = new Caldera("MATIC-O", 20);

    //VERSION 1
    for (int i = 0; i < 10; i++){
      // miCaldera.TrabajarV1(20);
    }
  Console.WriteLine("---------------V2----------------");
  //VERSION 2 -> CATCH LA EXCEPCION LANZADA
  try
  {//CODIGO CON RIESGO DE EXCEPCION.
    for(int i =0; i < 10 ; i++){
      // miCaldera.TrabajarV2(20);
    }
  }
  catch (System.Exception e)
  {//CAPTURAR LA EXCEPTIO QUE SE LANZO
    Console.WriteLine("\n SUCEDIO LA EXCEPCION");
    Console.WriteLine("ESTE METODO: {0}",e.TargetSite);
    Console.WriteLine("CON ESTE MENSAJE DE ERROR:{0}",e.Message);
    Console.WriteLine("FUENTE: {0}", e.Source);
    Console.WriteLine("CLASE DONDE OCURRIO:{0}", e.TargetSite.DeclaringType);
    Console.WriteLine("TIPO DE MIEMBRO:{0}", e.TargetSite.MemberType);
    Console.WriteLine("STACK: {0}", e.StackTrace);
    }
    //VERSION 3 ->
    Console.WriteLine("------------------v3----------------------------");
    try
    {//CODIGO CON RIESGO DE EXCEPCION.
      for (int i = 0; i < 10; i++)
      {
        // miCaldera.TrabajarV3(20);
      }
    }
    catch (System.Exception e)
    {//CAPTURAR LA EXCEPTIO QUE SE LANZO
      Console.WriteLine("\n SUCEDIO LA EXCEPCION");
      Console.WriteLine("ESTE METODO: {0}", e.TargetSite);
      Console.WriteLine("CON ESTE MENSAJE DE ERROR:{0}", e.Message);
      Console.WriteLine("FUENTE: {0}", e.Source);
      Console.WriteLine("CLASE DONDE OCURRIO:{0}", e.TargetSite.DeclaringType);
      Console.WriteLine("TIPO DE MIEMBRO:{0}", e.TargetSite.MemberType);
      Console.WriteLine("STACK: {0}", e.StackTrace);
      Console.WriteLine("HELP LINK: {0}", e.HelpLink);
    }
    //VERSION 4 ->
    Console.WriteLine("------------------v4----------------------------");
    try
    {//CODIGO CON RIESGO DE EXCEPCION.
      for (int i = 0; i < 10; i++)
      {
        miCaldera.TrabajarV4(20);
      }
    }
    catch (System.Exception e)
    {//CAPTURAR LA EXCEPTIO QUE SE LANZO
      Console.WriteLine("\n SUCEDIO LA EXCEPCION");
      Console.WriteLine("ESTE METODO: {0}", e.TargetSite);
      Console.WriteLine("CON ESTE MENSAJE DE ERROR:{0}", e.Message);
      Console.WriteLine("FUENTE: {0}", e.Source);
      Console.WriteLine("CLASE DONDE OCURRIO:{0}", e.TargetSite.DeclaringType);
      Console.WriteLine("TIPO DE MIEMBRO:{0}", e.TargetSite.MemberType);
      Console.WriteLine("STACK: {0}", e.StackTrace);
      Console.WriteLine("HELP LINK: {0}", e.HelpLink);

      //VERIFICAMOS SI HAY DATOS
      //AL TRABAJAR CON DATA Y RESULTA QUE DATA ESTA NULL, AL HACER EL FOREACH VOY A TENER PROBLEMAS.
      //PRIMERO VERIFICAR QUE TENEMOS DATA
      if(e.Data !=null){
        //IMPRIMIMOS LOS DATOS EXTRA PROPIOS
        foreach(DictionaryEntry dato in e.Data){
          Console.WriteLine("--> {0} -> {1} ",dato.Key, dato.Value);
        }
      }
    }

  }
}