//UPDATE TIP 1 -> TOP LEVEL STATEMETS
//ELIMINAMOS LA PARTE ESCRITA LA FUNCION MAIN Y SU CLASE CONTENEDORA, PODEMOS USAR USING, CUALQUIER CODIGO VALIDO, DECLARACIONES
// using System;
// using static System.Console;
// WriteLine("HOLA A TODOS USANDO TEP LEVEL STATEMENT");
// WriteLine("TOY LEVEL");
// void Imprime(){
//   Console.WriteLine("DENTRO DEL METODO");
// }
// Console.WriteLine("VAMOS A INVOCAR");
// Imprime();
// Imprime();
// Console.WriteLine("FIN");
//TOP LEVEL STATEMENTE => SUCEDE QUE EL COMPILADOR TRANSFORMARA EL CODIGO A ALGO COMO LA CLASE CONTENEDORA QUE EMOS ESTADO USANDO ANTERIOMENTE
//HAY QUE NOTAR QU ECREA METODOS LOCALES Y NO PODRAN SER ACCEDIDOS DESDE OTRAS CLASES.

namespace UpdateCsharpV9
{
  public class Program
  {
    static void Main(string[] args)
    {

      //1. INIT ONLY SETTERS
      // UpdateInitOnlySetter();

      //2. RECORD
      // UpdateRecord();

      //3.VALIDACION CON INIT
      // UpdateValidacionInit();

      //4. LAZY EVALUATION
      // UpdateLazyEvaluation();

      //5. COMPARACION DE IGUALDAD
      // UpdateComparacionIgualdad();
      //6. PATTERNS CON IS
      // UpdatePatternsIs();

      //7. NEW TYPE EXPRESSION
      // UpdateNewTypeExpression();

      //8. PUNTEROS A METODOS
      // UpdatePunterosMetodos();

      //9.NUEVS TIPS NUMERICOS
      // UpdateNuevosNumericos();

      //10 TIPOS COVARIANTES
      // UpdateTipoCovariantes();

      //11 FUNCIONES LAMBDA ESTATICAS
      // UpdateLambdasEstaticas();

      //12. METODOS PARCIALES.
      UpdateMetodosParciales();
    }

    //METODOS PARA CADA NOVEDAD DE LA ACTUALIZACION DE CSHARP 9

    //1. => INIT ONLY SETTER
    static void UpdateInitOnlySetter()
    {
      //SON PROPIEDADES DE SOLO LECTURA A LA CUAL PODEMOS DARLE UN VALOR DE INICICIALIZACION.
      CPrueba prueba1 = new CPrueba { Valor = 35 }; //sin usar el constructor
      Console.WriteLine(prueba1.Valor);

      //INTENTAMOS CAMBIAR EL VALOR
      // prueba1.Valor = 50; //SOLO SE PUEDE ASIGNAR LA PROPIEDAD.

      //TIENE EL VALOR DE DEFAULT
      CPrueba prueba2 = new CPrueba();
      Console.WriteLine(prueba2.Valor);

      //SI DESEAMON INSTANCIAR CON CONSTRUCTOR E INICIALIZAR
      CPrueba prueba3 = new CPrueba() { Valor = 55 }; //usando constructor y luego inicializar
      Console.WriteLine(prueba3.Valor);
    }

