namespace objetoasis;

public class CTelevisor: IElectronico{
  string marca;

  public CTelevisor(string pMarca)
  {
    marca = pMarca;
  }

  public override string ToString()
  {
    return string.Format("EL TELEVISOR ES MARCA {0}", marca);
  }

  public void Encender(bool pInterruptor){
    if(pInterruptor)
      Console.WriteLine("ENCENDIDO");
    else
      Console.WriteLine("APAGADO");
  }
}