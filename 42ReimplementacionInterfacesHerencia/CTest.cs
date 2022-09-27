namespace ReimplementacionInterfacesHerencia { 
  //CLASE HIJA CTEST DERIVA DE LA CLASE PADRE CPRUEBA, SI EMBARGO CTEST REIMPLEMENTARA A CALCULAR ENTONCES DEBEMOS INDICAR QUE TIENE QUE IMPLEMANTAR A ICALCULABLE=> TIENE HERENCIA PERO TAMIEN LLEVA A CABO SU PROPIA IMPLEMANTACION 
  // public class CTest: CPrueba, ICalculable{
  //   double miNumero;

  //   public CTest(double pNumero):base(pNumero)
  //   {
  //     miNumero = pNumero;
  //   }

  //   //REIMPLEMENTACION DE CALCULABLE DE LA INTERFAZ CALCULABLE
  //   public void Calcular(double pValor){
  //     Console.ForegroundColor = ConsoleColor.Green;
  //     Console.WriteLine("VERSION DE CLASE TEST {0}", miNumero + pValor);
  //   }
  // }

  //PARA EL OVERRIDE NO IMPLEMENTAMOS LA INTERFAZ
  public class CTest: CPrueba{
    double miNumero;

    public CTest(double pNumero):base(pNumero)
    {
      miNumero = pNumero;
    }

    //AQUI HACEMOS ES OVERRIDE DE LA IMPLEMENTACION
    public override void Calcular(double pValor){
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("VERSION DE CLASE TEST {0}", miNumero + pValor);
    }
  }
}