    //2. => RECORD
    static void UpdateRecord()
    {
      //RECORD C#9=> LENGUAJE MULTIPARADIGMA Y AHORA INTEGRA LOS RECORD Y FORMAN PARTE DE LA PROGRAMACION FUCIONAL, SON MUY UTILIZADOS AHI.
      /*
        RECORDS SON UN TIPO ESPECIAL DE CLASE QUE TRABAJA CON DATOS INMUTABLES(NO PUEDEN SER CAMBIADOS UNA VEZ QUE TENGA VALOR), LAS CLASES INMUTABLES NOS AYUDAN A SIMPLIICAR EL CODIGO Y SON UNA PARTE IMPORTATE DE LA PROGRAMACION FUNCIONAL, DONDE LAS FUNCIONES SE PUEDEN TRATAR COMO SI FUERAN DATOS

        PARA MODIFICAR A UN OBJETO INMUTABLE, SE TIENE QUE CREAR UNA COPIA E INCORPORAR LAS MODIFICACIONES, ESTO SE CONOCE COMO MUTACION NO DESTRUCTIVA.
        LOS RECORDS AYUDAN CON ESTO GRACIAS A UN PATRON.

        EN PROGRAMACION FUNCIONAL TAMBIEN SE SUELEN USAR CLASES INMUTABLES PARA COMBINA DATOS, EL RECORD AYUDA A HACERLO MAS FACIL. LA IGUALDAD ESTRUCTURAL SIGNIFICA QUE DOS INSTANCIAS SE CONSIDERAN LA MISMA SI SUS DATOS SON LOS MISMOS. EL RECORD DA IGUALDAD ESTRUCTURAL POR DEFAULT.
      */

      //CREMOS LA INSTANCIA DEL RECORD
      RPrueba persona1 = new RPrueba("ANA", 25); //esto es inmutable no se puede cambiar
      Console.WriteLine(persona1);

      //HACEMOS LA MUTACION NO DESTRUCTIVA
      RPrueba persona2 = persona1 with { Nombre = "DANIEL" }; //esto eso una capia de pernosa 1 con el cambia de nombre = daniel
      Console.WriteLine(persona2);

      //VEREMOS SI AAFECTA EL CAMBIO AL OBJETO PERSONA 1
      Console.WriteLine(persona1);

      //LA MUTACION NO DESTRUCTIVA SUCEDE EN DOS PASOS
      //- EL CONSTRUCTOR DE COPIA CLONA EL RECODR CON TODO SU ESTADO
      //- CUALQUIER PROPIEDAD EN LA LISTA DE INICIALIZACION DE MIEMBROS SE ACTUALIZA

    }

    //3. => VALIDACION CON INIT
    static void UpdateValidacionInit()
    {
      //CREAMOS UNA INSTANCIA NORMAL
      RPrueba prueba1 = new RPrueba("ANA", 25);
      Console.WriteLine(prueba1);


      //INTENTAMOS HACEL LA MUTACION CON UN VALOR INVALIDO
      RPrueba prueba2 = prueba1 with { Edadv4 = double.NaN };
      Console.WriteLine(prueba2);


    }

    //4 => LAZY EVALUATION
    static void UpdateLazyEvaluation()
    {
      // LAZY EVALUATION ES UN PATRON QUE SE USA EN PROGRAMACION FUNCIONAL, UN VAOR NO SE CALCULA HASTA QUE ES NECESARIO Y SE GUARDA PARA REUTILIZARLO
      // NO SE  REALIZA EL CALCULO CUANDO SE INSTANCIA SI NO CUANDO ES ABSOLUTAMENTE NECESARIO.

      //CREAMOS UNA INSTANCIA
      RPrueba prueba1 = new RPrueba("ANA", 25);
      Console.WriteLine(prueba1); //el record hace un override a tostring por lo tanto al impriir hace uso del get para mostrar los datos.
      Console.WriteLine(prueba1.Salario);

      //OBSERVAMOS QUE NO SE RECALCULA EL VALOR DEL SALARIO
      RPrueba prueba2 = prueba1 with { Edad = 30 };
      Console.WriteLine(prueba2);
      Console.WriteLine(prueba2.Salario);

      //AQUI NO USAMOS EL VALOR YA CALCULADO, FORZAMOS LA ASIGNACION DE UNO
      //YA NO ES LAZY EVALUATION
      // RPrueba prueba3 = prueba1 with { Salario = 99999 };
      // Console.WriteLine(prueba3);
    }

    //5 => COMPARACION DE IGUALDA
    static void UpdateComparacionIgualdad()
    {
      //COMPARACION DE IGUALDAD ENTRE LOS RECORDS. SE CONSIDERA QUE DOS RECORS SON IGUALES SI SUS CAMPOS Y PROPIEDADES SON IGUALES.
      //NO ES COMPARACION DE INSTANCIAS, QUE PUEDEN O NO SER REFERENCIADAS A LA MISMA INSTANCIA. ES UN CASO DIERENTE.

      //CREAMOS UNA INSTANCIA 
      RPrueba prueba1 = new RPrueba("ANA", 25);

      //CREAMOS OTRA INSTANCIA
      RPrueba prueba2 = new RPrueba("ana", 25);

      //CREAMOS OTRA INSTANCIA
      RPrueba prueba3 = prueba1 with { Nombre = "DANIEL" };

      if (prueba1 == prueba2)
        Console.WriteLine("IGUALES");
      else
        Console.WriteLine("DIFERENTES");
      if (prueba1 == prueba3)
        Console.WriteLine("IUGUALES");
      else
        Console.WriteLine("DIFERENTES");
      if (prueba3 == prueba2)
        Console.WriteLine("IGUALES");
      else
        Console.WriteLine("DIFERENTES");
    }

