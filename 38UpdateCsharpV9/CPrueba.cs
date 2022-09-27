namespace UpdateCsharpV9
{
  public class CPrueba { 
  //INIT ONLY SETTER  
  //ESTAMOS CREANDO UNA PROPIEDAD DE SOLO INICICIALIZACION, ACTUARIA COMO DE SOLO LECTURA
  //LE DAMOS UN VALOR DE DEFAULT DE INICIO
  //PERO SE PUEDE INICIALIZAR CON NEW 

  //ESTA CLASE PUEDE LLEVAR TODO LO DE CONSTRUCTOR ETC
  public int Valor { get; init; } = 10; //INIT=> INDICAMOS QUE ESTA PROPIEDAD ES INIT ONLY=> PROPEDAD DE SOLO LECTURA CON INICIALIZACON, ESTE VALOR YA NO ES MODIFICABLE. 

    private double edad;
    public string nombre;

    public CPrueba()
    {
      edad = 5;
      nombre = " sin nombre";
    }

    public override string ToString()
    {
      return string.Format("{0} TIENE {1} DE EDAD", nombre, edad);
    }
  }
}