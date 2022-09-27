namespace ConversionExplicita
{
  public class Program
  {
    static void Main(string[] args)
    {
      //CONVERSION ENTRE CLASES QUE HEMOS CREADO, 
      //CONVERSION EXPLICITA
      //CONVERSION CUSTOM DE TIPO
      CComplejo comp1 = new CComplejo(2, 3);

      //NO SE PUEDE
      // CReal real1 = comp1;//no se puede convertir explicitamente el tipo

      //TAMPOCO SE PUEDE HASTA QUE COLOQUEMOS EL EXPLICIT
      CReal real2 = (CReal)comp1; //typecast sobrecarga del operador creal-> se invoca el metodo de conversion
      Console.WriteLine(real2);
    }
  }
}