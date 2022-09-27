namespace erroresaplicacion;

public class Caldera
{
  private int tempMax = 120;
  private int tempActual = 0;
  private string marca = "";
  private bool funciona = true;

  public int Temperatura { get => tempActual; set => tempActual = value; }
  public string Marca { get => marca; set => marca = value; }
  public bool Funciona { get => funciona; set => funciona = value; }

  public Caldera(string pMarca, int pTemp)
  {
    tempActual = pTemp;
    marca = pMarca;
  }
 
  //v1
  public void TrabajarV1(int pAumento)
  {
    if (funciona == false)
      Console.WriteLine("LA CALDERA {0} ESTA DESCOMPUESTA", marca);
    else
    {
      tempActual += pAumento;
      Console.WriteLine("LA TEMPERATURA ACTUAL ES DE {0}", tempActual);
      if (tempActual > tempMax)
      {
        Console.WriteLine("{0} SUPERO LA TEMPERATURA, TIENE {1}", marca, tempActual);
        tempActual = tempMax;
        funciona = false;

        //LANZAR UNA EXCEPCION.
        // Y TENEMOS UNA VARIABLE PARA LA INSTANCIA
        CalderaExcepcion ex = new CalderaExcepcion(string.Format("LA CALDERA {0} SE SOBRECALIENTA", marca),"HA TRABAJADO DEMASIADO TIEMPO",DateTime.Now);
        ex.HelpLink = "dflores2t@gmail.com"; //
        //ADICIONAMOS DATOS PROPIOS A LA EXCEPCION
        throw ex;
      }
    }
  }
}
//V1 DE LA CLASE DE EXCEPCION
//TODAS LAS CLASES DE EXCEPCION PROPIAS DEBEN DE TENER ACCESO PUBLICO
public class CalderaExcepcion: ApplicationException{
  private string mensaje = "";
  private DateTime momento;
  private string causa;

  public DateTime Momento { get=> momento; set=> momento = value; }
  public string Causa   { get=>causa; set=>causa=value; }

  public CalderaExcepcion(string pMensaje, string pCausa, DateTime pMomento)
  {
    this.mensaje = pMensaje;
    causa = pCausa;
    momento = pMomento;
  }
  //HACEMOS UN OVERRIDE A LA PROPIEDAD EXCEPTION.MESSAGE
  public override string Message{
    get => string.Format("MENSAJE DE LA EXCEPCION=>{0}", mensaje);
  }
}