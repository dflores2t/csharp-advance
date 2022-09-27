namespace UpdateCsharp8;

public class CClaseHija : CClaseBase{


  //HACEMOS OVVERIDE
  public override void Saludo()
  {
    Console.WriteLine("saludos desde la clase hija");
  }

  public void Seleccionar(int pOpcion){
    //INVOCAMOS NUESTRA VERSION DE LA FUNCION
    if(pOpcion ==1){
      Saludo();
    }
    //INVOCAMOS LA VERSION DE LA CLASE BASE
    if(pOpcion ==2){
      base.Saludo();
    }
  }
}