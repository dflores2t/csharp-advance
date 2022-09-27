namespace UpdateCsharp
{
  class Program
  {
    static string[] words = { "HOLA", "A", "TODOS", "MIS", "ALUMNOS" };
    static string n;
    static int e;
    static void Main(string[] args)
    {
      //1
      Console.WriteLine("1. INSERTAR UNDERSCORE EN LITERALES NUMERICOS");
      //PODEMOS INSERTAR _(UNDERSCORE) EN UN LITERAR NUMERICA
      int valor = 1_556_732;
      int dolar = valor * 2;
      Console.WriteLine("{0} * 2 = {1}", valor, dolar);

      //PODEMOS ESPECIFICAR NUMEROS EN BINARIO CON EL PREFIJO 0B
      var binari = 0b1001_1110;
      Console.WriteLine("EL VALOR COLOCADO ES {0}", binari);

      Console.WriteLine("---------------------------");
      Console.WriteLine();
      //2
      Console.WriteLine("USO DE OUT DISCARD ");

      int suma = 0;
      int multi = 0;
      Aritmetica(5, 3, out suma, out multi); //estos parametros recibirian los valores.
      Console.WriteLine("SUA {0}, MULTI {1}", suma, multi);
      Console.WriteLine("----------------------------------");
      //C7
      Aritmetica(5, 3, out int suma1, out int multi1);
      Console.WriteLine("SUA {0}, MULTI {1}", suma, multi);
      Console.WriteLine("----------------------------------");

      //DISCARD
      Console.WriteLine("DISCARD ( _ )");
      //SI NO NOS INTERESA UN PARAMETRO DE SALIDA .
      Aritmetica(10, 11, out int x, out _); //NO ME INTERESA EL ULTIMO PARAMETRO O EL PRIMERO _
      Aritmetica(15, 20, out _, out int y); //NO ME INTERESA EL PRIMERO _
      Console.WriteLine(x);
      Console.WriteLine(y);
      Console.WriteLine("---------------------");

      //3.
      Console.WriteLine("-----REFERENCIAS LOCALES------");
      string[] palabras = { "HOLA", "A", "TODOS", "MIS", "ALUMNOS" };
      ref string referencia = ref palabras[2];

      Console.WriteLine("POR INDICE  :{0}", palabras[2]);
      Console.WriteLine("POR REFERENCIA :{0}", referencia);

      referencia += " COMPLETOS"; //SE VE MODIFICADO POR EL USO DE LA REFERENCIA.

      Console.WriteLine("POR INDICE  :{0}", palabras[2]);
      Console.WriteLine("POR REFERENCIA :{0}", referencia);

      //4 REF RETURN
      Console.WriteLine("--------------REF RETURN---------");
      ref string palabra = ref Metodo(2); //para invocar un metodo que retorna una referencia local debo usar ref
      Console.WriteLine(palabra);
      Console.WriteLine("----------");
      palabra = "MUCHOS";
      Imprimir();

      //5 SHIFT -N
      Console.WriteLine("ACTUALIZACION SWITCH");
      int opc = 3;
      //uso de goto en switch, brincar entre los casos
      switch (opc)
      {
        case 1:
          Console.WriteLine("uno");
          break;
        case 2:
          Console.WriteLine("dos");
          goto default;
        case 3:
          Console.WriteLine("tres");
          goto case 1;
        case 4:
          Console.WriteLine("cuatro");
          break;
        case 5:
          Console.WriteLine("cinco");
          break;
        default:
          Console.WriteLine("en default");
          break;

      }

      Console.WriteLine("VARIABLE DE PATRON C#7");
      // object dato = null;
      // object dato = 7;
      // object dato = 7.56;
      object dato = "daniel";
      switch (dato)
      { //cuando dato tenga un int, double string etc
        case int i: //variable que funcionara para este tipo en particular.
          Console.WriteLine("EL ENTERO VALE {0}", i);
          break;
        case string s:
          Console.WriteLine("LA CADENA VALE {0}", s);
          break;
        case double d:
          Console.WriteLine("EL DOUBLE VALE {0}", d);
          break;
        case null:
          Console.WriteLine("ES UN NULL ");
          break;
      }
      Console.WriteLine("-----------------SWITCH CON USO DE WHEN--------------------------");
      object data = 9;
      //NOS PERMITE TENER UNA EXPRESION, SI SE CUMPLE EL CASO SE LLEVA ACABO
      switch (data)
      {
        case int i when i < 10:
          Console.WriteLine("EL VALOR ES MENOR A 10");
          break;
        case int i:
          Console.WriteLine("EL VALOR ES MAYOR O IGUAL A 10");
          break;

      }
      Console.WriteLine("-------------------------------------");
      //6
      Console.WriteLine("6---ACTUALIZACION A METODOS ");
      double r = Mult(5, 6);
      Console.WriteLine(r);
      numerosM();

      //7
      Console.WriteLine("----------------------------------");
      Console.WriteLine("------DESCONSTRUCTOY Y DESTRUCTOR ");
      //EL DESCONSTRUCTON NOS PERMITE TOMAR VALORES DE LOS ATRIBUTOS Y SACORLAS AL EXTERIOR
      // ES LA FGUNCION INVERSA DEL CONSTROCTUR
      //EL DESTRUCTURO PUEDE USAR LA SINTAXIS DE =>

      metodoTest();
      Console.WriteLine("VALORES RESCATADOS {0} , {1} ",n,e);

      //update 8 
      Console.WriteLine("-----------------------");
      UpdatePropiedades();

      Console.WriteLine("-----------------------");
      UpdateTuples();



    }

    //METODO PARA OUT-> VARIABLE DE SALIDA DE METODO, RETURN REGRESA UN VALOR.
    static void Aritmetica(int a, int b, out int rsum, out int rmulti)
    {
      rsum = a + b;
      rmulti = a * b;
    }

    //4METODO REF RETURN
    static ref string Metodo(int indice)
    {
      ref string referencia = ref words[indice];
      return ref referencia;
    }
    static void Imprimir()
    {
      foreach (string s in words)
        Console.WriteLine(s);
    }

    //PODEMOS USAR 'FAT ARROW' EN UN METODO COMO SI FUERA UNA EXPRESION LAMBDA Y ACTUA COMO EL RETURN
    static double Mult(double pA, double pB) => pA * pB;
    // { return pA * pB; } //en una metodo normal.

    //NUEVO C# 7
    // METODOL LOCALES
    //NOS PERMITE DECLARAR UN METODO ADENTRO DE OTRO, EL SEGUNDO METODO SOLAMENTE SE PUEDE INVOCAR DSDE EL PRIMERO
    static void numerosM(){
      Console.WriteLine(DoubleLength("HOLA"));
      Console.WriteLine(DoubleLength("A TODOS"));
      Console.WriteLine(DoubleLength("MIS ALUMNOS"));


      //METODO LOCAL
      int DoubleLength(string s) => s.Length * 2;
    }


    //7    \
    static void metodoTest()
    {
      CPrueba persona = new CPrueba("CHEPE", 19);
      Console.WriteLine(persona);
      //(n,e) = PERSONA, ESTA SINTAXIS PARA EL FRAMEWOR 4.7 EN ADELANTE
      persona.Desconstruct(out  n, out  e);
      Console.WriteLine("-----------AQUI ACABA EL METODO-----");
    }


    //UPDATE 8
   static void UpdatePropiedades(){
      //PODEMOS CREAR PROPIEDADES HACIENDO UNAS DE =>
      Console.WriteLine("<-----ACTUALIZACION DE LAS PROPIEDADSE CON USO DE => ARROW >");
      CPersona alumna = new CPersona("DENISE", 18);

      Console.WriteLine(alumna);

      //USAMOS LA DE SOLO LECTURA
      Console.WriteLine((alumna.Nombre));

      // alumna.Nombre = "SUSANA"; // NO SE PUEDE POR SER DE LECTURA
      //CPERSONA.NOBRE ES DE SOLO LECTURA.

      //USAMOS EL SET
      alumna.Edad = 20;

      Console.WriteLine(alumna);
      Console.WriteLine(alumna.Edad);

      Console.WriteLine("<---FINALIZAMOS LA UPDATE PROPERTIES.>");
    }

    //UPDATE N#9 TUPLES
    static void UpdateTuples(){
      Console.WriteLine("<-----------UPDATE TUPLAS ---------------->");
      //LAS TUPLAS NOS PERMITEN GUARDAR MULTIPLES VALORES EN UNA SOLA UNIDAD.
      //MUY UTILES PARA REGRESAR MUCHOS VALORES SIN TENER QUE USAR OUT
      //FRAMEWORK 4.7 EN ADELANTE

      //CREACION DE UNA TUPLA
      //EL COMPILADOR INFIERE LOS TIPOS
      var miTupla = ("HOLA", 57,40,"DANIEL");

      //MOSTRAMOS LOS CONTENIDOS.
      Console.WriteLine(miTupla.Item1);
      Console.WriteLine(miTupla.Item2);
      Console.WriteLine(miTupla.Item3);
      Console.WriteLine(miTupla.Item4);

      Console.WriteLine("----------------");
      //LAS TUPLAS NO SON MUTABLES, POL LO QUE PODEMOS CAMBIAR SUS CONTENIDOS
      miTupla.Item3 = 5000;
      miTupla.Item4 = "DANIEL ENRIQUE FLORES GARCIA";
      Console.WriteLine(miTupla.Item3);
      Console.WriteLine(miTupla.Item4);

      //LOS TIPLOS DE LA TUPLA PUEDES SER DEFINIDOS EXPLICITAMENTE
      (int, double) Valers = (5, 6.7);
      Console.WriteLine(Valers);

      //LOS METODOS PUEDEN REGRESAR TUPLAS
      (int,string) Persona = Metodo(); //mismas caracteristicas que devuelve el metodo como tupla.
      Console.WriteLine("FUERA DEL METODO: {0}", Persona);

      //LOS ELEMENTOS DE LAS TUPLAS PUEDEN SER NOMBRADOS
      var otraTupla = (modelo: "BEOCENN2", costo: 345);
      Console.WriteLine(otraTupla.modelo);
      Console.WriteLine(otraTupla.costo);


      //METODO QUE REGRESA UNA TUPLA
      (int, string) Metodo(){
        string nombre = "ARIANA";
        int calif = 10;

        Console.WriteLine("EN EL METODO {0}, {1}",nombre, calif);
        //REGRESAMOS UNA TUPLA CON LOS TIPOS ADECUADOS
        return (calif, nombre);
      }

      Console.WriteLine("<--------FIN TUPLAS>");
    }


  }
}