    //6 => PATTERNS CON IS
    static void UpdatePatternsIs()
    {
      //PATTERNS
      // LOS PATRONES SE PUEDEN USAR EN IS, EN EL ESTILO VARIABLE IS PATTER EN EL SWITH
      //IS ES UTILIZADO PARA SOBER SI UNA CONVERSION DE REFERENCIA PUEDE LLEVARSE A CABO O NO CON ANTERIORIAD
      //EN EL ESTILO DE IS PATTER EN EL SWITCH

      int a = 10;
      string valor = "50";
      string dato = "daniel1";

      //HEMOS VIST IS EN OTROS CURSOS, UN REPASO
      // IS ES USADO PARA VERIFICAR SI UNA CONVERSION DE REFERENCIA PUEDE LLEVARSEA A CABO A NO
      //IS HACE USO DEL TYPE PATTERN

      object o = a;
      if (o is string) //devuelve true si cumple
        Console.WriteLine("A ES CADENA");
      o = valor;
      if (o is string)
        Console.WriteLine("VALOR ES CADENA");
      o = dato;
      if (o is string)
        Console.WriteLine("DATO ES CADENA");

      o = valor;
      if (o is int)
        Console.WriteLine("VALOR ES ENTERO");

      //TAMBIEN HACE USO DE OTRO PATRON CONOCIDO COMO PROPERTY PATTERN
      o = dato;
      if (o is string { Length: 7 })
        Console.WriteLine("SE TIENE 7 CARACTERES");

      //CONSTANT PATTERN, NOS PERMITE SI UNA CONSTANTE SE EMPAREJA CON UN OBJECT
      o = a;
      if (o is 10)
        Console.WriteLine("O ESTA REFERENCIADO A ALGUIEN QUE CONTIENE 10");

      //RELATION PATTERN
      //NOS PERMITE USAR <,>,<=,>= EN LOS PATTERNS
      if (o is > 5)
        Console.WriteLine("O SE REFERENCIA A ALGUIEN QUE TIENE MAS QUE 5");
      if (o is < 50)
        Console.WriteLine("O SE REFENCIA A ALGUIEN QUE TIENE MENOS DE 50");

      //PATTERN COMBINATOR
      // NOS PERMITE USAR AND, OR, NOT EN EL PATTER PALABRAS
      if (o is > 5 and <= 10)
        Console.WriteLine("O SE REFERENCIA A ALGUIEN EN EL RANGO 5 A 10");
    }

    //7 => NEW TYPE EXPRESSION
    static void UpdateNewTypeExpression()
    {
      // TARGET - TYPED NEW EXPRESSION
      // AL CONSTRUIR UN OBJETO EL COMPILADOR YA PUEDE INFERIR EL TIPO

      //CREMOS LA INSTANCIACION DE LA FORMA TRADICIONAL
      CPrueba persona1 = new CPrueba();

      //PODEMOS USAR EL TARGET-TYPED,
      CPrueba persona2 = new();// no se coloca el constructor, y es todo, el compilador por si mismo infiere el tipo que deseamos usar, ESTO NO FUNCIONA CON POLIMORFISMO.

      //TAMBIEN SE PUED USAR DE ESTA FORMA AL INVOCAR UN METODO
      metodo(new()); //DEBIDO AL TIPO QUE TENEMOS COMO PARAMETRO EL COMPILADOR VA INFERIR EL TIPO QUE TIENE LA INSTANCIA QUE ESTAMOS CREANDO EN ESTE PUNTO.


    }
    //7
    static void metodo(CPrueba objeto)
    {

      //HACEMOS USO DEL OBJETO
      Console.WriteLine(objeto);
    }

