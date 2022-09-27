namespace ConversionImplicita;

public class Program{
  static void Main(string[] args){
    //CONVERSION IMPLICITA
    CReal r3 = new CReal(3.5);    
    CComplejo im2 = r3;
    Console.WriteLine(im2);

    //TIPOS ANONIMOS
    //CREAMOS TIPOS ANONIMOS
    //CREA UN TIPO TEMPORAL CON ATRIBUTOS, PROPIEDADES , TOSTRNIG

    //CREAMOS EL TIPO ANONIMO-> UN TIPO ANONIMO ES UNA CLASE QUE CONTENRA INFORMACION, NO SE LE PUEDE COLOCAR METODOS, SOLAMENTE LOS ATRIBUTOS CON LOS QUE SE TRABAJARA COMO ELEMENTO TEMPORAL.
    var miCompu = new { procesador = "I7", Memoria = 16, Graficos = "INTEL" };

    //IMPLIMIMOS LA VARIABLE
    Console.WriteLine(miCompu);

    //IMPRIMIMOS UN ATRIBUTO
    Console.WriteLine("LA COMPU TIENE {0} DE MOMERIA", miCompu.Memoria);

    //NO PODEMOS MODIFICAR EL ATRIBUTO, ES DE SOLO LECTURA
    // miCompu.Graficos = "nvidia"; //no se puede asignar a la propiedad o el indizador


  }
}