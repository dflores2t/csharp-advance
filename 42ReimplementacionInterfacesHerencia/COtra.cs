namespace ReimplementacionInterfacesHerencia { 
//CLASE HIJA, DERIVA DE LA CLASE PADRE CPRUEBA
  public class COtra : CPrueba{

    public COtra(double pNumero):base(pNumero)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("EN EL CONSTRUCTOR DE CLASE HIJA COTRA");
      Calcular(pNumero);
      Console.WriteLine("SALIENDO DEL CONSTRUCTOR DE LA CLASE COTRA.");
    }
  }
}