    //8 => PUNTEROS A METODOS
    static void UpdatePunterosMetodos()
    {
      //PUNTEROS O APUNTADORES A FUNCIONES O METODOS, 
      //SON SIMILARES A LOS DELEGADOS, PERO APUNTAN DIRECTAMENTE A UN METODO. SOLAMENTE PUEDE APUNTAR A METODOS ESTATICOS. CUANDO SE HACE USO DE ELLOS SE NECESITA TRABAJAR CEN EL CONTEXTO DE UNSAFE PORQUE PASA POR ARRIBA DE LAS MEDIDAS DE SEGURIDAD DE TIPOS DEL RUNTIME.

      //SE USAN PARA OPTIMIZAR APIS NO ADMINISTRADOS
      Console.WriteLine("AQUI CODIGO NORMAL");


      //HACEMOS UN BLOQUE DE CODIGO UNSAFE
      unsafe
      {
        //CREAMOS EL APUNTADOR, HAY QUE NOTAR QUE EL TIPO DE RETORNO VA AL FINAL
        delegate*<int, int, void> apuntador = &metodo8;

        //HACEMOS LA INVOCACION CON EL APUNTADOR
        apuntador(5, 3);
      }
      Console.WriteLine("CODIGO NORMAL DE NUEVO");
    }
    //8
    static void metodo8(int a, int b)
    {
      Console.WriteLine(a + b);
    }

    //9. NUEVOS TIPOS NUMERICOS
    static void UpdateNuevosNumericos()
    {
      // NUMEROS CON C# 9

      //NINT Y UNINT
      //SE CONOCEN COMO ENTEROS DE TIPO NATIVO. SU TAMANO CONCUERDA CON EL ESPACIO DE DIRECCINOMIENTO DEL PROCESADOR
      //Y SISTEMA OPERATIVO EN TIEMPO DE EJECUCION.
      //PUEDEN LLEGAR A SER MAS EFICIENTES QUE LOS ENTEROS NORMALES EN CIERTAS OPERACIONES DE BAJO NIVEL E INTEROP
      //SE PARECEM MUCHO A LOS ENTEROS NORMALES Y SOPORTAN OPERACIEONES ARITMETICAS OVERFLOW, ETC.
      //SE LE PUEDEN ASIGNAR ENTEROS DE 32BITS, PERO NO DE 64BITS, SE PUEDEN CONVERTIR ENTRE LOS DIFERENTES TIPOS DE ENTEROS.

      nint a = 5;
      nint b = 3;
      nint resultado = a * b;

      Console.WriteLine(resultado);
      Console.WriteLine("--------------");

      //EN TIEMPO DE EJECUCION NINT SE MAPEA A INTPTR Y NUINT A UINTPTR
      //ESTOS SON APUNTADORES/PUNTEROS.
      //ES POSIBLE CONVERTI ENTRE ELLOS SIN PROBLEMA.

      nint x = 50;
      IntPtr p = x; //int pointer
      nint y = p;

      Console.WriteLine(y);
      Console.WriteLine("------------------------");

      //HAY  QUE CONSIDERAR QUE AUNQUE SON EQUIVALENTES EL COMPILADOR NO LOS TRATA IGUAL,
      //NINT Y NUINT SON TRATADOS COMO TIPOS NUMERICOS. INTPTR, UINTPTR NO PERMITE LAS OPERACIONES ARITMETICAS CON LOS ENTEROS
      //////////////////
      ///A DIFERENCIA DE LOS ENTEROS, LOS DE PUNTO FLOTANTES TIENEN VALORES ESPECIALES QUE SON USADOS CON CIERTAS OPERACIONES
      ///DOUBL.NAN => NO TENEMOS UN NUMERO QUE PUEDA REPRESENTAR EL RESULTADO
      ///DOUBLE.POSITIVEINFINITY => INFITINO POSITIVO PARA PERMITIR O FACILITAR OPERACIONES ARITMETICA QUE ANTES HUBIERA GENERADO EXCEPCION
      ///DOUBLE.NEGATIVEINFINITY =>
      ///-0.0
      ///FLOAT.NAN
      ///

      //VEAMOS COMO SE COMPORTA LA DIVISION ENTRE CERO
      Console.WriteLine(1.0 / 0.0); //aparece el simbolo de infinito 
      Console.WriteLine(-1.0 / 0.0);
      Console.WriteLine(1.0 / -0.0);
      Console.WriteLine(-1.0 / -0.0);

      //VISUALMENTE SE PARECE AL 8 PERO COMPRBAMOS QUE NO LO ES
      Console.WriteLine((1.0 / 0.0) * 5);
      Console.WriteLine("---------------");

      //DIVIDIR CERO ENTRE CERO DA NAN
      Console.WriteLine(0.0 / 0.0);
      Console.WriteLine("--------------");

      //CUANDO USAMOS == NAN NUNCA ES IGUAL A OTRO VALOR, INCLUIDO OTRO NAN
      Console.WriteLine(0.0 / 0.0 == double.NaN);
      Console.WriteLine("-------------------");

      //LA FORMA CORRECTA DE PROBAR POR NAN ES POR MEDIO DE ISNAN
      Console.WriteLine(double.IsNaN(0.0 / 0.0)); //true

      //EQUALS SI PERMITE COMPARAR DOS NAN
      Console.WriteLine(object.Equals(0.0/0.0, double.NaN));
    }

