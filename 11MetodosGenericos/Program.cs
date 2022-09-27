namespace metodogenericos;
public class Program{
  static void Main(string[] args){
    int x = 5;
    int y = 3;

    Console.WriteLine("x= {0}, y= {1} ", x,y);
    Intercambio <int>(ref x, ref y); //todos los lugares que tienen t, se convertiran a int
    Console.WriteLine("x= {0}, y= {1} ", x, y);

    double m = 78.9;
    double n = 98.6;

    Console.WriteLine("m= {0}, n= {1} ", m, n);
    Intercambio<double>(ref m, ref n);
    Console.WriteLine("m= {0}, n= {1} ", m, n);

    //cadenas
    string o = "HOLA";
    string p = "A TODOS";
    Console.WriteLine("o= {0}, p= {1} ", o, p);
    Intercambio<string>(ref o, ref p);
    Console.WriteLine("o= {0}, p= {1} ", o, p);

  }

  //METODO DE INTERCAMBIO GENERICO
  //GENERICO PORQUE PODREMOS HACER QUE ESTE METODO TRABAJE CON CUALQUIER TIPO QUE LE PASEMOS
  // T -> ES UN METODO QUE SERA DE TIPO GENERIOCO
  // LOS PARAMETROS SERAN DE TIPO GENERICOS Y EN ESTE EJEMLO SERA UNA REFERENCIA PERO NO SE FORSZO QUE TENGA QUE ENTRAR COMO REFERENCI
  public static void Intercambio<T>(ref T a, ref T b){
    //clasico swap
    T temporal;
    temporal = a;
    a = b;
    b = temporal;
  }
}