namespace ReimplementacionInterfacesHerencia
{
  public class Program{
    static void Main(string[] args){
      //REIMPLEMENTACION DE INTERFACES EN HERENCIAS
      //ES DECIR CUANDO UNA DE LAS CLASES HIJAS NECESITAN TENER SU PROPIA IMPLEMENTACION DE UNA INTERFAZ QUE IMLPMENTO LA CLASE BASE, USO DEL POLIFORMISMO.

      //UNA CLASE PADRE LA CUAL  IMPLEMENTA UNA ITERFAZ Y LUEGO UNA DE LAS CLASES HIJAS HARA UNA REIMPLEMENTACION DE ESA INTERFAZ.

      CPrueba o1 = new CPrueba(45);
      o1.Calcular(12.5);
      Console.WriteLine("---------------------------------------");

      COtra o2 = new COtra(10);
      Console.WriteLine("---------------------------------------");

      CTest o3 = new CTest(45);
      o3.Calcular(12.5);
      Console.WriteLine("------------------------");

      //GRACIAS AL POLIMORFISMO PODEMOS USAR LA VERSION ORIGINAL
      ((CPrueba)o3).Calcular(12.5);

      Console.WriteLine("-----------------IMPLEMENTACION VIRTUAL DE INTERFAZ----------------------");
      CPrueba o4 = new CPrueba(45);
      o4.Calcular(12.5);

      Console.WriteLine("----------------");
      COtra o5 = new COtra(10);
      Console.WriteLine("-----------------------");

      //HACIENDO OVERRIDE
      CTest o6 = new CTest(45);
      o6.Calcular(12.5);
      Console.WriteLine("-----------------------");

      //NOTAR QUE AQUI NO TENEMOS LA VERSION POLIMORFICA
      //no hay acceso a la version polimorfica.
      ((CPrueba)o6).Calcular(12.5);
    }
  }
}