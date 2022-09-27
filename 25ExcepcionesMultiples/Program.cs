namespace excepcionesmultiples;
public class Program
{
  static void Main(string[] args)
  {
    //V1
    Caldera miCaldera = new Caldera("MATIC-O", 20);
    try
    {
      //FORZAMOS UNA EXCEPCION DE ARGUMENTO FUERA DE RANGO
      // miCaldera.TrabajarV1(500);
    }
    catch (CalderaExcepcion e)
    {
      Console.WriteLine(e.Message);
    }
    catch (ArgumentOutOfRangeException e)
    {
      Console.WriteLine(e.Message);
    }
    // //V2
    // Console.WriteLine("------------------VERSION 2------------------");

    // try
    // {
    //   //FORZAMOS UNA EXCEPCION DE ARGUMENTO FUERA DE RANGO
    //   miCaldera.TrabajarV1(-10);
    // }
    // catch (Exception e) //ESTE CATCH PUED CAPTURAR TODAS LAS EXCEPCION DE QUE ESTAN POR DEBAJO DE ELLA.
    // {
    //   Console.WriteLine(e.Message);
    // }
    // catch (CalderaExcepcion e)
    // {
    //   Console.WriteLine(e.Message);
    // }
    // catch(ArgumentOutOfRangeException e){
    //   Console.WriteLine(e.Message);
    // }
    //V3
    Console.WriteLine("------------------VERSION 3------------------");

    try
    {
      //FORZAMOS UNA EXCEPCION DE ARGUMENTO FUERA DE RANGO
      // miCaldera.TrabajarV1(-10);
    } //EXCEPCIONES DE LA MAS PARTICULAR A LA MAS GENERAL.
    catch (CalderaExcepcion e)
    {
      Console.WriteLine(e.Message);
    }
    catch (ArgumentOutOfRangeException e)
    {
      Console.WriteLine(e.Message);
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
    }
    //V4
    Console.WriteLine("------------------VERSION 4------------------");

    try
    {
      //FORZAMOS UNA EXCEPCION DE ARGUMENTO FUERA DE RANGO
      // miCaldera.TrabajarV1(-10);
    }   //ESTE CATCH CAPTURA TODO EROR POR NO TENEMOS INFORMACION. DE LO SUCEDIDO. SE LLAMA ATRAPAMIENDO GENERICO.
    catch
    {
      Console.WriteLine("ALGO SALIO MAL PERO NO SABEMOS QUE");
    }
    //V5
    //SE PUEDEN TENER EXCEPCIONES ANIDADAS.
    Console.WriteLine("------------------VERSION 5------------------");

    try
    {
      //FORZAMOS UNA EXCEPCION DE ARGUMENTO FUERA DE RANGO
      // miCaldera.TrabajarV1(2);
      try
      {
        // miCaldera.TrabajarV1(300);
      }
      catch (CalderaExcepcion e)
      {

        Console.WriteLine(e.Message);
      }
    }
    catch (ArgumentOutOfRangeException e)
    {
      Console.WriteLine(e.Message);
    }
    //V6
    //FINALLY DESPUES DE TODO LOS CATCH-> CODIGO QUE SE EJECTUA SIN IMPORTAR SI CAEMOS EN LOS CATCH
    Console.WriteLine("------------------VERSION 6 FINALLY------------------");
    try
    {
      //FORZAMOS UNA EXCEPCION DE ARGUMENTO FUERA DE RANGO
      // miCaldera.TrabajarV1(-10);
    }
    catch (CalderaExcepcion e)
    {

      Console.WriteLine(e.Message);
    }

    catch (ArgumentOutOfRangeException e)
    {
      Console.WriteLine(e.Message);
    }
    finally{
      Console.WriteLine("ESTE ES EL CODIGO COMUN EN  FINALLY");
    }
    //V7
    //QUE PASA CUANDO NO SUAMOS LAS EXCEPCIONES. NUESTRA APP HACE CRASH
    Console.WriteLine("------------------VERSION 6 FINALLY------------------");
  
      //FORZAMOS UNA EXCEPCION DE ARGUMENTO FUERA DE RANGO
      miCaldera.TrabajarV1(-10);
  
  }
}