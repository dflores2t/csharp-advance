namespace ImplementacionExplicita;

public class CSuma: ICalcular{
  private int a;
  private int b;
  private int r;

  //IMPLEMANTACION DE ICALCULAR
  public int Calculo(int pa, int pb){
    a = pa;
    b = pb;
    r = a + b;
    return r;
  }

  public void MostrarDatos()
  {
    Console.WriteLine("{0} + {1} = {2}", a,b,r);
  }

  //IMPLEMENTACION DE IMOSTRAR POR LA JERARQUIA

}