namespace ClaseGenerica;

public class COperaciones<T>{

  //COMPILADOR DETECTA MENSAJES DE ERRORES.
  //TRABAJA CON INT DOUBLE ETC TAMBIEN CON CLASES, TRABAJODOR, PERSONA, AUTOMAVIL, ETC. EL COMPILADOR NO TINE FORMA DE SABERLO.
  // POR ESO AL REALIZAR  OPERACIONES EL COMPILADOR MANDA EL ERORR.
  //PARA RESOLVERLO SE HARA USO DE DYNAMIC, NO AL 100% PERO NOS AYUDARA SI SABEMOS QUE ESA OPERACION TRABAJARA CON TIPOS NUMERICOS.

  // public T Suma(T a, T b){
  //   return a + b;
  // }
  // public T Resta(T a, T b){
  //   return a - b;
  // }
  // public T Div(T a, T b){
  //   return a / b;
  // }
  // public T Multi(T a, T b){
  //   return a * b;
  // }

  //REFACTORING -> DYNAMIC
  //ESTO NO RESULEVE EL PROLEMA AL 100%.
  public T Suma(T a, T b){
    dynamic da = a, db = b;
    return da + db;
  }
  public T Resta(T a, T b){
    dynamic da = a, db = b;
    return da - db;
  }
  public T Div(T a, T b){
    dynamic da = a, db = b;
    return da /db;
  }
  public T Multi(T a, T b){
    dynamic da = a, db = b;
    return da * db;
  }




}