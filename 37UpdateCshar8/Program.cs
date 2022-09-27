namespace UpdateCsharp8
{
  public class Program
  {
    static void Main(string[] args)
    {
      //c# version 8-> netcore
      Console.WriteLine("ACTUALIZACION DE C # VERSION 8");
      //UPDATE 1
      // UpdateOverFlow();

      //UPDATE 2
      // UpdateDecimal();

      //UPDATE3
      // UpdateCadenas();

      //UPDATE 4
      // UpdateIndicesRangos();

      //UPDATE 5
      // UpdateExpresionesSwitch();

      //UPDATE 6
      // UpdateNullCoalescing();

      //UPDATE 7
      // UpdateUsoThis();

      //UPDATE 8
      // UpdateFuncionesLocales();

      //UPDATE 9
      // UpdateUsoBase();

      //UPDATE 10
      // UpdateUsoInterfaces();

      //UPDATE 11
      // UpdateConstructurStatico();

      //UPDATE 12
      // UpdateHerenciaClaseGenerica();

      //UPDATE 13
      // UpdateStaticClaseGenerica();
      //UPDATE 14
      UpdateMetodoPlugIn();



    }

    //METODOS PARA CUADA ACTUALIZACION
    //1
    static void UpdateOverFlow()
    {
      //DETECTAR OVERFLOW EN UNA OPERACION ARITMETICA
      //OVERFLOW SUCEDE CUANDO TENEMOS UN VALOR MAS GRANDE QUE EL VALOR QUE PUEDE CONTENER LA VARIABLE DE DETERMINADO TIPO Y NO TENEMOS ALGUN TIPO DE ADVERTENCIA POR LO QUE NO NOS DARIAMOS CUENTA

      int n = 1000000;
      int m = 1000000;

      //ESTO DEBE DE GENERAR UN OVERFDLOW -> DESBORDAMIENTO
      // PERO NUNCA NOS ENTERAMOS
      int r = n * m;
      Console.WriteLine("EL RESULTADO DE R: = {0} ", r); //ni warning ni excepcion.

      //HACEMOS LO MISMO PERO RECIBIMOS NOTIFIACION DEL OVERFLOW
      // int r2 = checked(n * m);
      // Console.WriteLine("EL RESULTADO DE R2 CON OVERFLOW CHECKED = {2}",r2);

      //AHROA CAPTURAMOS LA EXCEPCION
      int r3 = 0;
      int r4 = 0;
      try
      {
        checked
        { //OTRA FORMA DE USAR EL CHECKED COMO BLOQUE DE CODIGO, COLOCANDO AQUELLAS EXPRESIONES ARITMETICAS QUE PUEDEN OCASIONAR OVERFLOW
          r3 = n * m;
          r4 = n + m;
        }
      }
      catch
      {
        Console.WriteLine("PROBLEMA DE OVERFLOW");
      }
    }

    //  2. USO DE DECIMAL CON NUMEROS FLOTANTE
    static void UpdateDecimal()
    {
      Console.WriteLine("-----------USO DE DECIMAL-----------");
      //FLOAT Y DOUBLE REPRESENTAN LOS NUMEROS EN BASE2
      // VALORES FRACCIONARIOS NO SE VAN A REPRESENTAR BIEN Y DA ERRORES DE PRECISION

      float a = 1f;
      float b = 0.1f; //postfijo f, para indicar flotante, de lo contrario lo tama como double
      float r = a - (b * 10); //CUAL ES EL VALOR DE R.
      Console.WriteLine("CON FLOTANTE {0}", r);

      //COMO PODEMOS CORREGIR ESTO?
      //HACEMOS USO DE DECIMAL, PUES REPRESENTA LOS NUMEROS EN BASE 10, DE TAL MANERA QUE LOS TIPOS DE INCONVENIETES NO VAN  A ESTAR PRESENTE
      Decimal a1 = 1;
      decimal b1 = 0.1m; //postfijo m para indicar deciamal de lo contrario lo toma como double

      decimal r1 = a1 - (b1 * 10);
      Console.WriteLine("CON TIPO DECIMAL ES:{0}", r1);

      Console.WriteLine("--------------------------");
    }

    //3. USO DE CARACTERES UNICODE Y CADENAS
    static void UpdateCadenas()
    {
      //TIPS CON CADENAS
      // COMO USAR CARACTERESO UNICODE CODIFICADOS COMO 4 DIGITOS 
      //HEXADECIMALES
      //CODIGO DE SCAPE \U
      char c = '\u00A9';
      Console.WriteLine("{0}", c);

      //CONCATENACION CON VALORES NUMERICCOS
      //TOSTRING SE INVOCA AUTOMATICAMENTE
      float a = 3.567891f;
      Console.WriteLine("EL VALOR DE A ES {0}", a);
      Console.WriteLine("EL VALOR DE A ES " + a);

      //INTERPOLACION DE CADENAS
      Console.WriteLine($"EL VALOR DE {a} ES IMPORTANTE");
    }

    //4 INDICES Y RANGOS CON LOS ARREGLOS, NUEVO EN C# PROVIENE DE PYTHON
    //
    static void UpdateIndicesRangos()
    {
      //INDICES, PERMITEN REFERENCIAR INDICES QUE CUENTEN AL FINAL DEL ARRGELO CON EL OPERADOR ^  HAT
      // ^0 GENERA ERROR, ^1 EN ADELANTE HASTA EL LIMITE DEL ARREGLO.
      int[] arreglo = new int[] { 0, 1, 2, 3, 4, 5 };
      int ultiom = arreglo[^1];
      int penultimo = arreglo[^2];
      Console.WriteLine("ULTIMO {0}, PENULTIMO {1}", ultiom, penultimo);

      //RANGES, PERMITEN HACER SLICES O REBANADAS DEL ARRGELO
      int[] primeros = arreglo[..2]; //tomara desde el inicia hasta el indice 2 sin tomarlo
      int[] ultimo = arreglo[3..]; //a partir de que indice y hasta el final del arreglo
      int[] intermedio = arreglo[2..4];//a partir del
      Console.WriteLine("PRIMEROS");
      foreach (int n in primeros)
        Console.WriteLine(n);

      Console.WriteLine("ULTIMOS");

      foreach (int n in ultimo)
        Console.WriteLine(n);

      Console.WriteLine("INTEREMEDIOS");
      foreach (int n in intermedio)
        Console.WriteLine(n);
    }

    //5 => EXPRESIONES SWITCH
    static void UpdateExpresionesSwitch()
    {
      //EXPRESIONES EN SWITCH
      Console.WriteLine("------------EXPRESIONES DE SWITCH---------------");
      //NOS SIRVE PARA SUSTITUIR AQUELLOS SWITCH PARA LOS CUALES USARIAMOS PARA ASIGNAR VALOR.
      //NUEVA VERSION
      string dia = "";
      int numero = 7;
      string horario = "nocturno";

      dia = numero switch
      {
        1 => "DOMINGO",
        2 => "LUNES",
        3 => "MARTES",
        4 => "MIERCOLES",
        5 => "JUEVES",
        6 => "VIERNES",
        7 => "SABADO",
        _ => "NUMERO INVALIDO" //CASO DE DEFAULT
      };
      Console.WriteLine(dia);

      //EJEMPLO 2
      Console.WriteLine("EJEMLPO 2 CON EXPRESIONES SWITCH");

      dia = (numero, horario) switch
      {  //TUPLA, CON MAS DE DOS VARIABLES
        (2, "diurno") => "LABORAL",
        (3, "diurno") => "LABORAL",
        (3, "nocturno") => "NO LABORAL",
        _ => "DATOS INVALIDOS",
      };
      Console.WriteLine(dia);

    }

    //6 => NULL COALESCING
    static void UpdateNullCoalescing()
    {
      //OPERADOR NULL-COALESCING ??

      string a = "HOLA";
      string? b = null;
      string r = "";

      //SI LA VARIABLE NO ES NULL CONSERVA SU VALOR
      r = a ?? "ADIOS";
      Console.WriteLine(r);

      //SI LA VARIALE ES NULL RECIBE EL VALOR DADO
      r = b ?? "ADIOS";
      Console.WriteLine(r);

      //ASIGNACION NULL-COALESCIN ES PROPIO DE C#8
      //ASIGNA A LA VARIABLE SOLO SI ES NULL;
      //ASIGNACION DE VARIABLES QUE TIENEN NULL SIN TANTO....
      b = null;
      a ??= "NO TENIA NULL";
      b ??= "TENIA NULL";

      Console.WriteLine("EL VALOR DE A QUEDA EN {0}", a);
      Console.WriteLine("EL VALOR DE B QUEDA EN {0}", b);
    }

    //7=> USO DE THIS
    static void UpdateUsoThis()
    {
      //CUATRO POSIBLES CASOS PARA EL USO DEL THIS
      //PRIMER CASO

      CAutomovil miAuto = new CAutomovil("FERRARI");
      Console.WriteLine(miAuto);
      Console.WriteLine("-------------");

      //SEGUNDO CASO
      CMascota miMascota = new CMascota();
      Console.WriteLine(miMascota);
      Console.WriteLine("----------------");

      //TERCER CASO
      CMensaje miMensaje = new CMensaje();
      miMensaje.Saluda();
      Console.WriteLine("-------------------------");

      //CUARTO CASO USO DE THIS.
      CAmigo miAmigo = new CAmigo("ALDO", "555444333");
      miAmigo.Mensajear();

    }

    //8 =>FUNCIONES LOCALES
    static void UpdateFuncionesLocales()
    {
      //USO DE LAS FUNCIONES LOCALES Y USO DE STATIC DE FUNCIONES LOCALES DE C# 8.
      //LAS FUNCIONES LOCALES PERMITEN DECLARAR UNA FUNCION ADENTRO DE OTRA, METODO DENDRO DE OTRO METODO
      // LA FUNCION LOCAL TIENE COMO AMBITO UNICAMENT A LA FUNCION DONDE FUE CREADA, SE PUEDEN COLOCAR EN : METODOS, CONSTRUCTORES, PROPIEDADES,ETC.

      string nombre = "ANA";
      string puesto = "PROGRAMADORA SENIOR";

      //DEFINIMOS EL METODO LOCAL
      int Ejemplo(int a, int b){
        int r = a + b;
        //PUEDE ACCEDER A LAS VARIABLES LOCALES A SU CLASE CONTENEDORA
        Console.WriteLine("SALUDOS A {0} , {1}", nombre, puesto);
        return r;
      }

      //HACEMOS USO DE LA FUNCION LOCAL
      Console.WriteLine("USAMOL LA FUNCION LOCAL");
      int x = Ejemplo(3, 5);
      Console.WriteLine("LA FUNCION REGRESO {0}", x);
      Console.WriteLine("---------------------------");

      // PARA C# 8 PODEMOS USAR STATIC
      // EN ESTA CASO LA FUNCION LOCAL NO PUEDE ACCEDER A LAS VARIABLES DE LA CLASE CONTENEDORA
      // C# 7 NO PERMITIA USAR STATIC
      static int Ejemplo2(int a, int b){
        int r = a + b;
        // PUEDE ACCEDER A LAS VARIABLES LOCALES  A SU CLASE CONTENEDORA? NO
        // Console.WriteLine("SALUDOS A {0}, {1}",nombre, puesto);
        return r;
      }

      //HACEMOS USO DE LA FUNCION LOCAL CON STATIC
      Console.WriteLine("--------FUNCION LOCAL CON STATIC---------");
      Console.WriteLine("USAMOS LA FGUNCION PARA C# 8");
      int y = Ejemplo2(11, 12);
      Console.WriteLine("LA FUNCION REGRESO {0}", y);
    }

    //9=> USO DE BASE
    static void UpdateUsoBase(){
      //COMO INVOCAR LA VERSION DE LA CLASE BASE DE UN METODO QUE YA TUBO OVERRIDE
      CClaseBase objeto1 = new CClaseBase();
      objeto1.Saludo();
      Console.WriteLine("----------------");

      CClaseHija objeto2 = new CClaseHija();
      objeto2.Saludo();
      Console.WriteLine("---------------------");

      objeto2.Seleccionar(1);
      objeto2.Seleccionar(2);
    }

  //10 => CAMBIOS EN EL USO DE LAS INTERFACES
  static void UpdateUsoInterfaces(){
      //VEREMOS LOS CAMBIOS QUE SUCEDEN CON LAS INTERFACES EN C#8
      MiClase miObjeto = new MiClase();

      //INVOCAMOS LA IMPLEMANTACIONES DE DEFAULT
      ((IComportamientos)miObjeto).Mostrar();

      //SI HAY IMPLEMENTACION LA USAMOL DE FORMA NORMAL
      MiEjemplo ejemplo = new MiEjemplo();
      ejemplo.Mostrar();
      Console.WriteLine("------------");

      Console.WriteLine(IComportamientos.valor);
      ejemplo.Calcular();
    }

    //11 => CONSTRUCTOR ESTATICO - OCULTAMIENTO
    static void UpdateConstructurStatico(){
      //CON CONSTUCTOR NORMAL 
      Mascota perro = new Mascota("MANCHAS");
      Mascota gato = new Mascota("MICHI");
      Mascota pez = new Mascota("NEMO");

      Console.WriteLine(perro);
      Console.WriteLine(gato);
      Console.WriteLine(pez);

      Console.WriteLine("-------------------------");

      //CON CONSTRUCTOR ESTATICO
      Console.WriteLine("CON CONSTRUCTOR STATICO");
      Alimento pan = new Alimento();
      Alimento leche = new Alimento();
      pan.Calorias = 50;
      leche.Calorias = 75;
      Console.WriteLine(pan);
      Console.WriteLine(leche);

    }

  // 12 => HERENCIA EN CLASES GENERICAS. Y CERRAR CLASE
  static void UpdateHerenciaClaseGenerica(){
      ClaseG<float> uno = new ClaseG<float>();

      uno.Valor = 17.56f;
      uno.mostrar();
      Console.WriteLine("-------------------");

      ClaseG1<bool> dos = new ClaseG1<bool>();
      dos.Valor = true;
      dos.MostrarNumero();
      Console.WriteLine("-------------------");

      ClaseGCerrado tres = new ClaseGCerrado();
      tres.MostrarCerrada();
       

      Console.WriteLine("------------");
      Clase2G<int, string> cuatro = new Clase2G<int, string>();
      cuatro.Valor = 20;
      cuatro.Dato = "HOLA";
      cuatro.MostrarDos();


    }

  //13 => STATIC EN CLASES GENERICAS.
  static void UpdateStaticClaseGenerica(){
      //COMPORTAMIENTO DE LAS VARIABLES STATICAS CUANDO TENEMOS CLASES GENERICAS. LO NORMAL ES QUE ESTA SE COMPRATE ENTRE TODAS LAS INSTANCIAS DE LAS CLASES. Y SI ALGUIEN HACE ALGUNA CAMBIO SE VE REFLEJADO EN TODAS. PEOR CON CLASES GENERICAS FUNCIONA DIFERENTE

      CMensajes<int> miInt = new CMensajes<int>(20);
      CMensajes<int> miInt2 = new CMensajes<int>(30);
      CMensajes<float> miFloat = new CMensajes<float>(3.5f);

      //TODAS LAS INT COMPRATIRAN LA VARIABLE ESTATICA CONTADOR, SIN EMABRGO EL FLOAT TENDRA SU PROPIA VARIABLE DE CONTADOR.

      miInt.Imprime();
      miInt.Imprime();
      miInt2.Imprime();
      miFloat.Imprime();
      miInt2.Imprime();
    }

    // 14 => METODOS DE PLUG-IN
    public delegate int funcion(int pNumero); //este delegado podra conectarse con aquellos metodos que retornen un entero y reciban un entero como parametro
    static void UpdateMetodoPlugIn(){
      //METODOS PLUGIN-> SON UN TIPO DE MEDTODO QUE UTILIZAN LOS DELEGADOS Y NOS SIRVE PARAQUE PODAMOS RECIBIR COMO PARAMETRO A OTRO METODO.
      //INVOCAMOS CON DOBLES
      CalcularValores(1, 10, Doble);
      Console.WriteLine("---------------------");
      //INVOCAMOS CON CUADRADOS
      CalcularValores(5, 10, Cuadrado);


    }

 //14
 //CREAMOS FUNIONES PARA EL DELEGADO
  static int Doble(int pNumero){
      return pNumero * 2;
    }
  static int Cuadrado(int pNumero){
      return pNumero * pNumero;
    }
  public static void CalcularValores(int pInicio, int pFin, funcion pFuncion){
      int n = 0;
      int calculado = 0;
      for (n = pInicio; n <= pFin; n++){
        calculado = pFuncion(n);
        Console.WriteLine("{0} -> {1}", n, calculado);
      }
    }
  }
}