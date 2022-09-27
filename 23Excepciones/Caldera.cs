namespace manejoerrores;

public class Caldera{
  private int tempMax = 120;
  private int tempActual = 0;
  private string marca = "";
  private bool funciona = true;

  public int Temperatura { get=> tempActual; set=> tempActual = value; }
  public string Marca { get=> marca; set=> marca= value; }
  public bool Funciona { get=>funciona; set=> funciona = value; }

  public Caldera(string pMarca, int pTemp)
  {
    tempActual = pTemp;
    marca = pMarca;
  } 
  //HACEMOS TRABAJA LA CALDERA, SIN USAR EXCEPCIONES
  //V1
  public void TrabajarV1(int pAumento){
    if(funciona ==false)
    Console.WriteLine("LA CALDERA {0} ESTA DESCOMPUESTA", marca);
    else{
      tempActual += pAumento;
      Console.WriteLine("LA TEMPERATURA ACTUAL ES DE {0}", tempActual);
      if(tempActual > tempMax){
        Console.WriteLine("{0} SUPERO LA TEMPERATURA, TIENE {1}", marca,tempActual);
        tempActual = tempMax;
        funciona = false;
      }
    }
  }
  //v2
  public void TrabajarV2(int pAumento){
    if(funciona ==false)
    Console.WriteLine("LA CALDERA {0} ESTA DESCOMPUESTA", marca);
    else{
      tempActual += pAumento;
      Console.WriteLine("LA TEMPERATURA ACTUAL ES DE {0}", tempActual);
      if(tempActual > tempMax){
        Console.WriteLine("{0} SUPERO LA TEMPERATURA, TIENE {1}", marca,tempActual);
        tempActual = tempMax;
        funciona = false;

        //LANZAR UNA EXCEPCION.
        throw new Exception(string.Format("LA CALDERA {0} SE SOBRECALIENTA", marca));
      }
    }
  }
  //v3
  public void TrabajarV3(int pAumento){
    if(funciona ==false)
    Console.WriteLine("LA CALDERA {0} ESTA DESCOMPUESTA", marca);
    else{
      tempActual += pAumento;
      Console.WriteLine("LA TEMPERATURA ACTUAL ES DE {0}", tempActual);
      if(tempActual > tempMax){
        Console.WriteLine("{0} SUPERO LA TEMPERATURA, TIENE {1}", marca,tempActual);
        tempActual = tempMax;
        funciona = false;

        //LANZAR UNA EXCEPCION.
        // Y TENEMOS UNA VARIABLE PARA LA INSTANCIA
        Exception ex = new Exception(string.Format("LA CALDERA {0} SE SOBRECALIENTA", marca));
        ex.HelpLink = "dflores2t@gmail.com"; //
        throw ex;
      }
    }
  }
  //v4
  public void TrabajarV4(int pAumento){
    if(funciona ==false)
    Console.WriteLine("LA CALDERA {0} ESTA DESCOMPUESTA", marca);
    else{
      tempActual += pAumento;
      Console.WriteLine("LA TEMPERATURA ACTUAL ES DE {0}", tempActual);
      if(tempActual > tempMax){
        Console.WriteLine("{0} SUPERO LA TEMPERATURA, TIENE {1}", marca,tempActual);
        tempActual = tempMax;
        funciona = false;

        //LANZAR UNA EXCEPCION.
        // Y TENEMOS UNA VARIABLE PARA LA INSTANCIA
        Exception ex = new Exception(string.Format("LA CALDERA {0} SE SOBRECALIENTA", marca));
        ex.HelpLink = "dflores2t@gmail.com"; //
        //ADICIONAMOS DATOS PROPIOS A LA EXCEPCION
        ex.Data.Add("MOMENTO:", string.Format("OCURRIO EN {0}", DateTime.Now));
        ex.Data.Add("TEMPERATURA ACTUAL : ", String.Format("{0} GRADOS", tempActual));
        ex.Data.Add("INCREMENTO DADO: ", String.Format("{0} GRADOS", pAumento));
        throw ex;
      }
    }
  }
} 