    //10. TIPOS COVARIANTES
    static void UpdateTipoCovariantes(){
      //RETORNO DE TIPOS COVARIANTES. EN C# 8 PODEMOS HACER EL OVERRIDE DE UN METODO, QUE REGRESE UN TIPO QUE SEA SUBCLASE O DERIVADO
      //ANTES DE ESTO EL OVERRIDE A LOS METODOS NECESITABA DE TIPOS IDENTICOS DE RETORNO.

      CBase uno = new CBase();
      uno.nombre = "daniel";
      Console.WriteLine(uno);

      CBase dos = uno.Clonar();
      Console.WriteLine(dos);
     Console.WriteLine("------------------");

      //CLASE HIJA
      CHija tres = new CHija();
      tres.nombre = "ANA";
      tres.edad = 20;
      Console.WriteLine(tres);
      Console.WriteLine("-----------------------");

      CHija cuatro = tres.Clonar();
      CBase cinco = tres.Clonar();

      Console.WriteLine(cuatro);
      Console.WriteLine(cinco);


    }

    //11.FUNCIONES LAMBDA ESTATICAS
    public static int valor123 = 3;
    static void UpdateLambdasEstaticas(){
      //CUANDO SE CAPTURAN VARIABLES LOCALES, PARAMETROS, CAMPOS O EL THIS, EL COMPILADOR PUDE CREAR E INSTANCIAR UNA CLASE PRIVADA PARA PODER GUARDAR LA REFERENCIA AL DATO CAPTURADO.
      //ESTO TIENE UN COSTO EN TERMINOS DE DESEMPENO, SI EL DESEMPENO ES IMPORTATE, NO ES ALGO QUE NOS CONVENGA HACER. UNA OPTIMIZACION PARA ESTO ES UTILIZAR STATIC EN EXRPESIONES LAMDDA, FUNCIONES LOCALES O MENODOS ANONIMOS.
      //LA FUNCION LAMBDA SE EVALUA A UNA INSTANCIA DE UN DELEGADO, PERO SI LA FUNCION NO CAPTURA UNA VARIABLE, EL COMPILADOR REUTILIZA UNA INSTANCIA A LO LARGO DE LA VIDA DE LA APLICAICON, POR LO QUE NO HABRA UN NUEVO COSTO DE INSTANCIACION.
      //COLOCAMOS EL STATIC A LA FUNCION LAMBDA AL ENCAPSULAR EL METODO MULTI.
      Func<int, int> multi = static n => n * 2; //directamente el evalo, no catpurando ni referenciando algun metodo

      //USAMOS EL METODO.
      Console.WriteLine(multi(4));

      //LA FUNCION LAMBDA STATICA NO PUEDE ACCEDER A SUMANDO
      // int sumando = 5;
      // Func<int, int> sumador = static n => n + sumando; //funcion anonima nu puede contener referencia a variables externas.

      //PERO SI PUEDE ACCEDER A UNA VARIABLE ESTATICA
      Func<int, int> sumador = static n => n + valor123;
      Console.WriteLine(sumador(3));


    }

    //12. METODOS PARCIALES
    static void UpdateMetodosParciales(){
      //METODOS PARCIALES
      //SE HA VISO EL TEMA DE CLASES PARCIALES. CLASES QUE SE DEFINEN EN MAS DE UN DOCUMENTO.
      //LOS METODOS PARCIALES EXTENDIDOS QUE NES PERMITEN DEFINIR EL METODO EN UN DOCUMENTO E IMPLEMENTARLO EN OTRO
      //ESTO FUNCION CON CLASES PARCIALES Y SIEMPRE DEBE HABER UNA IMPLEMENTACION.
      CPersona alumno = new CPersona("ANA", 20);
      alumno.Muestra();

    }
  }
}