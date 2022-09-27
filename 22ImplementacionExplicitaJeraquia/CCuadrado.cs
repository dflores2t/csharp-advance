namespace ImplementacionExplicita;
//IMPLEMENTA DOS INTERFACES QUE TIENEN METODOS CON EL MISMO NOMBRE, ESTO LO RESORVEMOS CON LA IMPLEMENTACION EXPLICITA DE INTERFACES

public class Ccuadrado: IArea, IPerimetro{
  private int lado;

  public Ccuadrado(int pLado)
  {
    lado = pLado;
  }
 void IArea.Calcular(){
    Console.WriteLine("CALCULAR AREA ={0}",lado * lado);
  }

  void IPerimetro.Calcular(){
    Console.WriteLine("CALCULAR PERIMETRO={0}", lado * 4);
  }
}