namespace MetodosAnonimos;

public class Program{
  static void Main(string[] args){

  CPunto miPunto = new CPunto(5,6);
    //CREAMOS EL METODO ANONIMO PARA EL DELEGADO
    miPunto.mensaje += delegate ()
    {
      Console.WriteLine("ESTOY DESDE EL METODO ANONIMO");
    };
    
    Console.WriteLine(miPunto.ToString());

    //INVOCAMOS
    miPunto.mensaje();

    //ADICIONAMOS OTRO
    miPunto.mensaje += delegate ()
    {
      Console.WriteLine("ESTE ES OTRO METODO ANONIMO");
    };

    miPunto.mensaje();


  }
}