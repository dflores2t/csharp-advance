namespace UpdateCsharp8{
  public class MiEjemplo:IComportamientos {


    public void Mostrar(){
      Console.WriteLine("LA IMPLEMENTACION EN EL EJEMLPO");
    }

    public void Calcular(){
      Console.WriteLine(5 * IComportamientos.valor);
    }
  }
}