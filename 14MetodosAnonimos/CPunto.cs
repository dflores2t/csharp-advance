namespace MetodosAnonimos;

//T REPRESENTA AL TIPO CON EL QUE SE TRABAJA EN UN MOMENTO DADO
public class CPunto
{
  public delegate void DelMensaje();
  public DelMensaje mensaje; //hondele a mensaje desde un metodo anonimo

  //CREAMOS VARIABLES TIPO T
  private int x;
  private int y;

  //PODEMOS RECIBIR PARAMETROS DEL TIPO T

  public CPunto(int px, int py)
  {
    x = px;
    y = py;
  }

  public override string ToString()
  {
    return string.Format("X={0}, Y={1}", x, y);
  }

  



}