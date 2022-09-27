namespace RestriccionesClasesGenericas
{
  public class Program{
    static void Main(string[] args){
      //CONSCEPTO DE RESTRICCIONES
      //DIFERENTES TIPOS DE RESTRICCIONES.

      //RESTRICCIONES GENERIAS. PUEDE OCURRIR QUE NECESITEMO O QUEREMOS QUE ESE TIPO GENERICO SE UTILICE BAJO CIERTAS CONDICIONES.ES DECIR QUE NO CUALQUIER TIPO PUEDA SER UTILIZADO SI NO SOLOMENTE AQUELLOS QUE PERTENECEN A UNA CLASE EN PARTICULAR, IMPLEMENTEN ALGUAN HERENCIA ETC

      CA objetoA = new CA();
      CB objetoB = new CB();
      CC objetoC = new CC();

      CGenerica<CC> oGen = new CGenerica<CC>(objetoC);
      oGen.Repetir();

      //SNIPETS MAS COMUNES
      //~tab crea el desconstructor
      //class tab creac la estructura de la clase
      //ctor tab crea el constructuro
      //cw tab crea  el writeline;
      //do tab tab crea el do-wihel
      //for tab tab crea el for
      // forr tab tab
      //foreach tab
      //iftab tab
      //else tab tab
      //switch tab tab
      //while ta ta
      //
    }
  }
}