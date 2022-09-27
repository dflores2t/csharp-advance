namespace cg
{
  public class Program{
    static void Main(string[] args){
      //OBTENEMOS LA CANTIDAD DE BYTES EN EL HEAP
      //LA CLASE CG, QUE NOS PROPORCIONA .NET, DE GARBAGE COLECTOR.
      long bytesHeap = GC.GetTotalMemory(false);
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine("EL HEAP USA {0} BYTES", bytesHeap);

      //CANTIDAD DE GENERACIONES, BASADOS EN 0 POR ESO +1
      int maximaGeneracion = GC.MaxGeneration + 1;
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("SE TIENEN {0} GENERACIONES", maximaGeneracion);

      //CREAMOS UNA INSTANCIA
      CPrueba prueba1 = new CPrueba(5);

      bytesHeap = GC.GetTotalMemory(false);
      Console.WriteLine("EL HEAP USA {0} BYTES", bytesHeap);

      //OBTENEMOS LA GENERACION DE LA INSTANCIA
      int generacionInstancia = GC.GetGeneration(prueba1);
      Console.WriteLine("LA GENERACION DE LA INSTANCIA ES {0}", generacionInstancia);

      //FORZAR LA RECOLECCION DE BASURA
      // NO NECESARIAMENT INDICA QUE SE LLEVE A CABO EN ESE MOMENTO.
      //SOLO HACERLO EN SITUACIONES ESPECIALES.
      //CUANDO LA APLICACION ENTRA A UN BLOQUE DE  CODIGO QUE NO DEBE DE SER INTERRUMPUDIO POR LA RECOLECCION.
      //LA APLICACION CREO UNA GRAN CANTIDAD DE INSTANCIAS Y SE NECESITA LIBERAR LA MAYOR CANTIDAD DE MEMORIA POSIBLE

      // GC.Collect();
      // GC.WaitForPendingFinalizers();

      // //PARA RECOLECTAR DE UNA GENERACION EN PARTICULAR
      // GC.Collect(0);
      // GC.WaitForPendingFinalizers();

    }
  }
}