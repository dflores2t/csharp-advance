namespace objetoasis;

public class Program{
  static void Main(string[] args){
    //DETERMINAR SI DETERMINADO OBJETO IMPLEMENTA UNA INTERFAZ

    CTelevisor miTele = new CTelevisor("SHARPY");
    CPelota miPelota = new CPelota("GRANDE");
    IElectronico objeto = null;


    //METODO 1, POR EXCEPCION.=> ESTE METODO ES UN POCO DE FORZAR EL ERROR PARA SABER SI IMPLEMENTA O NO
    try
    {
      Console.WriteLine("PROBAMOS LA TELE");
      objeto = (IElectronico)miTele;
      objeto.Encender(true);
    }
    catch (InvalidCastException e)
    {
      Console.WriteLine(e.Message);
    }
    try
    {
      Console.WriteLine("PROBAMOS LA PELOTA");
      objeto = (IElectronico)miPelota;
      objeto.Encender(true);
    }
    catch (InvalidCastException e)
    {
      
      Console.WriteLine(e.Message);
    }
  Console.WriteLine("------------------------------------------------");

    //METODO 2 A TRAVES DE AS,(PUEDE SER TRATADO COMO)
    Console.WriteLine("METODO 2:AS- PROBAMOS LA TELE");
    objeto = miTele as IElectronico; //= mitele tratado com ielectronico
    if(objeto != null){
      objeto.Encender(true);
    }else{
      Console.WriteLine("NO IMPLEMENTA A IELECTRONICO");
    }
    Console.WriteLine("METODO 2 : PROBAMOS LA PELOTA");
    objeto = miPelota as IElectronico;
    if(objeto !=null){
      objeto.Encender(true);
    }else{
      Console.WriteLine("NO IMPLEMENTA A IELECTRONICO");
    }

    Console.WriteLine("----------------------");

    //METODO 3 POR IS ( ES P ES COMPATILE CON)
    Console.WriteLine("METODO 3:IS- PROBAMOS LA TELE");
    if(miTele is IElectronico){
      miTele.Encender(true);
    }else
      Console.WriteLine("NO IMPLEMENTA IELECTRONICO");
    
    Console.WriteLine("MOTODO 3:IS - PROBAMO LA PELOTA");
    if(miPelota is IElectronico)
      Console.WriteLine("WOW PELOTA IMPLEMENTA IELECTRONICO");
    else
      Console.WriteLine("NO IMPLEMENTA IELECTRONICO");
    Console.WriteLine("-------------------------------");
  }
}