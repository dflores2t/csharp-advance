namespace UpdateCsharp8;

public class CMascota{
  private string nombre = "SIN NOMBRE";
  //VERSION DE DEFAULT
  //SI COLOCAMOS LA INVOCACION AL OTRO CONSTUCTOR
  //SE INVOCA PRIMERO EL DE PRAMATRO Y LUEGO EL DE DEFAULT
  // EL DE DEFAULT PONDRA SUS PROPIOS VALORES SIN IPMORTAR LOS COLOCADOS POR EL DE PARAMETROS
  public CMascota():this("MANCHAS")  //SE INVOCA ESTA Y SOBREESCRIBE CUALQUIRE VALOR, CONSTRUCTOR QUE INVOCA EL CONSTRUCTOR DE DEFAULT
  {
    Console.WriteLine("CONSTRUCTOR DEFAULT");
    // nombre = "PUNTK"; //SI SE COMENTA
  }
  
  //VERSION CON PARAMETRO
  public CMascota(string pNombre)
  {
    Console.WriteLine("CONSTRUCTOR CON PARAMETRO");
    nombre = pNombre;
  }

  public override string ToString()
  {
    return string.Format("TU MASCOTA SE LLAMA {0}", nombre);
  }



}