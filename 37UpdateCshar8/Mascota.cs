namespace UpdateCsharp8;

public class Mascota {
  protected string nombre;

  public Mascota()
  {

  }

  public Mascota(string pNombre)
  {
    nombre = pNombre;
    Console.WriteLine("DESDE EL CONSTRUCTOR DE MASCOTA");
  }

  public override string ToString()
  {
    return string.Format("MI MASCOTA ES {0}",nombre);
  }
}