namespace objetosdesechables;
public class Program{
  static void Main(string[] args){
    CPrueba objeto = new CPrueba(5);
    // Console.WriteLine(objeto);
    objeto.Dispose(); //EL OBJETO NO ES DESTRUIDO SIGUE EXISTIENDO.

    //UNA MEJOR MANERA DE HACERLO
    if(objeto is IDisposable) //VERIFICAR SI ESTA IMPLEMENTANDO LA INTERFAZ
    {
      objeto.Dispose();
    }

    //UNA FORMA PARA GARANTIZAR QUE DISPOSE ES INVOCADO

    try
    {
      Console.WriteLine(objeto);
    }
    finally
    {
      objeto.Dispose();
    }

    //CON ESTA TECNICA DISPOSE ES INVOCADO AUTOMATICAMENE
    //SE PUEDE LISTAR VARIOS OBJETOS EN EL USING
    using(CPrueba prueba2 = new CPrueba(7)){
      // Console.WriteLine(prueba2);
    }
    Console.WriteLine("---------SEGUNDA PARTE-------------");
    //SEGUNDA PARTE
    //CREAMOS OBJETOS
    CPrueba2 obj1 = new CPrueba2(5);
    CPrueba2 obj2 = new CPrueba2(7);

    Console.WriteLine(obj1);
    Console.WriteLine(obj2);

    //HACEMOS DISPOSE DE OBJETO 1
    obj1.Dispose();

    Console.WriteLine("------FIN DEL PROGRAMA-----------");

  }
}