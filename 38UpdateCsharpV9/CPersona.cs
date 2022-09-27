namespace UpdateCsharpV9
{
  public partial class CPersona
  {
    private string Nombre;
    private int Edad;

    public CPersona(string pNombre, int pEdad)
    {
      Nombre = pNombre;
      Edad = pEdad;
    }

    //AQUI COLOCAMOS EL METODO DEL PROTOTIPO DEL METODO PARCIAL
    // QUE SERA IMPLEMENTADO EN OTRO DOCUMENTO
    public partial void Muestra();
  }
}