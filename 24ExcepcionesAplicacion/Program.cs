namespace erroresaplicacion;

public class Program{
  static void Main(string[] args){
    //V1
    Caldera miCaldera = new Caldera("MATIC-O", 20);
    Random rnd = new Random();

    while(miCaldera.Funciona){
      try{
        miCaldera.TrabajarV1(rnd.Next(10));
      }
      // catch(Exception ex){
      //   Console.WriteLine("EL MENSAJE: {0}",ex.Message);
      // }
      catch(CalderaExcepcion ex){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.Momento);
        Console.WriteLine(ex.Causa);
      }
    }
  }
}