namespace UpdateCsharp8;

public class CAmigo{
  private string nombre;
  private string whats;

  public CAmigo(string pNombre, string pWhats)
  {
    nombre = pNombre;
    whats = pWhats;
  }

  public override string ToString()
  {
    return string.Format("MI AMIGO {0} TIENE WATHS {1}", nombre, whats);
  }

  //CUARTO CASO
  //NOS MANDAMOS A NOSOTROS MISMOS COMO PARAMETRO
  //PARA QUE QUIEN NOS RECIBA TRABAJE CON NOSOTROS
  public void Mensajear(){
    CMensaje miMensaje = new CMensaje();
    miMensaje.Presentar(this);
  }
}