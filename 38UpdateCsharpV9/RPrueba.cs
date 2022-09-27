namespace UpdateCsharpV9
{
    //PARA DEFINIR UN RECORD USAMOS LA PALABRA RECORD Y EL NOMBRO. MUY SIMILAR A UNA CLASE
    //DURANTE LA COMPILACION SUCEDE LO SIGUENTE: SE TRANSFORMA EN UNA CLASE, CREA UN CONSTRUCTOR DE COPIA Y UN METODO CLONE
    //PARA MANTENER IGUALDAD ESTRUCTURAL
    //HACE OVERRIDE A TOSTRING()

    //4. UPDATE
    // CON PROPIEDADES EXPLICITAS SE PUEDET COLOCAR LOGIA DE VALIDACION EN EL INIT

    record RPrueba{
    private double edadv4;

    public string Nombre { get; init; }
      public int Edad { get; init; } 

      //v4
      public double Edadv4 { get => edadv4; init {
        //VERIFICAMOS QUE EL VALOR SEA VALIDA
        if(double.IsNaN(value)){
          //LANZAMOS UNA EXCEPCION
          throw new ArgumentException("NO SE PUEDE COLOCAR NAN");
        }else{
          edadv4 = value;
        }
      } }

      public RPrueba(string pNombre, int pEdad)
      {
      Nombre = pNombre;
      Edad = pEdad;
    }

    //V5-LAZY EVALUATION.
    private double? salario;

    public double Salario{
      get{
        //SI NO HA SID CALCULADO, LO HACEMOS
        if(salario==null)
          salario = Edad * 1000;
        //REGRESAMOS EL VALOR POR SER TIPO NULLEABLE
        return salario.Value;
      }
      //CON EL SET YA NO HACE LAZY EVALUATION
      // set{
      //   salario = value;
      // }
    }
  }
  
}