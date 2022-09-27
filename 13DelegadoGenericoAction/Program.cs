namespace DelegadoGenericoAction;

//CREAMOS EL DELEGADO GENERICO
public delegate void miDelegado<T>(T p);

public class Program{
  static void Main(string[] args){
    //REGISTRAMOS Y USAMOS EL STRING
    miDelegado<string> delCadena = new miDelegado<string>(HandlerString);
    delCadena("HOLA A TODOS");

    //REGISTRAMOS Y USAMOS EL DOUBLE
    miDelegado<double> delDoble = new miDelegado<double>(HandlerDouble);
    delDoble(58.7);

    //II ACTION
    //ACTION NOS PERMITE CREAR DELEGADOS ES EL MOMENTO, PARA UN MAXIMO DE 16 PARAMETROS 
    //PERO EL TIPO DE RETORN DEBE SER VOID
    int n = 5;
    string m = "HOLA A TODOS";
    //USAMOS ACTION PARA REGISTRAR EL HADLER CON EL DELEGADO
    Action<string, int> delAction = new Action<string, int>(RepiteMensaje);

    //INVOCAMOS EL DELEGADO
    delAction(m, n);

    //FUNC=> FUNCIONA SIMILAR A ACTION, PERO PERMIE TIPO DE RETORNO.
    //TAMBIEN NOS PERMITE CREAR DELEGADOS EN EL MOMENTO PERO CON SU DIFIRENCIA
    // LA DIFERENCIA ES QUE FUNC NOS PERMITIRA CREAR UN DELEGADO QUE TIENE UN TIPO DE RETORNO
    int x = 5;
    int y = 9;

    //DEFININMOS EL DELEGADO, EL ULTIMO TIPO LISTADO ES SIEMPRE EL TIPO DE RETORN
    Func<int, int, int> delFunc = new Func<int, int, int>(Suma);
    //INVOCAMOS E IMPRIMIMO EL RESULTADO
    Console.WriteLine(delFunc(x,y));




  }

  //HANDLER PARA EL CASO STRING
  static void HandlerString(string p){
    Console.WriteLine("USO STRING COMO TIPO Y EL VALOR ES {0}", p);
  }
  
  //HANDLER PARA EL CASO DOUBL
  static void HandlerDouble(double p){
    Console.WriteLine("USO DOUBLE COMO TIPO Y EL VALOR ES {0}",p);
  }

  //HADLER PARA ACTION
  static void RepiteMensaje(string pMensaje, int pVeces){
    int n = 0;
    for (n = 0; n < pVeces; n++){
      Console.WriteLine(pMensaje);
    }
  }
  //HANDLER PARA FUNC
  static int Suma(int a, int b){
    int r = 0;
    r = a + b;
    return r;
  }




}