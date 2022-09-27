namespace UpdateCsharp8{
  public class Electronica : Mascota{
    //USAMOS NEW PARA INDICARLE AL COMPILADOR QUE EL OCULTAMIENTO NO ES ACCIDENTAL
    private new string nombre;

    public string  Nombre { set=>nombre =value; }
  }
}