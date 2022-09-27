namespace InterfacesMetodos;

public class CRadio : IElectronico
{
  string marca;

  public CRadio(string pMarca)
  {
    marca = pMarca;
  }

  public override string ToString()
  {
    return string.Format("EL RADIO ES MARCA {0}", marca);
  }
  public void Encender(bool pInterruptor)
  {
    if (pInterruptor)
      Console.WriteLine("ENCENDIDO");
    else
      Console.WriteLine("APAGADO");
  }
}