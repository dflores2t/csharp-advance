namespace UpdateCsharpV9;

public class CBase
{
  public String nombre;

  public virtual CBase Clonar()
  {
    return new CBase { nombre = nombre };
  }

  public override string ToString()
  {
    return string.Format("NOMBRE {0}", nombre);
  }

  //AHORA GENERAMOS UNA SUBCLASE

}
public class CHija : CBase
{
  public int edad;
  //HACEMOS EL OVERRIDE PERO REGRESAMOS EL TIPO DERIVADO
  public override CHija Clonar()
  {
    return new CHija { nombre = nombre, edad = edad };
  }

  public override string ToString()
  {
    return string.Format("nombre {0}, edad {1}", nombre, edad);
  }
}