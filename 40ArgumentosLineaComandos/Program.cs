namespace ArgumentosLineaComandos
{
  public class Program{
    static void Main(string[] args){ //=> args es un arreglo de tipo cadena, cada una de las palabras que coloquemos se guardara en la cadena.
      //ESTE PROGRAMA HACE USO DE LOS ARGUMENTOS DE LINEA DE COMANDO, OBTIENE UN NOMBRE POPR LINEA DE COMANDO Y LA CANTIDAD DE VECES
      //dir, ls, dir .exe
      //variables
      string nombre = "";
      int repeticiones = 0;
      int n = 0;

      //verificamos que tenga la cantidad de argumentos
      if(args.Length !=2){
        Console.WriteLine("DEBE DE PONER EL NOMBRE Y LAS REPETICIONES");
      }
      else{
        //OBTENEMOL LOS ARGUMENTOS
        nombre = args[0];
        repeticiones = Convert.ToInt32(args[1]);

        //HACEMOS EL SALUDO
        for (n = 0; n < repeticiones; n++){
          Console.WriteLine("HOLA {0}!",nombre);
        }
      }
    }
  }
}