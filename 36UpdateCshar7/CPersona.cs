namespace UpdateCsharp{
  public class CPersona{
    private string nombre;

    private int edad;

    //ESTA ES UNA PROPIEDAD Y ACTUARA COMO DE SOLO LECTURA
    public string Nombre => string.Format ("EL NOMBRE ES : {0}", nombre);

    //ESTA PROPIEDAD INDICAMES EL GET Y SET, ES DE ENTRADA Y SALIDA
   public int Edad { get=>edad; set=>edad = value; }

   public CPersona(string pNombre , int pEdad)
   {
      nombre = pNombre;
      edad = pEdad;
    }

    public override string ToString()
    {
      return string.Format("{0} tiene {1} de edad ", nombre, edad);
    }


  }
}