namespace UpdateCsharp8;

public class Alimento{
  //11
  private int calorias;
  //EL CONSTRUCTOR ESTATICO SE EJECUTA SOLO UNA VEZ PARA TODAS LAS INSTANCIAS

  static Alimento()
  {
    Console.WriteLine("DESDE EL CONSTRUCTOR ESTATICO ALIMENTO");
  }

  public int Calorias { set => calorias = value; }

  public override string ToString()
  {
    return string.Format("TIENES {0} CALORIAS", calorias);
  }

}