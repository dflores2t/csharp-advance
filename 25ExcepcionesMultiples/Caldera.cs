using System;

namespace excepcionesmultiples;

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
    //AQUI COLOCAMOS UNA EXCEPCION PARA ARGUMENTO INVALIDO.
    if(pAumento < 0){
      //ESTE LANZAMIENTO HA SIDO CREADO POR LAS PERSONAS QUE DISENARON Y PROGRAMARON .NET, SON LAS EXCEPCIONES QUE UTILIZA EL SISTEMA POR SI MISMO Y PODEMOS LANZAR ESAS EXCEPCIONES PARA EVITAR CREAR CLASES DE EXCEPCIONES
      //ARGUMETOUTOFRANGEEXCEPTION, SE UTILIZA CUANDO PASAMOS UN PARAMETRO Y ESE PARAMETRO SE ENCUENTRA POR FUERA DEL RANGO VALIDO
      throw new ArgumentOutOfRangeException("AUMENTO", "EL AUMENTO NO PUEDE SER NEGATIVO"); //LANZAMOS LA EXCEPCION.
    }

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
        CalderaExcepcion ex = new CalderaExcepcion(string.Format("LA CALDERA {0} SE SOBRECALIENTA", marca),"HA TRABAJADO DEMASIADO TIEMPO", DateTime.Now);
        ex.HelpLink = "dflores2t@gmail.com"; //
        //ADICIONAMOS DATOS PROPIOS A LA EXCEPCION
        throw ex;
      }
    }
  }
}
//V1 DE LA CLASE DE EXCEPCION
//TODAS LAS CLASES DE EXCEPCION PROPIAS DEBEN DE TENER ACCESO PUBLICO
public class CalderaExcepcion : ApplicationException
{
  private DateTime momento;
  private string causa;

  public DateTime Momento { get => momento; set => momento = value; }
  public string Causa { get => causa; set => causa = value; }

  public CalderaExcepcion(string pMensaje ,string pCausa, DateTime pMomento):base(pMensaje)
  {
    causa = pCausa;
    momento = pMomento;
  }
}