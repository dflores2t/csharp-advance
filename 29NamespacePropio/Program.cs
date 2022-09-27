// using LasClases;
// using OtrasClases;
// using principal = LasClases.Clase1;
// using secundaria = OtrasClases.Clase1;

using ClasesAnidadas.LasClases;

using otras = ClasesAnidadas.OtrasClases;

namespace NamespacePropios
{
  public class Program{
    static void Main(string[] args){
      //LA CLASE SOLO SE PUEDE INSTANCIAR SI USAMOS EL NAMESPACE
      // SI TENEMOS LOS DOS USING EL COMPILADOR NO SABE CUAL USAR
      // Clase1 ob1 = new Clase1();

      //SIN HACER USO DEL USING, NOMBRE TOTALMENTE CALIFICADO.
      //ESTO SI ESTAN EN EL MISMO PROYECTO.
      // LasClases.Clase2 obj2 = new LasClases.Clase2();

      //ADICIONAMOS EL OTRO NAMESPACE
      //HAY CONFLICTO SI EN LOS DOS NAMESPACE SE TIENE NCLASES CON EL MISMO NOMBRE 
      //SE RESUELVE  CON EL NOMBRE TOTALMENTE CALIFICADO
      // LasClases.Clase1 obj3 = new LasClases.Clase1();
      // OtrasClases.Clase1 obj4 = new OtrasClases.Clase1();

      // CREACION DE UN ALIAS
      // principal ob1 = new principal();
      // secundaria ob2 = new secundaria();

      //NAMESPACE ANIDADOS
      Clase1 miObjeto = new Clase1();
      otras.Clase1 otroObjeto = new otras.Clase1();


    }
  }
}