namespace MetodosExtensio;

//LAS CLASES DONDE SE GUARDARAN LA SEXTENSIONES DEBERAN SER ESTATICA
public static class ClaseExetensiones{  

  //EL METODO QUE EXTIENDE DEBE ESTATICO
  //EL PRIMER PARAMETRO LLEVA THIS Y REPRESENAT AL TIPO QUE ESTAMOS EXTENDIENDO
  public static bool EsPar(this int i){
    return i % 2 == 0 ? true : false;
  }

  //ESTE EXTIENDE A UN DOBLE
  public static double Doletea(this double d){
    return d * 2.0;
  }

  //ESTE EXTIENDO SOLO A LAS CLASES QUE IMPLEMENTEN ISALUDAOR
  public static void Sonido(this ISaludador s){
    Console.Beep();
  }

}