namespace UsoAvanzadoSwitch
{
  /// USO AVANZADO DE SWITCH
  /// USARLO CON VARIOS TIPOS
  /// MISMO CODIGO PARA DIFERENTES CASOS
  /// DEFAULT NO HOCE FALTA
  /// 
  public class Program{
    static void Main(string[] args){
      //ESTE PROGROMA MUESTRA COMO PODEMOS USAR SWITCH CON OTROS TIPOS APARTE DE INT

      bool booleana = true;
      char character = 'a';
      string cadena = "Priviet";
      Console.WriteLine("------------SWITCH BOOLEAS-----------");
      //con bool
      switch(booleana){ 
        case true:
        Console.WriteLine("LA VARIABLE TIENE TRUE");
          break;
        case false:
        Console.WriteLine("LA VARIABLE TIENE FALSE");
          break;
      }
Console.WriteLine("------------------SWITCH CHARACTER----------------");
      //CON CARACTER
      switch (character){
        //un mismo codigo con varios casos: indicar si es vocal o consonante
        case 'a':
        case 'e':
        case 'i':
        case 'o':
        case 'u':
        Console.WriteLine("ES VOCAL");
          break;
          default:
          Console.WriteLine("ES CONSONANTE");
          break;          
      }
      Console.WriteLine("--------CON CADENA-----------");
      switch (cadena){
        case "Hola":
        Console.WriteLine("ESPANOL");
          break;
        case "Hello":
        Console.WriteLine("ENGLISH");
          break;
        case "Priviet":
        Console.WriteLine("RUSO");
          break;
      }
    }

  }
}