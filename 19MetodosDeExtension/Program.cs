namespace MetodosExtensio;

public class Program{
  static void Main(string[] args){
    //ESTE PROGRAMA MUESTRA EL USO DE METODO DE EXTENSION

    //EXTENSION DEL INT
    int numero = 56; // si quiseramos saber si es par.
    //ADICIONAMEROS A INT UN METODO DE EXTENSION.

    bool par = numero.EsPar(); //ACA ECONTRAMOS LA EXTENSION
    Console.WriteLine("{0} es {1}", numero, par);

    //EXTENSION DEL DOUBLE
    double valor = 55.18;
    Console.WriteLine(valor.Doletea());

    //TAMBIEN FUNCIONA CON LAS INTERFACES
    CMiInt entero = new CMiInt(7);
    entero.Sonido();
    entero.Saluda();



  }
}