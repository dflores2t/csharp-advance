using Aritmetica;

namespace CrearBibliotecas
{
  public class Program{
    static void Main(string[] args){
      MisMates calculadora = new MisMates(5,4);

      Console.WriteLine("SUMA:{0}", calculadora.Suma());
      Console.WriteLine("RESTA:{0}", calculadora.Resta());
      Console.WriteLine("MULTIPLICACION:{0}", calculadora.Multi());
      Console.WriteLine("DIVISION:{0}", calculadora.Div());

    }
  }
}