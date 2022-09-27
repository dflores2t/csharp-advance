namespace UpdateCsharp
{
  public class CPrueba{
    private string nombre;
    private int edad;

    public CPrueba(string pNombre, int pEdad)
    {
      nombre = pNombre;
      edad = pEdad;
    }
    public override string ToString()
    {
      return string.Format("{0} tiene {1}", nombre, edad);
    }

    //AQUI DEFINIMOS EL DESCONSTRUCTOR, NO CONFUNDIR CON EL DESTRUCTOR/FINALIZADOL
    //SIEMRPE LA PALABRA DESCONSTURCT
    public void Desconstruct(out string oNombre, out int oEdad){
      //MANDOMAS AL EXTERIRO LO QUE NOS INTERESA ANTES DE QUE EL OBJETO SEA DESTRUIDO
      oNombre = nombre;
      oEdad = edad;
    }

    //CREAMOS EL DESTRUCTOR QUE USA =>
    ~CPrueba() => Console.WriteLine("ADIOS");


  }
}