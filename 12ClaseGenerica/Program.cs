namespace ClaseGenerica;

public class Program{
  static void Main(string[] args){
    //PARA PUNTOI, T TRABAJA COMO INT
    CPunto<int> puntoI = new CPunto<int>(3,4);

    //PARA PUNDOD, T TRABA COMO DOUBLE
    CPunto<double> puntoD = new CPunto<double>(2.56, 1.87);

    //PARA PUNTO F, T TRABAJA COMO FLOAT
    CPunto<float> puntoF = new CPunto<float>(8.98f, 7.69f);

    Console.WriteLine(puntoI);
    Console.WriteLine(puntoD);
    Console.WriteLine(puntoF);

    //COLOCAMOS EL VALOR DE DEFAULT
    puntoI.Reset();
    Console.WriteLine(puntoI);

    //VERIFICAMOS SI ESTA TRABAJANDO CON ENTERO
    puntoI.EncuentraTipo();
    puntoD.EncuentraTipo();

    //PROBLEMAS CON CLASES GENERICAS

    //VER LA CLASE COPERACIONES, NO ES POSILE COMPILAR
    //USAMOS DYNAMY PARA RESOLVER EL PROBLEMA, EL TIPO SE CHECA EN EJECUCION Y NO EN COMPILACION.

    COperaciones<int> miOperacion = new COperaciones<int>();
    COperaciones<string> miOperacionS = new COperaciones<string>();

    Console.WriteLine(miOperacion.Suma(5,4));
    Console.WriteLine(miOperacionS.Multi("HOLA"," A TODOS"));

  }
}