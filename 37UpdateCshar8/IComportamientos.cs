namespace UpdateCsharp8;

public interface IComportamientos{

  //YA PUEDE EXISTIR UNA IMPLEMENTACION DE DEFAULT
  // ES UTIL SI DESEAMOS ADICIONAR UN MIEBRO A UNA INERFGAZ SIN DANAR LAS IMPLEMANTACIONES YA REALIZADAS
  //LAS IMPLEMENTACIONES DE DEFAULT SON SIMPRES EXPLICITAS
  void Mostrar(){
    Console.WriteLine("IMPLEMENTACION DE DEFAULT");
  }

  //AHORA TAMBIEN PODEMO DEFINIR CAMPOS ESTATICOS
  //PERTENECE A LA INTERFAZ, NO A LA CLASE

  static int valor = 5;

}