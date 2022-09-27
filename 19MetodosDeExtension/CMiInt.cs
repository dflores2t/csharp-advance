namespace MetodosExtensio;

public class CMiInt : ISaludador{
  private int a;

  public CMiInt(int pA)
  {
    a = pA;
  }

  public override string ToString()
  {
    return string.Format("TU INT ES {0}", a);
  }
  public void Saluda(){
    Console.WriteLine("HOLA DESDE MI INT {0}",a);
  }
}